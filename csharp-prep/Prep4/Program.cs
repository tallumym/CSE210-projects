using System;

class Program
{
    static void Main(string[] args)
    //part1 - Compute
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.Write("Enter a number, then I will give you the sum of all - 0 to quit: ");
             
             string userResponse = Console.ReadLine();
             userNumber = int.Parse(userResponse);

             if (userNumber != 0)
             {
                numbers.Add(userNumber);
             }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //part2 - Average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        //part3 - Max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}