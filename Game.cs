using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultiplayerGameLobbySystem
{
    public class Game
    {

        public Player GameLogic(Player p1, Player p2)
        {
            Random random = new Random();
            int rand_num = random.Next(1, 101);

            Console.WriteLine($"Guess the number (1-100)!");

            bool flag = true;
            int number = -1;

            while (number != rand_num)
            {
                if (flag)
                {
                    Console.Write($"{p1.Nickname}: ");
                    flag = false;
                }
                else
                {
                    Console.Write($"{p2.Nickname}: ");
                    flag = true;
                }

                number = Convert.ToInt32(Console.ReadLine());
                if (number > rand_num)
                {
                    Console.WriteLine("Your number is bigger than mine. ");
                }
                else if (number < rand_num)
                {
                    Console.WriteLine("Your number is smaller than mine.");
                }


            }

            if (flag)
            {
                Console.WriteLine($"{p2.Nickname} WIN!");
                return p2;
            }
            else
            {
                Console.WriteLine($"{p1.Nickname} WIN!");
                return p1;
            }
        }
    }
}