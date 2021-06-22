
namespace Inl3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_pernr = new System.Windows.Forms.TextBox();
            this.Welcome = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_prnr = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValidated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(443, 106);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(150, 46);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Tag = "Btn_ok";
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.OkClicker);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(443, 158);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(150, 46);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.ExitClicker);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(223, 79);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(200, 39);
            this.txt_firstName.TabIndex = 2;
            this.txt_firstName.Tag = "firstName";
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(223, 124);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(200, 39);
            this.txt_lastName.TabIndex = 3;
            this.txt_lastName.Tag = "lastName";
            // 
            // txt_pernr
            // 
            this.txt_pernr.AccessibleDescription = "";
            this.txt_pernr.AccessibleName = "";
            this.txt_pernr.Location = new System.Drawing.Point(223, 169);
            this.txt_pernr.Name = "txt_pernr";
            this.txt_pernr.PlaceholderText = "YYMMDDXXXX";
            this.txt_pernr.Size = new System.Drawing.Size(200, 39);
            this.txt_pernr.TabIndex = 4;
            this.txt_pernr.Tag = "perNr";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Welcome.Location = new System.Drawing.Point(166, 18);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(147, 32);
            this.Welcome.TabIndex = 5;
            this.Welcome.Text = "Välkommen!";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(21, 79);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(114, 32);
            this.lbl_fname.TabIndex = 6;
            this.lbl_fname.Text = "Förnamn:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(21, 127);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(129, 32);
            this.lbl_lname.TabIndex = 7;
            this.lbl_lname.Text = "Efternamn:";
            // 
            // lbl_prnr
            // 
            this.lbl_prnr.AutoSize = true;
            this.lbl_prnr.Location = new System.Drawing.Point(21, 165);
            this.lbl_prnr.Name = "lbl_prnr";
            this.lbl_prnr.Size = new System.Drawing.Size(181, 32);
            this.lbl_prnr.TabIndex = 8;
            this.lbl_prnr.Text = "Personnummer:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fName,
            this.lName,
            this.prNr,
            this.gender,
            this.isValidated});
            this.dataGridView1.Location = new System.Drawing.Point(250, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 522);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fName
            // 
            this.fName.HeaderText = "Förnamn";
            this.fName.MinimumWidth = 10;
            this.fName.Name = "fName";
            this.fName.Width = 200;
            // 
            // lName
            // 
            this.lName.HeaderText = "Efternamn";
            this.lName.MinimumWidth = 10;
            this.lName.Name = "lName";
            this.lName.Width = 200;
            // 
            // prNr
            // 
            this.prNr.HeaderText = "Personnummer";
            this.prNr.MinimumWidth = 10;
            this.prNr.Name = "prNr";
            this.prNr.Width = 200;
            // 
            // gender
            // 
            this.gender.HeaderText = "Kön";
            this.gender.MinimumWidth = 10;
            this.gender.Name = "gender";
            this.gender.Width = 200;
            // 
            // isValidated
            // 
            this.isValidated.HeaderText = "Validering";
            this.isValidated.MinimumWidth = 10;
            this.isValidated.Name = "isValidated";
            this.isValidated.Width = 200;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(1187, 797);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(150, 46);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_clicker);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 875);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_prnr);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.txt_pernr);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ok);
            this.Name = "Form1";
            this.Text = "Inl 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_pernr;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_prnr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn isValidated;
        private System.Windows.Forms.Button btn_reset;
    }
}

