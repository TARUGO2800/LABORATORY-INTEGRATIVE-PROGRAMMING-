using System;

namespace ComputerAverageApp
{
    class ComputerAverageProgram
    {
        static void Main(string[] args)
        {
            double grade1, grade2, grade3, grade4, grade5;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Enter 5 grades seperated by new line: ");
            grade1 = Convert.ToInt32(Console.ReadLine());
            grade2 = Convert.ToInt32(Console.ReadLine());
            grade3 = Convert.ToInt32(Console.ReadLine()); 
            grade4 = Convert.ToInt32(Console.ReadLine());
            grade5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            double average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            double roundedAverage = Math.Round(average);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Average is " + average + " and round off to " + roundedAverage);
            Console.WriteLine("------------------------------------------------");
            Console.Write("              \nPress any key to exit...                   ");
            Console.ReadKey();


        }
    }
}
