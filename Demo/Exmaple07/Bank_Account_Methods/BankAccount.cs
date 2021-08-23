using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Methods
{
    class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount) {
            Balance += amount;
        }
        public void Withdraw(decimal amount) {
            Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}";
        }
    }
}
