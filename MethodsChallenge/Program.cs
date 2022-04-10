using System;

namespace MethodsChallenge
{
    class Program
    {

        static void Main(string[] args)
        {
            string person1 = "Rob";
            string person2 = "Mike";
            string person3 = "Darsh";
            Greeting(person1);
            Greeting(person2);
            Greeting(person3);
        }
      
        public static void Greeting(string name)
        {
            Console.WriteLine($" Hey {name}, Whats up My Guy!");
        }
    }
}
