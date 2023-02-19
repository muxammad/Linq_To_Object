﻿namespace Linq.Filtering
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

            IEnumerable<string> people = new List<string>() { "Bill", "Stave", "George", "Linux", "John" };
            var selectedNames = from n in people
                                where n.Contains("i") && n.Length > 3
                                select n;
            foreach (var name in selectedNames)
            {
                Console.WriteLine(name);
            }

            IEnumerable<string> guys = new List<string>() { "Bill", "Stave", "George", "Linux", "John" };
            var mixSelectedNames = guys.Select(n => n)
                .Where((n)=> n.Contains("i") && n.Length > 3);   
            foreach (var name in mixSelectedNames)
            {
                Console.WriteLine(name);
            }
                                   

        }
    }
}