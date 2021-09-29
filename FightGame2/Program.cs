using System;

namespace FightGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Start

            Character player = new Character();

            Console.WriteLine("What is your Warrior's name?:\n");
            player.name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Welcome to FightGame2, \nPress enter to continue.");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine(" __   __  _______  __    _  __   __ ║\n|  |_|  ||       ||  |  | ||  | |  |║\n|       ||    ___||   |_| ||  | |  |║\n|       ||   |___ |       ||  |_|  |║\n|       ||    ___||  _    ||       |║\n| ||_|| ||   |___ | | |   ||       |║\n|_|   |_||_______||_|  |__||_______|║\n=====================================");
            Console.ReadLine();
            Console.WriteLine("1. Go fight,       2. Go home.");

            #endregion
        }
    }
}
