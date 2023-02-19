namespace Linq.Grouping
{
    internal class Grouping
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1,Name = "Muxammad",Age = 20},
                new Student() {Id = 2,Name = "Rasulbek", Age = 19},
                new Student() {Id = 3,Name = "Ali", Age = 18},
                new Student() {Id = 4,Name = "javohir", Age = 19},
                new Student() {Id = 5,Name = "Jamshid", Age=20},
                new Student() {Id = 6,Name = "Muhammad", Age = 18}
            };

            var groupbyResult = students.GroupBy(x => x.Age);

            foreach (var groupby in groupbyResult)
            {
                Console.WriteLine($"Age Group: {groupby.Key}");
                foreach (var s in groupby)
                {
                    Console.WriteLine($"Student name {s.Name}");
                }
            }

            //Grouping with names
            var groupBy= students.GroupBy(x => x.Name);

            foreach (var grouped in groupBy)
            {
                Console.WriteLine($"By Name: {grouped.Key}");
                foreach (var gr in grouped)
                {
                    Console.WriteLine($"{gr.Id} {gr.Name} {gr.Age} ");
                }   
            }

        }
    }
}