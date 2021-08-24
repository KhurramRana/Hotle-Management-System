
namespace Project_SCD
{
    partial class RoomGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomGUI));
            this.btn_addroom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_roomno = new System.Windows.Forms.TextBox();
            this.txt_room_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bed = new System.Windows.Forms.TextBox();
            this.combo_roomtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_roomStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addroom
            // 
            this.btn_addroom.Location = new System.Drawing.Point(163, 306);
            this.btn_addroom.Name = "btn_addroom";
            this.btn_addroom.Size = new System.Drawing.Size(75, 23);
            this.btn_addroom.TabIndex = 6;
            this.btn_addroom.Text = "Add";
            this.btn_addroom.UseVisualStyleBackColor = true;
            this.btn_addroom.Click += new System.EventHandler(this.btn_addroom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // txt_roomno
            // 
            this.txt_roomno.Location = new System.Drawing.Point(142, 43);
            this.txt_roomno.Name = "txt_roomno";
            this.txt_roomno.PlaceholderText = "Type Room Number";
            this.txt_roomno.Size = new System.Drawing.Size(226, 23);
            this.txt_roomno.TabIndex = 8;
            // 
            // txt_room_price
            // 
            this.txt_room_price.Location = new System.Drawing.Point(143, 191);
            this.txt_room_price.Name = "txt_room_price";
            this.txt_room_price.PlaceholderText = "Price";
            this.txt_room_price.Size = new System.Drawing.Size(226, 23);
            this.txt_room_price.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bed ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Type";
            // 
            // txt_bed
            // 
            this.txt_bed.Location = new System.Drawing.Point(143, 82);
            this.txt_bed.Name = "txt_bed";
            this.txt_bed.PlaceholderText = "Type Bed Capacity";
            this.txt_bed.Size = new System.Drawing.Size(226, 23);
            this.txt_bed.TabIndex = 10;
            // 
            // combo_roomtype
            // 
            this.combo_roomtype.FormattingEnabled = true;
            this.combo_roomtype.Items.AddRange(new object[] {
            "Non Ac",
            "Dulex",
            "Suit"});
            this.combo_roomtype.Location = new System.Drawing.Point(143, 137);
            this.combo_roomtype.Name = "combo_roomtype";
            this.combo_roomtype.Size = new System.Drawing.Size(226, 23);
            this.combo_roomtype.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room No";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_roomStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combo_roomtype);
            this.groupBox1.Controls.Add(this.txt_bed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_room_price);
            this.groupBox1.Controls.Add(this.txt_roomno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_addroom);
            this.groupBox1.Location = new System.Drawing.Point(144, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 349);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Room";
            // 
            // txt_roomStatus
            // 
            this.txt_roomStatus.Location = new System.Drawing.Point(143, 239);
            this.txt_roomStatus.Name = "txt_roomStatus";
            this.txt_roomStatus.PlaceholderText = "Available/Booked";
            this.txt_roomStatus.Size = new System.Drawing.Size(226, 23);
            this.txt_roomStatus.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // RoomGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 373);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "RoomGUI";
            this.Text = "Room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomGUI_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_addroom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_roomno;
        private System.Windows.Forms.TextBox txt_room_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bed;
        private System.Windows.Forms.ComboBox combo_roomtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_roomStatus;
        private System.Windows.Forms.Label label5;
    }
}