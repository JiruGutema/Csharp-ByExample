using System;

// in C#, LINQ (Language Integrated Query) is a powerful feature that allows developers to query and manipulate data from various data sources, such as collections, databases, XML, and more, using a consistent syntax. LINQ provides a way to work with data in a more declarative manner, making it easier to read and maintain code.
// we use linq to manipulate data in collections like arrays, lists, and dictionaries. It provides a set of standard query operators that can be used to filter, sort, group, and transform data.

namespace LinqExample
{
    class Linq
    {
        public void LingMethod()
        {
            Console.WriteLine("This is an example of LINQ in C#");
            Linq linq = new Linq();
            linq.AllLinqMethods();
        }
        public void AllLinqMethods()
        {
            string[] names = { "jiru", "gutema", "abdi", "mohammed", "sami", "ali" };

            // 1. Select ----------------------------------------
            var upperNames = names.Select(n => n.ToUpper());
            Console.WriteLine("Select (uppercase): " + string.Join(", ", upperNames));

            // 2. Where -----------------------------------------
            var withA = names.Where(n => n.Contains("a"));
            Console.WriteLine("Where (contains 'a'): " + string.Join(", ", withA));

            // 3. OrderBy ---------------------------------------
            var ordered = names.OrderBy(n => n);
            Console.WriteLine("OrderBy (alphabetical): " + string.Join(", ", ordered));

            // 4. GroupBy ---------------------------------------
            var groupByFirstLetter = names.GroupBy(n => n[0]);
            Console.WriteLine("GroupBy (first letter):");
            foreach (var group in groupByFirstLetter)
            {
                Console.WriteLine($"  {group.Key}: {string.Join(", ", group)}");
            }

            // 5. Join ------------------------------------------
            string[] codes = { "A-Jira", "A-Ali", "B-Abdi" };
            var joinExample = names.Join(
                codes,
                name => name,
                code => code.Split('-')[1].ToLower(),
                (name, code) => $"{name} matched {code}"
            );
            Console.WriteLine("Join example: " + string.Join(" | ", joinExample));

            // 6. Aggregate -------------------------------------
            var concatenated = names.Aggregate((a, b) => a + ", " + b);
            Console.WriteLine("Aggregate (concatenate): " + concatenated);

            // 7. Any -------------------------------------------
            bool anyStartsWithA = names.Any(n => n.StartsWith('a'));
            Console.WriteLine("Any (starts with 'a'): " + anyStartsWithA);

            // 8. All -------------------------------------------
            bool allLengthGt2 = names.All(n => n.Length > 2);
            Console.WriteLine("All (length > 2): " + allLengthGt2);

            // 9. Distinct --------------------------------------
            string[] names2 = { "ali", "sami", "ali", "abdi" };
            var distinctNames = names2.Distinct();
            Console.WriteLine("Distinct: " + string.Join(", ", distinctNames));

            // 10. First ----------------------------------------
            Console.WriteLine("First: " + names.First());

            // 11. Last -----------------------------------------
            Console.WriteLine("Last: " + names.Last());

            // 12. Skip -----------------------------------------
            var skip2 = names.Skip(2);
            Console.WriteLine("Skip(2): " + string.Join(", ", skip2));

            // 13. Take -----------------------------------------
            var take3 = names.Take(3);
            Console.WriteLine("Take(3): " + string.Join(", ", take3));
        }
    }
}
