namespace Linq.Sorting
{
    internal class Sorting
    {
        static void Main(string[] args)
        {

            ICollection<string> programmingLanguages = new List<string>() { "C", "C++", "C#", "Java", "Rust", "Golang", "TypeScript", "JavaScript", "Php", "Osmon" };
            // Method Syntax
            var methodSyntax = programmingLanguages.OrderBy(x => x).ToList();
            foreach (var p in methodSyntax)
            {
                Console.WriteLine(p);
            }
            //Query Stntax
            var querySyntax = from p in programmingLanguages
                              orderby p
                              select p;

            foreach (var p in querySyntax)
            {
                Console.WriteLine(p);
            }

            IList<Student> students = new List<Student>()
            {
                new Student() { Id = 4, Name = "John" },
                new Student() { Id = 3, Name = "Bill" },
                new Student() { Id = 2, Name = "Stave" },
                new Student() { Id = 1, Name = "George" }
            };

            var sortedStudents = from s in students
                                 orderby s.Id
                                 select s;
           

            var sortedQuerySyntax = from s in students
                                    orderby s.Id descending
                                    select s;

            var withThanby = students.OrderBy(x => x.Id)
                .ThenBy(n => n.Name.Length);

            var withThanbyQuery = from s in students
                                  orderby s.Id,s.Name.Length
                                  select s;













        }
    }
}