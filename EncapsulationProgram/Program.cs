using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Initial amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            BankAccount user = new BankAccount(amount);
            Console.WriteLine("Initial balance is: " + user.Balance);

            int opt;

            do
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("Option 1 : Deposit Amount");
                Console.WriteLine("Option 2 : Withdraw Amount");
                Console.WriteLine("Option 3 : Show Balance");
                Console.WriteLine("Option 0 : Exit");
                Console.Write("Enter your choice : ");
                opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------\n");

                switch (opt)
                {
                    case 1:
                        user.Deposit();
                        break;
                    case 2:
                        user.Withdraw();
                        break;
                    case 3:
                        Console.WriteLine("Balance: " + user.Balance);
                        break;
                    case 0:
                        Console.WriteLine("Exiting....");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (opt > 0);

          
            Console.ReadKey();
                
        }
    }

    public class BankAccount
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
           
        }
        
        public BankAccount(double initialBalance)
        {
            if(initialBalance < 0)
            {
                Console.WriteLine("Initial Amount should be positive");
            }
            else
            {
                balance = initialBalance;
            }
        }

        public void Deposit()
        {
            double amount;

            Console.Write("Enter Amount : ");
            amount = Convert.ToDouble(Console.ReadLine());

            if(amount <= 0)
            {
                Console.WriteLine("Amount should be positive");
            }
            else
            {
                balance += amount;
            }
        }

        public void Withdraw()
        {
            double amount;
            Console.Write("Enter Amount : ");
            amount = Convert.ToDouble(Console.ReadLine());
            if(amount <= 0)
            {
                Console.WriteLine("Withdrawal Amount should be positive");
            }
            else
            {
                if(balance - amount < 0)
                {
                    Console.WriteLine("Insufficiant balance");
                }
                else
                {
                    balance -= amount;
                }
            }
        }
    }
}
