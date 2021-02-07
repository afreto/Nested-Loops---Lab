using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            string roomIndex = "";
            int totalFloors = int.Parse(Console.ReadLine());
            int totalRooms = int.Parse(Console.ReadLine());
            for (int floor = totalFloors; floor >= 1; floor--)
            {
                if (floor == totalFloors)
                {
                    roomIndex = "L";
                }
                else if (floor % 2 == 0)
                {
                    roomIndex = "O";
                }
                else
                {
                    roomIndex = "A";
                }
                for (int room = 0; room < totalRooms; room++)
                {
                    Console.Write($"{roomIndex}{floor}{room} ");
                }
                Console.WriteLine();
            }
        }

    }
}