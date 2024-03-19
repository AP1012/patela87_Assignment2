using System;

class Program
{
    static void Main(string[] args)
    {
        int evenSum = 0;
        int oddSum = 0;

             for (int i = 0; i < 10; i++)
        {
  
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is an even.");
   
                evenSum += i;
            }
            else
            {
                Console.WriteLine($"{i} is an odd.");
               
                oddSum += i;
            }
        }
                
        Console.WriteLine("Sum of even numbers: " + evenSum);
        Console.WriteLine("Sum of odd numbers: " + oddSum);
    }
}