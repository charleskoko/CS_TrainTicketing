using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_TrainTicketing
{
    public partial class Form1 : Form
    {
        private double price = 0;
        private double deposited = 0;
        private TrainTicketing ticketing = new TrainTicketing();

        public Form1()
        {
            InitializeComponent();
            chooseTicket();
        }

        private void choices(string item)
        {
            button_bezahlen.Enabled = true;
            button_reset.Enabled = true;
            listBox_ausgaben.Items.Add(item);
        }

        
        private void TicketClick(object sender, EventArgs e)
        {
            price = ticketing.TicketingClick(sender, price);
            label_fahrkartenkosten.Text = price.ToString() + " Euro";
            choices(ticketing.Ticket);
        }

        
        private void resetClick(object sender, EventArgs e)
        {
            chooseTicket();
        }

        
        private void paymentClick(object sender, EventArgs e)
        {
            activatePayment();
        }

        

        private void checkOut(object sender, EventArgs e)
        {
            deposited = ticketing.Einzahlen(sender, deposited);
            label_eingezahlt.Text = deposited.ToString() + " Euro";

            string auszahlen = ticketing.Auzahlen(price, deposited);
            if (!auszahlen.Equals(""))
            {
                listBox_ausgaben.Items.Clear();
                listBox_ausgaben.Items.Add("The ticket is printed out and the change is paid");
                listBox_ausgaben.Items.Add(auszahlen);
                listBox_ausgaben.Items.Add("Please wait. 10 seconds");
                System.Windows.Forms.Application.DoEvents();
                Thread.Sleep(10000);
                chooseTicket();
            }
        }

        private void cancelClick(object sender, EventArgs e)
        {
            chooseTicket();
        }



        private void activatePayment()
        {
            button_10_cent.Enabled = true;
            button_20_cent.Enabled = true;
            button_50_cent.Enabled = true;
            button_1_euro.Enabled = true;
            button_2_euro.Enabled = true;
            button_5_euro.Enabled = true;
            button_10_euro.Enabled = true;
            button_20_euro.Enabled = true;
            button_50_euro.Enabled = true;
            button_abbrechen.Enabled = true;
            label_eingezahlt.Enabled = true;
            button_bezahlen.Enabled = true;
            button_reset.Enabled = true;

            button_A.Enabled = false;
            button_AB.Enabled = false;
            button_BC.Enabled = false;
            button_ABC.Enabled = false;
            label_fahrkartenkosten.Enabled = false;
            label_preis.Enabled = false;
        }

        private void chooseTicket()
        {
            button_10_cent.Enabled = false;
            button_20_cent.Enabled = false;
            button_50_cent.Enabled = false;
            button_1_euro.Enabled = false;
            button_2_euro.Enabled = false;
            button_5_euro.Enabled = false;
            button_10_euro.Enabled = false;
            button_20_euro.Enabled = false;
            button_50_euro.Enabled = false;
            button_abbrechen.Enabled = false;
            label_eingezahlt.Enabled = false;
            button_bezahlen.Enabled = false;
            button_reset.Enabled = false;

            button_A.Enabled = true;
            button_AB.Enabled = true;
            button_BC.Enabled = true;
            button_ABC.Enabled = true;
            label_fahrkartenkosten.Enabled = true;
            label_preis.Enabled = true;

            price = 0;
            deposited = 0;
            label_fahrkartenkosten.Text = price.ToString() + " Euro";
            label_eingezahlt.Text = deposited.ToString() + " Euro";
            listBox_ausgaben.Items.Clear();
        }

    }
}
