using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double travelPrice = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney < travelPrice)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}