using System;
namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main (string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int apple;
            apple = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total price of " + apple + " apples: ");
            double apples = double.Parse(Console.ReadLine());
            

            Console.WriteLine("----------------------------------");
            Console.WriteLine("The total price of " + apple + " apple(s): " + apples);
            Console.WriteLine("The value of original price is " + apples);
            Console.WriteLine("The value of converted price is " + (int)apples);
            Console.WriteLine("----------------------------------");
            Console.Write("         \nPress any key to exit...         ");
            Console.ReadKey();

        }
    }
}
