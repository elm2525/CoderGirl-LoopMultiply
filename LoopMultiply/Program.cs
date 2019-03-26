using System;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int userValue = int.Parse(userInput);


            int sum = 0;
            int result = 0;
            

            for (int i = 2; i < 21; i++)
            {

                {
                    result = userValue * i;
                    Console.WriteLine(result);

                }

                //sum = ++result;
                //Console.Write(sum);
                   

                
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
