using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void MyDelegate();
    public class Bank
    {
        public event MyDelegate Insufficientbalance; // declare an event
        public event MyDelegate Zerobalance;
        public event MyDelegate Lowbalance;
        public int balance = 6000;

        public int Credit(int amount)
        {
            balance = balance + amount;
            return balance;
        }
        public void Debit(int amount)
        {
            if (amount > balance)
            {
                Insufficientbalance(); 
            }
            else
            {
                balance -= amount;

                if (balance == 0)
                {
                    Zerobalance();
                }
                else if (balance < 3000)
                {
                    Lowbalance();
                }
                else
                {
                    //balance = balance - amount;
                    Console.WriteLine(balance);
                }

            }
        }
    }

    public class Program
    {
        static void InsufficientMsg()
        {
            Console.WriteLine("You have Insufficient balance");
        }
        static void ZeroMsg()
        {
            Console.WriteLine("You have Zero balance");
        }
        static void LowMsg()
        {
            Console.WriteLine("You have Low balance");
        }

        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Insufficientbalance += new MyDelegate(InsufficientMsg);
            b.Zerobalance += new MyDelegate(ZeroMsg);
            b.Lowbalance += new MyDelegate(LowMsg);
            b.Credit(0);
            b.Debit(7000);
        }
    }
}


