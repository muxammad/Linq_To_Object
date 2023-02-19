namespace Linq.Filtering;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a list of names
        IEnumerable<string> names = new List<string>() { "Bill", "Stave", "George", "Linux", "John" };

        // Use LINQ to filter the names that contain the letter "i" and are longer than 3 characters
        var filteredNames = names.Where(name => name.Contains("i") && name.Length > 3);

        // Print out the filtered names
        foreach (var name in filteredNames)
        {
            Console.WriteLine(name);
        }

        // Create another list of names
        IEnumerable<string> people = new List<string>() { "Bill", "Stave", "George", "Linux", "John" };

        // Use LINQ to filter the names that contain the letter "i" and are longer than 3 characters, but using the query syntax
        var selectedNames = from n in people
                            where n.Contains("i") && n.Length > 3
                            select n;

        // Print out the filtered names
        foreach (var name in selectedNames)
        {
            Console.WriteLine(name);
        }

        // Create yet another list of names
        IEnumerable<string> guys = new List<string>() { "Bill", "Stave", "George", "Linux", "John" };

        // Use a combination of the two LINQ syntaxes, filtering the names that contain the letter "i" and are longer than 3 characters
        var mixSelectedNames = guys.Select(n => n)
            .Where((n) => n.Contains("i") && n.Length > 3);

        // Print out the filtered names
        foreach (var name in mixSelectedNames)
        {
            Console.WriteLine(name);
        }
    }
}

