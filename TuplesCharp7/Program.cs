using System;

namespace TuplesCharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            var personExample1 = TupleExample1.GetNameBlogAndAge();

            Console.WriteLine("{0} has a blog called {1}, and he is {2} years old",
                  personExample1.Item1, personExample1.Item2, personExample1.Item3);

            // Example 2
            var (name, blog, age) = TupleExample2.GetNameBlogAndAge();

            Console.WriteLine("{0} has a blog called {1}, and he is {2} years old",
                  name, blog, age);

            // Example 3
            var personExample3 = TupleExample3.GetNameBlogAndAge();

            Console.WriteLine("{0} has a blog called {1}, and he is {2} years old",
                  personExample3.name, personExample3.blog, personExample3.age);

            // Example 4
            var personExample4 = TupleExample4.GetNameBlogAndAge();

            Console.WriteLine("{0} has a blog called {1}, and he is {2} years old",
                  personExample4.name, personExample4.blog, personExample4.age);
        }
    }
}
