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
                    Console.WriteLine(s.Name);
                }
            }

            var result = students.GroupBy((s) => s.Id);

            foreach (var groupby in result)
            {
                Console.WriteLine($"Grouped by Id {groupby.Key}");
                foreach (var gr in groupby)
                {
                    Console.WriteLine($"{gr.Id } {gr.Name} {gr.Age} ");
                }
            }

            var lookUp = students.ToLookup(x => x.Age);
            
            foreach(var up in lookUp)
            {
                Console.WriteLine($"Age Grouping: {up.Key}");
                foreach (var p in up)
                {
                    Console.WriteLine($"{p.Id} {p.Name} {p.Age}");
                }
            }

            var resLookUp = from s in students
                            group s by s.Age;

            foreach (var age in resLookUp)
            {
                Console.WriteLine("Grouping with Age: " + age.Key);
                foreach (var res in age)
                {
                    Console.WriteLine($"{res.Id} {res.Name} {res.Age}");
                }
            }
                            
        }
    }
}