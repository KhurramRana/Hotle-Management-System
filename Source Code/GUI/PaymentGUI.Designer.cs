
namespace Project_SCD
{
    partial class PaymentGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentGUI));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_total_bill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_payment_cellnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_pay_now = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(50, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check OUT";
            // 
            // txt_total_bill
            // 
            this.txt_total_bill.Location = new System.Drawing.Point(457, 279);
            this.txt_total_bill.Name = "txt_total_bill";
            this.txt_total_bill.Size = new System.Drawing.Size(200, 23);
            this.txt_total_bill.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(328, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Bill";
            // 
            // txt_payment_cellnumber
            // 
            this.txt_payment_cellnumber.Location = new System.Drawing.Point(179, 136);
            this.txt_payment_cellnumber.Name = "txt_payment_cellnumber";
            this.txt_payment_cellnumber.PlaceholderText = "03******";
            this.txt_payment_cellnumber.Size = new System.Drawing.Size(200, 23);
            this.txt_payment_cellnumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(52, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number";
            // 
            // btn_pay_now
            // 
            this.btn_pay_now.Location = new System.Drawing.Point(522, 327);
            this.btn_pay_now.Name = "btn_pay_now";
            this.btn_pay_now.Size = new System.Drawing.Size(75, 23);
            this.btn_pay_now.TabIndex = 6;
            this.btn_pay_now.Text = "Pay Now";
            this.btn_pay_now.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(258, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "Payment";
            // 
            // PaymentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_pay_now);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_payment_cellnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_total_bill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "PaymentGUI";
            this.Text = "PaymentGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentGUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_total_bill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_payment_cellnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_pay_now;
        private System.Windows.Forms.Label label4;
    }
}