using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G44_Dice_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any Key to roll the dice");

                Console.ReadKey();

                playRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playRandomNum);
                Console.WriteLine("\n ***********");
                System.Threading.Thread.Sleep(1000);
                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy roll is a " + enemyRandomNum);
                Console.WriteLine();
                if (playRandomNum > enemyRandomNum)
                {
                    playerPoints = 0;
                    ++playerPoints;

                }
                else if (playRandomNum < enemyRandomNum)
                {
                    enemyPoints = 0;
                    ++enemyPoints;

                }
                else
                {
                    playerPoints = enemyRandomNum;
                }
            }
            Console.WriteLine(" Now the result is : ");
            Console.WriteLine();
           
                if (playerPoints > enemyPoints)
            {
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine(" \n************\n\nYou Win ...!!!\n\n************");
                }
                else if (playerPoints < enemyPoints)
            {
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("\n*************\n\nYou loose and your Enemy Win.. good luck next time !!\n\n***********");

                }
                else
            {
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("\n*************\n\nIt is Draw\n\n*************");
                
                }

            }
        }
        }
   

