namespace SharkTaxonomy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize new repository (Classifier)
            Classifier classifier = new Classifier(10);

            //Initialize entities (Shark)
            Shark greatWhite = new Shark("Great White", 5, "Seals", "Open Ocean");
            Shark hammerhead = new Shark("Hammerhead", 4, "Fish", "Tropical Waters");
            Shark tiger = new Shark("Tiger", 4, "Turtles", "Coral Reefs");
            Shark mako = new Shark("Mako", 3, "Fish", "Open Ocean");
            Shark bull = new Shark("Bull", 3, "Fish", "Rivers");
            Shark whale = new Shark("Whale", 12, "Plankton", "Open Ocean");
            Shark leopard = new Shark("Leopard", 1, "Crabs", "Shallow Waters");
            Shark goblin = new Shark("Goblin", 4, "Deep-sea Creatures", "Deep Ocean");
            Shark thresher = new Shark("Thresher", 6, "Fish", "Open Ocean");
            Shark blacktipReef = new Shark("Blacktip Reef", 2, "Fish", "Coral Reefs");
            Shark oceanicWhitetip = new Shark("Oceanic Whitetip", 3, "Fish", "Open Ocean");

            //Add sharks to the repository
            classifier.AddShark(greatWhite);
            classifier.AddShark(hammerhead);
            classifier.AddShark(tiger);
            classifier.AddShark(mako);
            classifier.AddShark(bull);
            classifier.AddShark(whale);
            classifier.AddShark(leopard);
            classifier.AddShark(goblin);
            classifier.AddShark(thresher);
            classifier.AddShark(blacktipReef);

            //Check collection count
            Console.WriteLine(classifier.GetCount);
            //10

            //Attempt to add a shark that will exceed the capacity of the Classifier
            classifier.AddShark(oceanicWhitetip);

            //Check collection count
            Console.WriteLine(classifier.GetCount);
            //10

            //Remove existing shark
            Console.WriteLine(classifier.RemoveShark("Blacktip Reef")); //Returns True

            //Check collection count
            Console.WriteLine(classifier.GetCount);
            //9

            //Try to remove not existing shark
            Console.WriteLine(classifier.RemoveShark("Blue")); //Returns False

            //Check collection count
            Console.WriteLine(classifier.GetCount);
            //9

            //Try to add once again a shark, if there is enough capacity already
            classifier.AddShark(oceanicWhitetip);

            //Check collection count
            Console.WriteLine(classifier.GetCount);
            //10

            //Get the shark that has the greatest body length
            Console.WriteLine(classifier.GetLargestShark());

            //Get the average Length of all sharks added to the collection
            Console.WriteLine(classifier.GetAverageLength());

            //Print Sharks Report
            Console.WriteLine(classifier.Report());
        }
    }
}

