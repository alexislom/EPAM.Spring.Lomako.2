using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using BookLibraryGAC;


namespace BookLibraryGACConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new[]
            {
                new Book() {Author = "Author 1", ID = 1, Publisher = "Publisher 1", Title = "Title 1"},
                new Book() {Author = "Author 2", ID = 2, Publisher = "Publisher 2", Title = "Title 2"},
                new Book() {Author = "Author 3", ID = 3, Publisher = "Publisher 3", Title = "Title 3"}
            };

            foreach (var lib in library)
            {
                Console.WriteLine(lib.ToString());
            }
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly ass in assemblies)
            {
                Console.WriteLine(ass.ToString());
            }

            var assembly = typeof(Program).Assembly;
            Console.WriteLine(assembly.CodeBase);
            Console.WriteLine(assembly.FullName);
            Console.WriteLine(assembly.EntryPoint);
        }
    }
}
