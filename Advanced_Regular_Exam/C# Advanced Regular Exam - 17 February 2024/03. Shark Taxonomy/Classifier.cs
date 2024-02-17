namespace SharkTaxonomy
{
    public class Classifier
    {
        public List<Shark> Species { get; }
        public int Capacity { get; }

        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int GetCount => Species.Count;

        public void AddShark(Shark shark)
        {
            if (Species.Count < Capacity && !Species.Any(s => s.Kind == shark.Kind))
            {
                Species.Add(shark);
            }
        }

        public bool RemoveShark(string kind)
        {
            var sharkToRemove = Species.FirstOrDefault(s => s.Kind == kind);
            if (sharkToRemove != null)
            {
                Species.Remove(sharkToRemove);
                return true;
            }
            return false;
        }

        public string GetLargestShark()
        {
            var largestShark = Species.OrderByDescending(s => s.Length).FirstOrDefault();
            return largestShark?.ToString();
        }

        public double GetAverageLength()
        {
            if (Species.Count == 0)
                return 0;

            return Species.Average(s => s.Length);
        }

        public string Report()
        {
            var report = $"{GetCount} sharks classified:\n";
            foreach (var shark in Species)
            {
                report += $"{shark}\n";
            }
            return report;
        }
    }
}
