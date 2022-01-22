using System;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        public static int j = 1001, i = 1000;
        public static string[] AccName = new string[j];
        public static string[] CreditNum = new string[j];
        public static string[] Expirationdate = new string[j];
        public static int[] SecretNum = new int[j];
        public static double[] AmountMoney = new double[j];                                                

        static void accountIn()
        {
            Console.WriteLine("please write your Full Name:");
            AccName[i] = Console.ReadLine();
            Console.WriteLine("please write your Credit Number xxxx-xxxx-xxxx-xxxx:");
            Console.WriteLine("please Type with - between every 4 numbers for example 1234-1234-1234-1234");
            CreditNum[i] = Console.ReadLine();
            Console.WriteLine("please write your Expiration Date xx/xx:");
            Console.WriteLine("please Type with / between 2 numbers for example 12/12");
            Expirationdate[i] = Console.ReadLine();
            Console.WriteLine("please write your 3 Secret Number xxx:");
            SecretNum[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the exact money number in your account");
            AmountMoney[i] = double.Parse(Console.ReadLine());
            Console.WriteLine("You'r number account is {0} please remember your number and do not tell anybody the number!", i);
            j++;
            Array.Resize(ref AccName, j);
            Array.Resize(ref CreditNum, j);
            Array.Resize(ref Expirationdate, j);
            Array.Resize(ref SecretNum, j);
            Array.Resize(ref AmountMoney, j);
            i++;
            Thread.Sleep(4000);
            Console.Clear();
        }

        static void Main(string[] args)
        {

            int Choise, accNum, cashOut, result;
            double balance, withdraw, deposit;
            string account, accName, withdrawName, nameaclearnes;
            bool Clear = true, conected = true;
            DateTime Time = DateTime.Now;

            for (; ; ) //infinty loop
            {
                Console.WriteLine("Hello, Welcome to the ATM Machine");
                Console.WriteLine("Do you have account?");
                Console.WriteLine("yes or no *pls write like that*");
                account = Console.ReadLine();
                if (account == "yes")
                {
                    Console.WriteLine("Please write your number account");
                    accNum = int.Parse(Console.ReadLine());
                    accName = AccName[accNum];
                    Console.WriteLine("what is your full name");
                    nameaclearnes = Console.ReadLine();
                    if (nameaclearnes == accName)
                    {
                        while (conected)
                        {
                            Console.WriteLine("Hello" + accName + ", Welcome to the ATM Machine");
                            Thread.Sleep(2000);
                            Console.WriteLine("What do you want to do?");
                            Console.WriteLine("1.Withdraw       3.Deposit ");
                            Console.WriteLine("2.Balance-Inq    4.Cash Out");
                            Console.WriteLine("*pick a number");
                            Choise = int.Parse(Console.ReadLine());
                            switch (Choise)
                            {
                                case (1):
                                    while (Clear)
                                    {
                                        Console.WriteLine("to who you want withdraw the money?");
                                        Console.WriteLine("*write the exact name of the person you want withdraw the cash");
                                        withdrawName = Console.ReadLine();
                                        result = Array.IndexOf(AccName, withdrawName);
                                        Console.WriteLine("who much money you want to withdraw?");
                                        withdraw = double.Parse(Console.ReadLine());
                                        if (withdraw <= AmountMoney[accNum])
                                        {
                                            AmountMoney[result] = AmountMoney[result] + withdraw;
                                            AmountMoney[accNum] = AmountMoney[accNum] - withdraw;

                                            Console.WriteLine("your Transfer passed successfully at " + Time);
                                            Console.WriteLine("your money balance now is " + AmountMoney[accNum] + " dollars");
                                            Thread.Sleep(3000);
                                            Clear = false;
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("try again");
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                        }
                                    }

                                    break;
                                case (2):
                                    Console.WriteLine("your balance is " + AmountMoney[accNum] + " dollars");
                                    Thread.Sleep(10000);
                                    Console.Clear();
                                    break;
                                case (3):
                                    Console.WriteLine("who much money you want to deposit?");
                                    deposit = double.Parse(Console.ReadLine());
                                    AmountMoney[accNum] = AmountMoney[accNum] + deposit;
                                    Console.WriteLine("your money balance now is " + AmountMoney[accNum] + " dollars");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;
                                case (4):
                                    balance = AmountMoney[accNum];
                                    Console.WriteLine("your balance is " + balance + " dollars");
                                    balance = balance * 0.20;
                                    if (balance > 8000)
                                    {
                                        while (Clear)
                                        {
                                            Console.WriteLine("you can cash out up to 8000 dollar");
                                            Console.WriteLine("who much money you want to cash out?");
                                            cashOut = int.Parse(Console.ReadLine());
                                            if (cashOut <= 8000)
                                            {
                                                Console.WriteLine("ok you cash out " + cashOut + " dollars");
                                                AmountMoney[accNum] = AmountMoney[accNum] - cashOut;
                                                Console.WriteLine("your money balance now is " + AmountMoney[accNum] + " dollars");
                                                Thread.Sleep(3000);
                                                Clear = false;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine("try again");
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                            }
                                        }

                                    }
                                    else if (balance < 8000)
                                    {
                                        Console.WriteLine("you can cash out up to" + balance + " dollar ");
                                        while (Clear)
                                        {
                                            Console.WriteLine("you can cash out up to" + balance + " dollar ");
                                            Console.WriteLine("who much money you want to cash out?");
                                            cashOut = int.Parse(Console.ReadLine());
                                            if (cashOut <= balance)
                                            {
                                                Console.WriteLine("ok you cash out " + cashOut + " dollars");
                                                AmountMoney[accNum] = AmountMoney[accNum] - cashOut;
                                                Console.WriteLine("your money balance now is " + AmountMoney[accNum] + " dollars");
                                                Thread.Sleep(3000);
                                                Clear = false;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine("try again");
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        while (Clear)
                                        {
                                            Console.WriteLine("you can cash out up to 8000 dollar");
                                            Console.WriteLine("who much money you want to cash out?");
                                            cashOut = int.Parse(Console.ReadLine());
                                            if (cashOut <= 8000)
                                            {
                                                Console.WriteLine("ok you cash out " + cashOut + " dollars");
                                                AmountMoney[accNum] = AmountMoney[accNum] - cashOut;
                                                Console.WriteLine("your money balance now is " + AmountMoney[accNum] + " dollars");
                                                Thread.Sleep(3000);
                                                Clear = false;
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                Console.WriteLine("try again");
                                                Thread.Sleep(1500);
                                                Console.Clear();
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("you did wrong function try again in 5 seconeds");
                                    Thread.Sleep(5000);
                                    conected = false;
                                    Console.Clear();
                                    break;
                            }

                        }
                    }
                    else if (nameaclearnes != accName)
                    {
                        Console.WriteLine("you did wrong function try again in 5 seconeds");
                        Thread.Sleep(5000);
                        Console.Clear();

                    }
                }
                else if (account == "no")
                {
                    accountIn();
                }
                else
                {
                    Console.WriteLine("you did wrong function try again in 5 seconeds");
                    Thread.Sleep(5000);
                    Console.Clear();
                }
            }
        }
    }
}
