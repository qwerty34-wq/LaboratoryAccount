using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneySpace;

namespace BusinessCardSpace
{
    public class BusinessCard
    {
        public string Company { get; set; }
        public string Bank { get; set; }
        public string Currency { get; set; }
        public Money money;

        public BusinessCard(string Company, string Bank, string Currency, double start_money)
        {
            this.Company = Company;
            this.Bank = Bank;
            this.Currency = Currency;
            money = new Money(Company + "_Card");
            money.setAccount(start_money);
        }


        public override string ToString()
        {
            return $"Card: {this.money.getCardNumber()}  Sum: {this.money.getAccount()}";
        }
      
    }
}
