using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Bank
    {
        private int AccountID;
        public float Balance;
        public char Type;

        public void SetAccountId(int id)
        {
            this.AccountID = id;
        }
        public int GetAccountId()
        {
            return this.AccountID; 
        } 

        public void setAccountType(char type)
        {
            this.Type = type;
        }

        public char getAccountType()
        {
            return this.Type;
        }

        public void withdraw(float amount)
        {
            if(this.Type=='S' && this.Balance-amount>1000)
            {
                this.Balance = this.Balance - amount;
            }
            else if(this.Type == 'C' && this.Balance - amount >= 0)
            {
                this.Balance = this.Balance - amount;
            }
              else if (this.Type == 'D' && this.Balance - amount >= -10000)
            {
                this.Balance = this.Balance - amount;
            }
            else
            {
                Console.WriteLine("Balance Insufficient");
            }
        }

        public void deposit(int amount)
        {
                this.Balance = this.Balance + amount;
     
        }
        public float CalculateInterest()
        {
            if(this.Type=='S')
            {
                return this.Balance * 4 / 100;

            }
            else if(this.Type=='C')
            {
                return this.Balance * 1 / 100;
            }
            else
            {
                return 0;
            }
      
        }
      


    }
}
