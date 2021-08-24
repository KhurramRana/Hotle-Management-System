
namespace Project_SCD
{
    partial class DashboardGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardGUI));
            this.btn_customer_registration = new System.Windows.Forms.Button();
            this.btn_room = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_customer_registration
            // 
            this.btn_customer_registration.Location = new System.Drawing.Point(243, 112);
            this.btn_customer_registration.Name = "btn_customer_registration";
            this.btn_customer_registration.Size = new System.Drawing.Size(161, 47);
            this.btn_customer_registration.TabIndex = 0;
            this.btn_customer_registration.Text = "Customer Registration";
            this.btn_customer_registration.UseVisualStyleBackColor = true;
            this.btn_customer_registration.Click += new System.EventHandler(this.btn_customer_registration_Click);
            // 
            // btn_room
            // 
            this.btn_room.Location = new System.Drawing.Point(243, 263);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(161, 46);
            this.btn_room.TabIndex = 1;
            this.btn_room.Text = "Room";
            this.btn_room.UseVisualStyleBackColor = true;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Location = new System.Drawing.Point(243, 185);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(161, 42);
            this.btn_payment.TabIndex = 2;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // DashboardGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(681, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btn_room);
            this.Controls.Add(this.btn_customer_registration);
            this.Name = "DashboardGUI";
            this.Text = "DashboardGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardGUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_customer_registration;
        private System.Windows.Forms.Button btn_room;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Label label1;
    }
}