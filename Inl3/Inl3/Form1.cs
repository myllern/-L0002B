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

        //Skapar en ny person med de namn och personnummer som står i de olika textbox. Skickas sedan till funktionen AddGrid.
        private void OkClicker(object sender, EventArgs e)
        {
            Person p = new Person(txt_firstName.Text, txt_lastName.Text, txt_pernr.Text);

            AddGrid(p);

        }

        //Avlustar applikationen.
        private void ExitClicker(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        //Skapar ny rad och fyller respektive cell med informationen skickats från textbox firstname, lastname och personnummer från OkClicker.
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

        //Återställer all information i datagrid.
        private void btn_reset_clicker(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
