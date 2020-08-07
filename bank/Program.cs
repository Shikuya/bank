using System;
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
            double dataid = 0;
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

            if(Choicemenu == "Create" || Choicemenu == "create") //ยังแยกคนไม่ได้ :P จำ Line ไม่ได้รอถามจารขอรับ
            {
                createmenu:
                Console.Write(topic + 
                             "Input Name : ");
                name = Console.ReadLine();
                Console.Write("Input Balance : ");
                balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input ID Number : ");
                id = Convert.ToDouble(Console.ReadLine());//
                Console.Clear();
                if(id < 0 || id > 9999999999999999)
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
                    if(Enter == "")
                    {
                        goto Choicemenu;
                    }
                    else
                    {
                        goto createfinish;
                    }
                }
            }
            else if(Choicemenu == "Deposit" || Choicemenu == "deposit")
            {
                Console.Write("Input id");

            }
            else if(Choicemenu == "Withdraw" || Choicemenu == "withdraw")
            {

            }
            else if(Choicemenu == "Check" || Choicemenu == "check") // ยังเช็ค เป็นยอดของคนๆ ไม่ได้
            {
                Console.Write("Input ID : ");
                dataid = Convert.ToDouble(Console.ReadLine());
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
            else
            {
                goto Choicemenu;
            }
        }
    }
}
