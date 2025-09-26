using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
/*
* Class name: Banking app
* Version 1
* Author: Jack Duncan
*/
namespace SimpleBankingApp_UniVersion_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildBankingApp();
        }


        static void BuildBankingApp()
        {
            //insitialse varibles
            int choice;
            double depositAmount = 0.0;
            //display menu screen
            Console.WriteLine("Please choose an option");
            Console.WriteLine("=======================");
            Console.WriteLine("1 - Deposit or withdrawl funds");
            Console.WriteLine("2- View current account information");
            Console.WriteLine("Please chopose an option(1-2)");


            //read users choice menu choice
            //convert the string to an int
            //using explict typecasting

            choice = Convert.ToInt32(Console.ReadLine());

            //the || in the lopp represents OR
            //which means that a menu choice of 1 OR 2
            //is accepted for this logical operation
            if (choice == 1 || choice == 2)
            {
                //valid menu choice
                if (choice == 1)
                {
                    Console.WriteLine("You have chosen to deposit or withdraw funds");
                    Console.WriteLine("How much do you want to deposit");
                    Console.WriteLine("Enter amount including pence using a decimal point");

                    //Typically a currency value is input as a decimal value
                    //so the double data type is used

                    depositAmount = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    //view current account information
                    Console.WriteLine("You have chosen to view current account information");
                }
            }
            else
            {
                //Invalid menu choice
                
                Console.WriteLine("Invalid menu choice, please choose 1 or 2");
            }
        }
    }
}
