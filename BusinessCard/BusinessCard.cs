using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneySpace;

namespace BusinessCard
{
    public class BusinessCard
    {
        public string Company { get; set; }
        public string Bank { get; set; }
        public string Currency { get; set; }
        public Money money;

        public BusinessCard(string Company, string Bank, string Currency)
        {
            this.Company = Company;
            this.Bank = Bank;
            this.Currency = Currency;
            money = new Money(Company + "_Card");
        }
    }
}
