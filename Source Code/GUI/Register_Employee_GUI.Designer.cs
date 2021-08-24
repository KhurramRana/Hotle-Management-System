
namespace Project_SCD
{
    partial class Register_Employee_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Employee_GUI));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete_empl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_retypepass_employee = new System.Windows.Forms.TextBox();
            this.txt_pass_eployee = new System.Windows.Forms.TextBox();
            this.txt_username_employee = new System.Windows.Forms.TextBox();
            this.combo_delete_emp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(146, 154);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete_empl
            // 
            this.btn_delete_empl.Location = new System.Drawing.Point(44, 83);
            this.btn_delete_empl.Name = "btn_delete_empl";
            this.btn_delete_empl.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_empl.TabIndex = 6;
            this.btn_delete_empl.Text = "Delete";
            this.btn_delete_empl.UseVisualStyleBackColor = true;
            this.btn_delete_empl.Click += new System.EventHandler(this.btn_delete_empl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Employee";
            // 
            // txt_retypepass_employee
            // 
            this.txt_retypepass_employee.Location = new System.Drawing.Point(62, 104);
            this.txt_retypepass_employee.Name = "txt_retypepass_employee";
            this.txt_retypepass_employee.PlaceholderText = "Re-Type Password";
            this.txt_retypepass_employee.Size = new System.Drawing.Size(236, 23);
            this.txt_retypepass_employee.TabIndex = 10;
            // 
            // txt_pass_eployee
            // 
            this.txt_pass_eployee.Location = new System.Drawing.Point(62, 64);
            this.txt_pass_eployee.Name = "txt_pass_eployee";
            this.txt_pass_eployee.PlaceholderText = "Password";
            this.txt_pass_eployee.Size = new System.Drawing.Size(236, 23);
            this.txt_pass_eployee.TabIndex = 9;
            // 
            // txt_username_employee
            // 
            this.txt_username_employee.Location = new System.Drawing.Point(62, 22);
            this.txt_username_employee.Name = "txt_username_employee";
            this.txt_username_employee.PlaceholderText = "UserName";
            this.txt_username_employee.Size = new System.Drawing.Size(236, 23);
            this.txt_username_employee.TabIndex = 8;
            // 
            // combo_delete_emp
            // 
            this.combo_delete_emp.FormattingEnabled = true;
            this.combo_delete_emp.Location = new System.Drawing.Point(21, 37);
            this.combo_delete_emp.Name = "combo_delete_emp";
            this.combo_delete_emp.Size = new System.Drawing.Size(257, 23);
            this.combo_delete_emp.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.combo_delete_emp);
            this.groupBox1.Controls.Add(this.btn_delete_empl);
            this.groupBox1.Location = new System.Drawing.Point(372, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 127);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Employee";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_username_employee);
            this.groupBox2.Controls.Add(this.txt_pass_eployee);
            this.groupBox2.Controls.Add(this.txt_retypepass_employee);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 183);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Employee";
            // 
            // Register_Employee_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Register_Employee_GUI";
            this.Text = "Register_Employee_GUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_Employee_GUI_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete_empl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_retypepass_employee;
        private System.Windows.Forms.TextBox txt_pass_eployee;
        private System.Windows.Forms.TextBox txt_username_employee;
        private System.Windows.Forms.ComboBox combo_delete_emp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}