using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosTryCatch.Exceptions;

namespace ExerciciosTryCatch.Entities
{
    internal class Account
    {
        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        // constructor default
        public Account(int numberAccount , string holder, double balance, double withDrawLimit ) 
        {
            NumberAccount = numberAccount;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        // method to deposit
        public void Deposit(double Amount)
        {
            Balance += Amount;
        }

        // method to WithDraw
        public void WithDraw(double Amount)
        {
            // if amount bigger then Balance
            if (Amount > Balance)
            {
                Console.WriteLine(new DomainException("Withdraw error: Not enough balance"));
            }
            // if Amount bigger then WithDrawLimit
            else if (Amount > WithDrawLimit) 
            {
                Console.WriteLine(new DomainException("Withdraw error: The amount exceeds withdraw limit"));
            }
            else // if amount it's Ok do this else
            {
                Balance -= Amount;
                Console.WriteLine("New balance: " + Balance.ToString());
            }
        }
    }
}
