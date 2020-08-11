using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            double id = 0;
            double balance = 0;
            String name = "";
        Choicemenu:
            Console.Clear();
            String Enter = "";
            String topic = "              =[BANK]=       \r\n\r\n";
            Console.WriteLine(topic +
                          "Create an account = Create \r\n" +
                          "Deposit money = Deposit \r\n" +
                          "Withdraw money = Withdraw \r\n" +
                          "Check money = Check \r\n" +
                          "-------------------------------------");
            Console.Write("Input Name topic : ");
            String Choicemenu = Console.ReadLine();
            Console.Clear();

            if (Choicemenu == "Create" || Choicemenu == "create")
            {
            createmenu:
                Console.Write(topic +
                             "Input Name : ");
                name = Console.ReadLine();
                Console.Write("Input Balance : ");
                balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input ID Number : ");
                id = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if (id < 0 || id > 9999999999999999)
                {
                    Console.Clear();
                    goto createmenu;
                }
                else
                {
                createfinish:
                    Console.Write(topic +
                                      "Create Account Finish \r\n\r\n" +
                                      ": Enter to menu :");
                    Enter = Console.ReadLine();
                    Console.Clear();
                    if (Enter == "")
                    {
                        goto Choicemenu;
                    }
                    else
                    {
                        goto createfinish;
                    }
                }
            }
            else if (Choicemenu == "Deposit" || Choicemenu == "deposit")
            {
                Console.Write("Input id : ");
                double idi = Convert.ToDouble(Console.ReadLine());
                if (idi == id)
                {
                    Console.WriteLine("You Balance : " + balance);
                    Console.Write("Add Money Input : ");
                    double add = Convert.ToDouble(Console.ReadLine());
                    balance = balance + add;
                Enter:
                    Console.Clear();
                    Console.Write($"Add Money Finish u money is {balance} \r\n\r\n" +
                        "Plese Enter to menu :");
                    Enter = Console.ReadLine();
                    if (Enter == "")
                    {
                        goto Choicemenu;
                    }
                    else
                    {
                        goto Enter;
                    }
                }
                else
                {
                    goto Choicemenu;
                }

            }
            else if (Choicemenu == "Withdraw" || Choicemenu == "withdraw")
            {
                Console.Write("Input id : ");
                double idi = Convert.ToDouble(Console.ReadLine());
                if (idi == id)
                {
                    Console.WriteLine("You Balance : " + balance);
                    Console.Write("Withdraw Money Input : ");
                    double add = Convert.ToDouble(Console.ReadLine());
                    balance = balance - add;
                Enter:
                    Console.Clear();
                    Console.Write($"Withdraw Money Finish u money is {balance} \r\n\r\n" +
                        "Plese Enter to menu :");
                    Enter = Console.ReadLine();
                    if (Enter == "")
                    {
                        goto Choicemenu;
                    }
                    else
                    {
                        goto Enter;
                    }
                }
            }
            else if (Choicemenu == "Check" || Choicemenu == "check") // ยังเช็ค เป็นยอดของคนๆ ไม่ได้
            {
            Menucheck:
                Console.Write("Input ID : ");
                double idi = Convert.ToDouble(Console.ReadLine());
                if (idi == id)
                {
                    Console.WriteLine($"Name : {name} ID : {id} balance : {balance} \r\n\r\n");
                Enter:
                    Console.Write("Enter to menu");
                    Enter = Console.ReadLine();
                    if (Enter == "")
                    {
                        goto Choicemenu;
                    }
                    else
                    {
                        goto Enter;
                    }
                }
                else if (!(idi == id))
                {
                    Console.Clear();
                    goto Menucheck;
                }
                else
                {
                    goto Choicemenu;
                }
            }
        }
    }
}
