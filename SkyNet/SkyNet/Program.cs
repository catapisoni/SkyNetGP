using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            string menuPick;
            List<MechanicalOperator> operators = new List<MechanicalOperator>();
            List<string> menuOptions = new List<string>();
            bool menuOptionsFlag = false;


            while (isRunning)
            {

                printMenu();

                menuPick = Console.In.ReadLine();

                switch (menuPick)
                {
                    case "1":
                        ShowOperatorStatus();
                        break;
                    case "2":
                        ShowOperatorStatusAtLocation();
                        break;
                    case "3":
                        TotalRecall();
                        break;
                    case "4":
                        SelectOperator();
                        break;
                    case "5":
                        AddReserveOperator();
                        break;
                    case "6":
                        RemoveReserveOperator();
                        break;
                    default:
                        Console.Clear();
                        Console.Out.WriteLine(" Pay attention to your inputs, please. (Press any key) ");
                        Console.In.ReadLine(); //No guarda el input, es una pausa.
                        break;
                }

                void printMenu()
                {
                    Console.Clear();
                    Console.Out.WriteLine("\n           Welcome to the Skynet Headquarters            ");
                    Console.Out.WriteLine("                     Management Menu                      ");
                    Console.Out.WriteLine(" ---------------------------------------------------------");

                    if (menuOptionsFlag == false)
                    {

                        menuOptions.Add("                  1. List all operators                   ");
                        menuOptions.Add("                 2. List operators at X                  ");
                        menuOptions.Add("                      3. Total recall                     ");
                        menuOptions.Add("                  4. Operator Operations                  ");
                        menuOptions.Add("                 5. Add Reserve Operators                 ");
                        menuOptions.Add("                6. Remove Reserve Operators               ");
                        menuOptionsFlag = true;
                    }

                    foreach (string option in menuOptions)
                    {
                        Console.Out.WriteLine(option);
                    }
                    Console.Out.WriteLine(" ---------------------------------------------------------");
                    Console.Out.WriteLine("                  Please enter your Pick:                 ");
                }

                void ShowOperatorStatus()
                {
                    return;
                }
                void ShowOperatorStatusAtLocation()
                {
                    //ask for location
                    return;
                }
                void TotalRecall()
                {
                    //Change all locations to HeadQuarters
                    return;
                }

                void SelectOperator()
                {
                    //Ask for string
                    //Show option menu for that operator
                    return;
                }

                void AddReserveOperator()
                {
                    //Ask for Operator 
                    return;
                }
                void RemoveReserveOperator()
                {
                    //Ask for Operator 
                    return;
                }

            }
        }
    }
}

