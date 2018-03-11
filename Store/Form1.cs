//Pet store, a program that sells pets.
//by Aizlea Sharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class petStore : Form
    {
        const double dogPrice = 20.00;
        const double catPrice = 10.00;
        const double fishPrice = 5.00;
        const double tax = 0.13;

        double subTotal=0;
        double taxOnly=0;
        double total=0;
        double changeTotal=0;
        int tendered=0;
        int dogsPurchased=0;
        int catsPurchased=0;
        int fishPurchased=0;
        double dogs=0;
        double cats=0;
        double fish=0;


        public petStore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try and catch for entering numbers 
            try

            {
                dogsPurchased = Convert.ToInt16(dogInput.Text);
            }
            catch
            {
                catchLabel.Text = "You need to use a number.";
                return;
            }

            try
            {
                catsPurchased = Convert.ToInt16(catInput.Text);
            }
            catch
            {
                catchLabel.Text = "You need to use a number.";
                return;
            }

            try
            {
                fishPurchased = Convert.ToInt16(fishInput.Text);
            }
            catch
            {
                catchLabel.Text = "You need to use a number.";
                return;
            }

            //displaying subtotal
            subTotal = dogPrice * dogsPurchased + catPrice * catsPurchased + fishPrice * fishPurchased;
            subTotalOutPut.Text = subTotal.ToString("C");

            //Tax 
            taxOnly = tax * subTotal;
            taxOutPut.Text = taxOnly.ToString("C");

            //real total
            total = taxOnly + subTotal;
            totalOutPut.Text = total.ToString("C");

            //tendered
            try
            {
                tendered = Convert.ToInt16(tenderedInput.Text);
            }
            catch
            {
                catchLabel.Text = "You need to use a number.";
                return;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
         
            //change total
            changeTotal = tendered - total;
            changeOutPut.Text = changeTotal.ToString("C");

        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
