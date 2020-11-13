using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Money
    {
        private string card_number { get; set; }
        private double account { get; set; }

        public Money(string card_number)
        {
            this.card_number = card_number;
            account = 0;
        }

        public double getAccount()
        {
            return account;
        }

        public string getCardNumber()
        {
            return card_number;
        }

        public void transact(Money card_number_from, Money card_number_to, double sum)
        {
            if (card_number_from.account >= sum)
            {
                card_number_from.account -= sum;
                card_number_to.account += sum;
            }
            else
            {
                throw new Exception("Not enought money to make transaction");
            }
        }

    }
}
