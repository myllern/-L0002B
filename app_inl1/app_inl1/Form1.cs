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
        int number_val;

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

                List<int> list = new List<int>();
                list.Add(500);
                list.Add(100);
                list.Add(50);
                list.Add(10);
                list.Add(5);
                list.Add(1);

                txb_change.AppendText($"Växel tillbaka: {sum} kr");
                txb_change.AppendText(Environment.NewLine);

                foreach (int item in list)
                {
                    nrOfBills(item);
                    if (number_val > 0)
                    {
                        txb_change.AppendText(nrOfBills(item));
                        txb_change.AppendText(Environment.NewLine);
                    }

                }

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
                String s = $"{val} valör tillbaka: {number_val}";
                number_val = (sum - sum % val) / val;
                sum = sum % val;
                return s;
            }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    }

