
// Amir Moeini Rad
// May 3, 2025

// Main Concept: IQueryable<out T> Interface

/*

- IEnumerable<> is executed immediately compared to IQueryable<>.
- IEnumerable<> is used with in-memory collections like lists.
- IQueryable<> is mainly used with databases in EF Core.
 
*/

namespace IQueryableDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Working with IQueryable<out T> Interface in C#.NET.");
            Console.WriteLine("---------------------------------------------------\n");


            // Create a sample list of integers.
            // The List type is a generic collection that implements IEnumerable<T> and IQueryable<T>.
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // System.Linq.IQueryable<out T> is applied for querying data in a deferred-execution manner using LINQ syntax.
            // It is actually used in ASP.NET Entity Framework to work with databases.
            // The LINQ query is then converted to an SQL query.
            // The following LINQ query is not executed immediately. It is executed later in the foreach loop.
            // The query selects numbers greater than 2.
            IQueryable<int> query = numbers.AsQueryable().Where(n => n > 2);

            // The actual query is executed here. (Hence, deferred execution)
            Console.WriteLine("LINQ Query Result:\n");
            foreach (var num in query)
            {
                Console.Write(num + " ");
            }
            // Output: 3, 4, 5


            Console.WriteLine("\n\nDone.");
        }
    }
}
