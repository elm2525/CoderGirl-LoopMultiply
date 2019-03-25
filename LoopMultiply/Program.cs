using System;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            Console.WriteLine();

            int sum = 0;
            int result = 0;

            for (int number = 2; number < 21; number++)
            {
                if (number > 0)
                {
                    result = number * number++;
                    Console.WriteLine(result);

                }
            }

            /*if (result > 0)
            {
                sum = 
                Console.WriteLine(number);
                    
            }
            */        

           

            Console.ReadLine();    
        }

          
            

            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 

            // TODO: When the loop is finished, output the sum of all previous values.

           
    
    }
}
