namespace Linq.Filtering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = new List<string>() { "Bill", "Stave", "George", "Linux", "John" };
            var filteredNames = names.Where(name => name.Contains("i") && name.Length > 3);
            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}