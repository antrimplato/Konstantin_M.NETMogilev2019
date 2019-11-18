using System;

namespace Module5
{
    class Program
    {
        static int[,] trapField = new int[10, 10];
        static int[] randomArray = new int[10];
        const int princessPositionRow = 9;
        const int princessPositionColumn = 9;
        static int heroPositionRow;
        static int heroPositionColumn;
        static int heroIconPosX;
        static int heroIconPosY;
        static int hitPoints;
        static bool trapIndicator;

        static void Main()
        {
            //Console.SetWindowSize(,);
            heroPositionRow = 0;
            heroPositionColumn = 0;
            heroIconPosX = 12;
            heroIconPosY = 6;
            hitPoints = 10;

            CreateRandomArray();
            CreateTrapField();
            PrintGameField();
            Game();
        }

        static void Game()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(heroIconPosX, heroIconPosY);
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        CheckAction(0, -1);
                        break;

                    case ConsoleKey.DownArrow:
                        CheckAction(0, 1);
                        break;

                    case ConsoleKey.LeftArrow:
                        CheckAction(-1, 0);
                        break;

                    case ConsoleKey.RightArrow:
                        CheckAction(1, 0);
                        break;
                }

            } while (key.Key != ConsoleKey.R);

            Main();
        }

        static void CheckAction(int changeRow, int changeColumn)
        {
            int checkNextPositionRow = heroPositionRow + changeRow;
            int checkNextPositionColumn = heroPositionColumn + changeColumn;

            if (checkNextPositionRow > -1 && checkNextPositionRow < 10 && checkNextPositionColumn < 10 && checkNextPositionColumn > -1)
            {
                if (checkNextPositionRow == princessPositionRow && checkNextPositionColumn == princessPositionColumn)
                {
                    MoveHero(changeRow, changeColumn);
                    YouWon();
                }
                else if (trapField[checkNextPositionRow, checkNextPositionColumn] > 0)
                {
                    GetDamage(checkNextPositionRow, checkNextPositionColumn);
                    MoveHero(changeRow, changeColumn);
                    Console.SetCursorPosition(heroIconPosX, heroIconPosY);
                    Console.Write("*");
                    trapIndicator = true;
                    Game();
                }
                else
                {
                    MoveHero(changeRow, changeColumn);
                    Game();
                }
            }
            else
                Game();
        }

        static void MoveHero(int changeRow, int changeColumn)
        {
            Console.SetCursorPosition(heroIconPosX, heroIconPosY);
            if (trapIndicator == false)
                Console.Write("·");

            else
            {
                Console.Write("*");
                trapIndicator = false;
            }

            heroPositionRow += changeRow;
            heroPositionColumn += changeColumn;

            Console.SetCursorPosition(heroIconPosX += changeRow * 2, heroIconPosY += changeColumn);
            Console.Write("H");
        }

        static void GetDamage(int changeRow, int changeColumn)
        {
            hitPoints -= trapField[changeRow, changeColumn];
            trapField[changeRow, changeColumn] = 0;
            Console.SetCursorPosition(16, 4);
            Console.Write("Health =   \b\b");
            Console.Write(hitPoints);

            if (hitPoints < 1)
            {
                Console.SetCursorPosition(heroIconPosX, heroIconPosY);
                if (trapIndicator == false)
                    Console.Write("·");
                else
                {
                    Console.Write("*");
                    trapIndicator = false;
                }
                Console.SetCursorPosition(12 + changeRow * 2, 6 + changeColumn);
                Console.Write("±");
                YouLose();
            }

            Console.SetCursorPosition(heroIconPosX, heroIconPosY);
            Console.Write("*");
        }

        static void YouLose()
        {
            Console.SetCursorPosition(17, 10);
            Console.WriteLine("You  dead");
            Console.SetCursorPosition(21, 11);
            Console.WriteLine("+");
            Console.SetCursorPosition(18, 12);
            Console.WriteLine("Press R");
            Console.SetCursorPosition(15, 13);
            Console.WriteLine("to try again!");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine(":(");

            var isR = Console.ReadKey().Key;
            if (isR == ConsoleKey.R)
                Main();

            YouLose();
        }

        static void YouWon()
        {
            Console.SetCursorPosition(15, 9);
            Console.WriteLine("*************");
            Console.SetCursorPosition(15, 10);
            Console.WriteLine("* YOU  WON! *");
            Console.SetCursorPosition(15, 11);
            Console.WriteLine("*************");
            Console.SetCursorPosition(18, 12);
            Console.WriteLine("Press R");
            Console.SetCursorPosition(15, 13);
            Console.WriteLine("and try again!");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("♥");

            var isR = Console.ReadKey().Key;
            if (isR == ConsoleKey.R)
                Main();

            YouWon();
        }


        static void PrintGameField()
        {
            Console.Clear();
            Console.WriteLine("H - this is Hero        * - triggered trap");
            Console.WriteLine("P - this is Princess    press 'R' for restart");
            Console.SetCursorPosition(0, 3);
            Console.Write("Use arrows and your intuition! Save the  Princess!");
            Console.SetCursorPosition(16, 4);
            Console.WriteLine("Health = 10");

            Console.SetCursorPosition(12, 5);
            Console.WriteLine("^ ^ ^ ^ ^ ^ ^ ^ ^ ^");
            for (var counter = 0; counter < 10; counter++)
            {
                Console.SetCursorPosition(10, 6 + counter);
                Console.WriteLine("<                     >");
            }
            Console.SetCursorPosition(12, 16);
            Console.WriteLine("v v v v v v v v v v");

            Console.SetCursorPosition(12, 6);
            Console.WriteLine("H");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("P");
            Console.CursorVisible = false;

            // For display traps on the field.
            //for (var counter = 0; counter < 10; ++counter)
            //{
            //    Console.SetCursorPosition(12, 6 + counter);
            //    for (var counter2 = 0; counter2 < 10; ++counter2)
            //    {
            //        if (trapField[counter2, counter] > 0 && trapField[counter2, counter] < 10)
            //            Console.Write(trapField[counter2, counter] + " ");
            //        else if (trapField[counter2, counter] == 10)
            //            Console.Write("10");
            //        else
            //            Console.Write("  ");
            //    }
            //    Console.WriteLine();
            //}
        }

        static void CreateTrapField()
        {
            // Clear array.
            for (var counter = 0; counter < 10; counter++)
            {
                for (var counter2 = 0; counter2 < 10; counter2++)
                    trapField[counter, counter2] = 0;
            }

            Random rand = new Random();

            // Fill array.
            for (var counter = 0; counter < 10; ++counter)
                trapField[randomArray[counter], rand.Next(0, 10)] = rand.Next(1, 11);
        }

        // Support arr for unique random trap field.
        static void CreateRandomArray()
        {
            var random = new Random();
            for (var counter = 0; counter < 10; ++counter)
            {
                bool isUnique;
                do
                {
                    randomArray[counter] = random.Next(0, 10);
                    isUnique = true;
                    for (var counter2 = 0; counter2 < counter; ++counter2)
                        if (randomArray[counter] == randomArray[counter2])
                        {
                            isUnique = false;
                            break;
                        }
                } while (!isUnique);
            }
        }
    }
}