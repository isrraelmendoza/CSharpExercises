using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Type a name (or hit ENTER to quit: ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                break;
                names.Add(input);
            }

            if(names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} other(s) like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
           
        }
    }
}
