using MoneySpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class CreditCard
    {
        public string Bank { get; set; }
        public DateTime date_credit_get { get; set; }
        public double Percent { get; set; }
        public Money money;

        public CreditCard(string Bank, double Percent, double start_money)
        {
            this.Bank = Bank;
            date_credit_get = DateTime.Now;
            this.Percent = Percent;
            money = new Money(GenerateCreditCardNumber());
            money.setAccount(start_money);
        }

        public CreditCard(string Bank, DateTime time_start, double Percent, double start_money)
        {
            this.Bank = Bank;
            date_credit_get = time_start;
            this.Percent = Percent;
            money = new Money(GenerateCreditCardNumber());
            money.setAccount(start_money);
        }

        public CreditCard(string Bank, double Percent)
        {
            this.Bank = Bank;
            date_credit_get = DateTime.Now;
            this.Percent = Percent;
            money = new Money(GenerateCreditCardNumber());
        }

        public CreditCard(double Percent)
        {
            this.Bank = "no info";
            date_credit_get = DateTime.Now;
            this.Percent = Percent;
            money = new Money(GenerateCreditCardNumber());
        }

        public string GetCardNumber()
        {
            return this.money.getCardNumber();
        }

        private string GenerateCreditCardNumber()
        {
            string credit_card_number = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int a = random.Next(0, 9);
                credit_card_number += a.ToString();
            }

            return credit_card_number;
        }

    }
}
