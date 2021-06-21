using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inl3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkClicker(object sender, EventArgs e)
        {
            Person p = new Person(txt_firstName.Text, txt_lastName.Text, txt_pernr.Text);

            AddGrid(p);

        }

        private void ExitClicker(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }


        private void AddGrid(Person p)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);
            newRow.Cells[0].Value = p.GetFName();
            newRow.Cells[1].Value = p.GetLName();
            newRow.Cells[2].Value = p.GetPrNr();
            newRow.Cells[3].Value = p.GetGender();
            newRow.Cells[4].Value = p.ValidateNr();

            dataGridView1.Rows.Add(newRow);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_clicker(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();

        }
    }
}
