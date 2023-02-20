using System.Collections.Immutable;

namespace Linq.Joining
{
    internal class Joining
    {
        static void Main(string[] args)
        {
            IList<string> name1 = new List<string>()
            {
                "John",
                "Jack",
                "Martian",
                "Bob"
            };
            IList<string> name2 = new List<string>()
            {
                "Jack",
                "Martian",
                "George",
                "Neo"

            };

            var innerJoin = name1.Join(name2, (inner) => inner, (outter) => outter, (inner, outter) => inner);


            IList<Student> student1 = new List<Student>()
        {
            new Student() {Id= 1,Name = "Muxammad",StandardId = 1},
            new Student() {Id= 2,Name = "Rasulbek",StandardId = 2},
            new Student() {Id= 3,Name = "Javohir",StandardId = 3},
            new Student() {Id= 4,Name = "Ali",StandardId = 4},
            new Student() {Id= 5,Name = "Abdurahim",StandardId = 5},


        };
        IList<Standard> standards = new List<Standard>()
        {
            new Standard() { StandardId = 1, StandardName = "Standard 1" },
            new Standard() { StandardId = 2, StandardName = "Standard 2" },
            new Standard() { StandardId = 3, StandardName = "Standard 3" },
           
        };
            var res = student1.Join(standards, (student1) => student1.Id, (standards) => standards.StandardId, (student1, standards) => new
            {
                Name = student1.Name,
                StandardName = standards.StandardName,
            });

            var joinQuerySyntax = from j in student1
                                  join inner in standards
                                  on j.StandardId equals inner.StandardId
                                  select new
                                  {
                                      Name = j.Name,
                                      StandardName = inner.StandardName
                                  };

            foreach (var item in joinQuerySyntax)
            {
                Console.WriteLine(item);
            }


        }
    } 
}