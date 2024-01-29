﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                string[] tokens = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Trainer trainer = new Trainer(trainerName);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                var targetTrainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (targetTrainer == null)
                {
                    trainers.Add(trainer);
                    trainer.Pokemons.Add(pokemon);
                }
                else
                {
                    targetTrainer.Pokemons.Add(pokemon);
                }

                command = Console.ReadLine();
            }

            string InputElement = Console.ReadLine();

            while (InputElement != "End")
            {
                foreach (var currentTrainer in trainers)
                {
                    if (currentTrainer.Pokemons.Any(x => x.Element == InputElement))
                    {
                        currentTrainer.Badges++;
                    }
                    else
                    {
                        if (currentTrainer.Pokemons.Any())
                        {
                            foreach (var pokemon in currentTrainer.Pokemons.OrderByDescending(x => x.Health))
                            {
                                pokemon.Health -= 10;

                                if (pokemon.Health <= 0)
                                {
                                    currentTrainer.Pokemons.Remove(pokemon);

                                    if (!currentTrainer.Pokemons.Any())
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                InputElement = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}