using System;

namespace api
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 100;
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.countFizzBuzz(counter, 3, 5);
        }
    }
}
