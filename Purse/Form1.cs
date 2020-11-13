using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreditCardSpace;
using BusinessCardSpace;

namespace Purse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CreditCardForm creditCard = new CreditCardForm();
            var res = creditCard.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                return;
            }



            if (creditCard.textBox1.Text != "" && creditCard.textBox2.Text != "")
            {
                CreditCard card = new CreditCard(creditCard.textBox1.Text, (double)creditCard.numericUpDown1.Value, Convert.ToDouble(creditCard.textBox2.Text));
                listBox1.Items.Add(card);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BusinessCardForm form = new BusinessCardForm();
            var res = form.ShowDialog();
            if (res == DialogResult.Cancel)
                return;

            if (form.textBox1.Text != "" && form.textBox2.Text != "" && form.textBox3.Text != "" && form.textBox4.Text != "")
            {
                BusinessCard card = new BusinessCard(form.textBox1.Text, form.textBox2.Text, form.textBox3.Text, Convert.ToDouble(form.textBox4.Text));
                listBox2.Items.Add(card);
            }
        }
    }
}
