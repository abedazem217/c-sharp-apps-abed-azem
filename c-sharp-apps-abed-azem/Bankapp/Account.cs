using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.Bankapp
{
    class Account
    {
        private Owner owner;
        private double balance;
        private int overdraft;
        private const  int max_overdraft = 90000;


        public Account(Owner owner, double balance , int overdraft)
        {
            this.owner = owner;
            this.balance = balance;
            this.overdraft = overdraft;
        }

        public Owner GetOwner()
        {
            return owner;
        }
        public double GetBalance()
        {
            return balance;
        }
        public int GetOverDraft()
        {
            return overdraft;
        }

        public void SetOverdraft(int overdraft)
        {
            if (overdraft > max_overdraft)
            {
                Console.WriteLine("the max over draft ammount is - "+ max_overdraft);

               
            }
            else
            {
                this.overdraft = overdraft;
            }
        }
   
        public void Deposit(double ammount)
        {
            balance += ammount;

        }

        public void Withdraw(double withdraw)
        {
            if (balance - withdraw < overdraft * -1)
            {
                Console.WriteLine(" you cant overdraw more thean the overdraft");
            }
            else
            {
                balance -= withdraw;
            }
        }


    }
}
