using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inl1
{
    public partial class Form1 : Form
    {
        //global sum variable
        int sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //Hämtar pris och betalning från textfälten för respektive variable.
            int price = Convert.ToInt32(txb_price.Text);

            int deposit = Convert.ToInt32(txb_deposit.Text);

            sum = deposit-price;

            //I övrigt samma kod som i konsolapplikationen förutom att resultatet visas i en textbox (txb_change) istället för konsolen.
            if (sum > 0)
            {
                txb_change.AppendText($"Växel tillbaka: {sum} kr");
                txb_change.AppendText(Environment.NewLine);

                txb_change.AppendText(nrOfBills(500));
                txb_change.AppendText(Environment.NewLine);
                txb_change.AppendText(nrOfBills(100));
                txb_change.AppendText(Environment.NewLine);
                txb_change.AppendText(nrOfBills(50));
                txb_change.AppendText(Environment.NewLine);
                txb_change.AppendText(nrOfBills(20));
                txb_change.AppendText(Environment.NewLine);
                txb_change.AppendText(nrOfBills(10));
                txb_change.AppendText(Environment.NewLine);
                txb_change.AppendText(nrOfBills(5));
                txb_change.AppendText(Environment.NewLine);
                txb_change.AppendText(nrOfBills(1));
                txb_change.AppendText(Environment.NewLine);

            }
            // ganska självbeskrivande
            if (sum == 0)
            {
                txb_change.AppendText("Allt betalt");
                txb_change.AppendText(Environment.NewLine);
                txb_change.AppendText("\n--------------------------------------------------------\n");
                txb_change.AppendText(Environment.NewLine);

                return;
            }

            else
            {
                // ganska självbeskrivande
                sum = deposit - price;
                txb_change.AppendText("Ej tillräcklig betalning... ");
                txb_change.AppendText(Environment.NewLine);
                txb_change.AppendText("\n--------------------------------------------------------\n");
                txb_change.AppendText(Environment.NewLine);

                return;
            }
        }
            // tar in valören som skall printas.
            public String nrOfBills(int val)
            {
                String s = $"{val} valör tillbaka: {(sum - sum % val) / val}";
                sum = sum % val;
                return s;
            }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    }

