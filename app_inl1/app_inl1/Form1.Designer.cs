
namespace app_inl1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_price = new System.Windows.Forms.TextBox();
            this.txb_deposit = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_deposit = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.txb_change = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_price
            // 
            this.txb_price.Location = new System.Drawing.Point(131, 56);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(100, 20);
            this.txb_price.TabIndex = 2;
            // 
            // txb_deposit
            // 
            this.txb_deposit.Location = new System.Drawing.Point(131, 95);
            this.txb_deposit.Name = "txb_deposit";
            this.txb_deposit.Size = new System.Drawing.Size(100, 20);
            this.txb_deposit.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(285, 56);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(285, 95);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Avsluta";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(44, 63);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(24, 13);
            this.lbl_price.TabIndex = 6;
            this.lbl_price.Text = "Pris";
            // 
            // lbl_deposit
            // 
            this.lbl_deposit.AutoSize = true;
            this.lbl_deposit.Location = new System.Drawing.Point(44, 102);
            this.lbl_deposit.Name = "lbl_deposit";
            this.lbl_deposit.Size = new System.Drawing.Size(34, 13);
            this.lbl_deposit.TabIndex = 7;
            this.lbl_deposit.Text = "Betalt";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(44, 19);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(65, 13);
            this.Welcome.TabIndex = 8;
            this.Welcome.Text = "Välkommen!";
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Location = new System.Drawing.Point(44, 154);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(33, 13);
            this.lbl_change.TabIndex = 9;
            this.lbl_change.Text = "Växel";
            // 
            // txb_change
            // 
            this.txb_change.Location = new System.Drawing.Point(47, 179);
            this.txb_change.Multiline = true;
            this.txb_change.Name = "txb_change";
            this.txb_change.Size = new System.Drawing.Size(564, 248);
            this.txb_change.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_change);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.lbl_deposit);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txb_deposit);
            this.Controls.Add(this.txb_price);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.TextBox txb_deposit;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_deposit;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.TextBox txb_change;
    }
}

