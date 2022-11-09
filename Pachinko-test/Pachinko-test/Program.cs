using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pachinko_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] gameBoard = new string[9][];
            int counter = 0;       
            int prevPos = 0;
            int prevRow = 0;
            int newPos = 0;
            int testCounter = 1;
            int id = 1;
            int[] finSlot = new int[9];
            int initTest = 0;
            Random rnd = new Random();

            for (int i = 0; i < gameBoard.Length; i++) 
            {            
                    gameBoard[i] = new string[i+1];
            }

            for (int i = 0; i < gameBoard.Length; i++)
                for (int x = 0; x < gameBoard[i].Length; x++)
                    gameBoard[i][x] = "*";

            foreach (string[] el in gameBoard) 
            {
                Console.WriteLine(el.Length);
            }

            Console.WriteLine("Dropping the ball now");

            while (initTest < 5) 
            {
                while (testCounter < 100)
                {
                    while (counter <= gameBoard.Length)
                    {

                        foreach (string[] el in gameBoard)
                        {
                            foreach (string elArr in el)
                            {
                                Console.Write(elArr.ToString());
                            }
                            Console.Write("\n");
                        }

                        if (counter < 1)
                        {
                            gameBoard[counter][0] = "X";
                            prevPos = 0;
                            newPos = rnd.Next(0, 1000000);
                            newPos %= 100000;
                            newPos %= 10000;
                            newPos %= 2;
                        }
                        else if (counter == 1)
                        {
                            gameBoard[prevRow][prevPos] = "*";
                            gameBoard[counter][newPos] = "x";
                            prevPos = newPos;

                            if (newPos == 0)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 0;
                                }
                                else
                                {
                                    newPos = 1;
                                }
                            }
                            else if (newPos == 1)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 1;
                                }
                                else
                                {
                                    newPos = 2;
                                }
                            }
                        }
                        else if (counter == 2)
                        {
                            gameBoard[prevRow][prevPos] = "*";
                            gameBoard[counter][newPos] = "x";
                            prevPos = newPos;

                            if (newPos == 0)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 0;
                                }
                                else
                                {
                                    newPos = 1;
                                }
                            }
                            else if (newPos == 1)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 1;
                                }
                                else
                                {
                                    newPos = 2;
                                }
                            }
                            else if (newPos == 2)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 2;
                                }
                                else
                                {
                                    newPos = 3;
                                }
                            }

                        }
                        else if (counter == 3)
                        {
                            gameBoard[prevRow][prevPos] = "*";
                            gameBoard[counter][newPos] = "x";
                            prevPos = newPos;

                            if (newPos == 0)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 0;
                                }
                                else
                                {
                                    newPos = 1;
                                }
                            }
                            else if (newPos == 1)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 1;
                                }
                                else
                                {
                                    newPos = 2;
                                }
                            }
                            else if (newPos == 2)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 2;
                                }
                                else
                                {
                                    newPos = 3;
                                }
                            }
                            else if (newPos == 3)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 3;
                                }
                                else
                                {
                                    newPos = 4;
                                }
                            }

                        }
                        else if (counter == 4)
                        {
                            gameBoard[prevRow][prevPos] = "*";
                            gameBoard[counter][newPos] = "x";
                            prevPos = newPos;

                            if (newPos == 0)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 0;
                                }
                                else
                                {
                                    newPos = 1;
                                }
                            }
                            else if (newPos == 1)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 1;
                                }
                                else
                                {
                                    newPos = 2;
                                }
                            }
                            else if (newPos == 2)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 2;
                                }
                                else
                                {
                                    newPos = 3;
                                }
                            }
                            else if (newPos == 3)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 3;
                                }
                                else
                                {
                                    newPos = 4;
                                }
                            }
                            else if (newPos == 4)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 4;
                                }
                                else
                                {
                                    newPos = 5;
                                }
                            }

                        }
                        else if (counter == 5)
                        {
                            gameBoard[prevRow][prevPos] = "*";
                            gameBoard[counter][newPos] = "x";
                            prevPos = newPos;

                            if (newPos == 0)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 0;
                                }
                                else
                                {
                                    newPos = 1;
                                }
                            }
                            else if (newPos == 1)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 1;
                                }
                                else
                                {
                                    newPos = 2;
                                }
                            }
                            else if (newPos == 2)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 2;
                                }
                                else
                                {
                                    newPos = 3;
                                }
                            }
                            else if (newPos == 3)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 3;
                                }
                                else
                                {
                                    newPos = 4;
                                }
                            }
                            else if (newPos == 4)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 4;
                                }
                                else
                                {
                                    newPos = 5;
                                }
                            }
                            else if (newPos == 5)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 5;
                                }
                                else
                                {
                                    newPos = 6;
                                }
                            }

                        }
                        else if (counter == 6)
                        {
                            gameBoard[prevRow][prevPos] = "*";
                            gameBoard[counter][newPos] = "x";
                            prevPos = newPos;

                            if (newPos == 0)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 0;
                                }
                                else
                                {
                                    newPos = 1;
                                }
                            }
                            else if (newPos == 1)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 1;
                                }
                                else
                                {
                                    newPos = 2;
                                }
                            }
                            else if (newPos == 2)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 2;
                                }
                                else
                                {
                                    newPos = 3;
                                }
                            }
                            else if (newPos == 3)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 3;
                                }
                                else
                                {
                                    newPos = 4;
                                }
                            }
                            else if (newPos == 4)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 4;
                                }
                                else
                                {
                                    newPos = 5;
                                }
                            }
                            else if (newPos == 5)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 5;
                                }
                                else
                                {
                                    newPos = 6;
                                }
                            }
                            else if (newPos == 6)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 6;
                                }
                                else
                                {
                                    newPos = 7;
                                }
                            }

                        }
                        else if (counter == 7)
                        {
                            gameBoard[prevRow][prevPos] = "*";
                            gameBoard[counter][newPos] = "x";
                            prevPos = newPos;
                            if (newPos == 0)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 0;
                                }
                                else
                                {
                                    newPos = 1;
                                }
                            }
                            else if (newPos == 1)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 1;
                                }
                                else
                                {
                                    newPos = 2;
                                }
                            }
                            else if (newPos == 2)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 2;
                                }
                                else
                                {
                                    newPos = 3;
                                }
                            }
                            else if (newPos == 3)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 3;
                                }
                                else
                                {
                                    newPos = 4;
                                }
                            }
                            else if (newPos == 4)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 4;
                                }
                                else
                                {
                                    newPos = 5;
                                }
                            }
                            else if (newPos == 5)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 5;
                                }
                                else
                                {
                                    newPos = 6;
                                }
                            }
                            else if (newPos == 6)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 6;
                                }
                                else
                                {
                                    newPos = 7;
                                }
                            }
                            else if (newPos == 7)
                            {
                                newPos = rnd.Next(0, 1000000);
                                newPos %= 100000;
                                newPos %= 10000;
                                newPos %= 2;

                                if (newPos == 0)
                                {
                                    newPos = 7;
                                }
                                else
                                {
                                    newPos = 8;
                                }
                            }
                        }
                        else if (counter == 8)
                        {
                            gameBoard[prevRow][prevPos] = "*";
                            gameBoard[counter][newPos] = "x";
                            prevPos = newPos;
                        }

                        prevRow = counter;
                        counter++;

                        Task.Delay(50).Wait();
                        Console.Clear();
                    }

                    for (int i = 0; i < gameBoard[gameBoard.Length - 1].Length; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (gameBoard[gameBoard.Length - 1][i] != "*")
                                {
                                    finSlot[0]++;
                                }
                                break;
                            case 1:
                                if (gameBoard[gameBoard.Length - 1][i] != "*")
                                {
                                    finSlot[1]++;
                                }
                                break;
                            case 2:
                                if (gameBoard[gameBoard.Length - 1][i] != "*")
                                {
                                    finSlot[2]++;
                                }
                                break;
                            case 3:
                                if (gameBoard[gameBoard.Length - 1][i] != "*")
                                {
                                    finSlot[3]++;
                                }
                                break;
                            case 4:
                                if (gameBoard[gameBoard.Length - 1][i] != "*")
                                {
                                    finSlot[4]++;
                                }
                                break;
                            case 5:
                                if (gameBoard[gameBoard.Length - 1][i] != "*")
                                {
                                    finSlot[5]++;
                                }
                                break;
                            case 6:
                                if (gameBoard[gameBoard.Length - 1][i] != "*")
                                {
                                    finSlot[6]++;
                                }
                                break;
                            case 7:
                                if (gameBoard[gameBoard.Length - 1][i] != "*")
                                {
                                    finSlot[7]++;
                                }
                                break;
                            case 8:
                                if (gameBoard[gameBoard.Length - 1][i] != "*")
                                {
                                    finSlot[8]++;
                                }
                                break;
                        }
                    }

                    counter = 0;
                    for (int i = 0; i < gameBoard.Length; i++)
                        for (int x = 0; x < gameBoard[i].Length; x++)
                            gameBoard[i][x] = "*";
                    testCounter++;
                }

                foreach (int el in finSlot)
                {

                    Console.WriteLine("Slot " + id + "= " + el);
                    id++;

                }
                for (int i = 0; i < finSlot.Length; i++)
                    finSlot[i] = 0;

                Console.ReadLine();

                testCounter = 0;
                initTest++;

            }
            
        
            Console.ReadLine();
                
            
        }
    }
}
