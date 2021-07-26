using System;

namespace api
{
    public class FizzBuzz 
    {
        public void countFizzBuzz(int count, int x, int y) 
        {
            for(int i=1; i<count; i++) 
            {
                Console.WriteLine(FizzBuzzer(i, x, y));
            }
        }
        public String FizzBuzzer(int i, int fizzVal, int buzzVal)
        {
            int divisionFizzBuzz = fizzVal * buzzVal;
            string output = "";
            if(i % divisionFizzBuzz == 0)
            {
                output = "FizzBuzz";
            } 
            else if(i % buzzVal == 0)
            {
                output = "Buzz";
            }
            else if(i % fizzVal == 0)
            {
                output += "Fizz";
            }
            else 
            {
                output = i.ToString();
            }
            return output;
        }
    }
}