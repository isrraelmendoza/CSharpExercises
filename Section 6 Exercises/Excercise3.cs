using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6_Exercises
    //write a program and ask the uder to enter 5 numbers. if a number previuously entered, 
    //display an error message and ask the uder to re-try. once the user succesfully enters 5 unique
    //numbers, sort them and display the result on the console. 
{
    class Excercise3
    {
        public void Lists()
        {
            var numbers = new List<int>();
            while (numbers.Count<5)
            {
                Console.WriteLine("Enter a numbers: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}