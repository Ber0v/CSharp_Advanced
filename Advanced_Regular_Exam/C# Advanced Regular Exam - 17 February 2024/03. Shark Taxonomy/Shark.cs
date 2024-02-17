namespace SharkTaxonomy
{
    public class Shark
    {
        public string Kind { get; }
        public int Length { get; }
        public string Food { get; }
        public string Habitat { get; }

        public Shark(string kind, int length, string food, string habitat)
        {
            Kind = kind;
            Length = length;
            Food = food;
            Habitat = habitat;
        }

        public override string ToString()
        {
            return $"{Kind} shark: {Length}m long.\nCould be spotted in the {Habitat}, typical menu: {Food}";
        }
    }
}
