
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.txt_firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(223, 124);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(200, 39);
            this.txt_lastName.TabIndex = 3;
            this.txt_lastName.Tag = "lastName";
            this.txt_lastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_pernr
            // 
            this.txt_pernr.Location = new System.Drawing.Point(223, 169);
            this.txt_pernr.Name = "txt_pernr";
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
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Förnamn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Efternamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Personnummer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 748);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.txt_pernr);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ok);
            this.Name = "Form1";
            this.Text = "Inl 3";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

