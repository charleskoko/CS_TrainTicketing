using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_TrainTicketing
{
    class TrainTicketing
    {
        private string ticket;
        private List<double> money = new List<double>() { 0.10, 0.20, 0.50, 1.00, 2.00, 5.00, 10.00, 20.00, 50.00 };

        public string Ticket
        {
            get { return ticket; }
        }

        public double TicketingClick(object sender, double price)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "button_A":
                    price += 2.00;
                    ticket = "A";
                    break;
                case "button_AB":
                    price += 2.90;
                    ticket = "AB";
                    break;
                case "button_BC":
                    price += 3.30;
                    ticket = "BC";
                    break;
                case "button_ABC":
                    price += 3.60;
                    ticket = "ABC";
                    break;
            }
            return Math.Round(price, 2);
        }

        public double Einzahlen(object sender, double deposited)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "button_10_cent":
                    deposited += money[0];
                    break;
                case "button_20_cent":
                    deposited += money[1];
                    break;
                case "button_50_cent":
                    deposited += money[2];
                    break;
                case "button_1_euro":
                    deposited += money[3];
                    break;
                case "button_2_euro":
                    deposited += money[4];
                    break;
                case "button_5_euro":
                    deposited += money[5];
                    break;
                case "button_10_euro":
                    deposited += money[6];
                    break;
                case "button_20_euro":
                    deposited += money[7];
                    break;
                case "button_50_euro":
                    deposited += money[8];
                    break;
            }
            return Math.Round(deposited, 2);
        }

        public string Auzahlen(double price, double deposited)
        {
            string text = "change: ";
            if (price <= deposited)
            {
                double change = Math.Round(deposited - price, 2);
                for (int i = money.Count - 1; i >= 0; i--)
                {
                    while (true)
                    {
                        if (money[i] <= change)
                        {
                            change = Math.Round(change - money[i], 2);
                            text += $"{money[i]} Euro, ";
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return text;
            }
            return "";
        }
    }
}
