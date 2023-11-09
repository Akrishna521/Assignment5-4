using System;

class Program
{
    static void Main(string[] args)
    {
      
        int[] numbers = new int[5];
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }
        
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double average = (double)sum / numbers.Length;

        Console.WriteLine("Sum of the elements in the array: " + sum);
        Console.WriteLine("Average of the elements in the array: " + average);
    }
}