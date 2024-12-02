using System;

class Program
{
    static void Main()
    {
        Console.Write("How many questions? ");
        if (int.TryParse(Console.ReadLine(), out int numberOfQuestions))
        {
            Random random = new Random();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                bool answer = random.Next(2) == 0;
                Console.WriteLine(answer ? "Yes" : "No");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
