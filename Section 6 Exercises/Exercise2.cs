using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6_Exercises
{

    class Exercise2
    {
        public void Lists()
        {

            {
                Console.Write("What is your name: ");
                var name = Console.ReadLine();

                var array = new char[name.Length];
                for (var i = name.Length; i > 0; i--)
                    array[name.Length - i] = name[i - 1];

                var reveresed = new string(array);
                Console.WriteLine("Reversed name: " + reveresed);
            }
        }
    }
}
