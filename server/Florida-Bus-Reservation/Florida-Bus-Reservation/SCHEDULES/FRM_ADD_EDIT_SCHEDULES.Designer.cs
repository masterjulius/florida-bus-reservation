namespace Florida_Bus_Reservation.SCHEDULES
{
    partial class FRM_ADD_EDIT_SCHEDULES
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_bus_number = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sched_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_sched = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_departure_time = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUS NUMBER:";
            // 
            // cb_bus_number
            // 
            this.cb_bus_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bus_number.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bus_number.FormattingEnabled = true;
            this.cb_bus_number.Location = new System.Drawing.Point(26, 90);
            this.cb_bus_number.Name = "cb_bus_number";
            this.cb_bus_number.Size = new System.Drawing.Size(379, 33);
            this.cb_bus_number.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "SCHEDULE NAME(OPTIONAL):";
            // 
            // txt_sched_name
            // 
            this.txt_sched_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sched_name.Location = new System.Drawing.Point(26, 388);
            this.txt_sched_name.Name = "txt_sched_name";
            this.txt_sched_name.Size = new System.Drawing.Size(379, 31);
            this.txt_sched_name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "SCHEDULE REMARKS(OPTIONAL):";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(26, 488);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(379, 130);
            this.txt_description.TabIndex = 9;
            this.txt_description.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn_save.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Save_40;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(26, 636);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(379, 60);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "SCHEDULE DATE:";
            // 
            // dtp_sched
            // 
            this.dtp_sched.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_sched.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_sched.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_sched.Location = new System.Drawing.Point(26, 187);
            this.dtp_sched.MinDate = new System.DateTime(2017, 7, 7, 0, 0, 0, 0);
            this.dtp_sched.Name = "dtp_sched";
            this.dtp_sched.Size = new System.Drawing.Size(379, 31);
            this.dtp_sched.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "DEPARTURE TIME:";
            // 
            // dtp_departure_time
            // 
            this.dtp_departure_time.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_departure_time.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_departure_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_departure_time.Location = new System.Drawing.Point(26, 290);
            this.dtp_departure_time.MinDate = new System.DateTime(2017, 7, 7, 0, 0, 0, 0);
            this.dtp_departure_time.Name = "dtp_departure_time";
            this.dtp_departure_time.ShowUpDown = true;
            this.dtp_departure_time.Size = new System.Drawing.Size(379, 31);
            this.dtp_departure_time.TabIndex = 5;
            // 
            // FRM_ADD_EDIT_SCHEDULES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 719);
            this.Controls.Add(this.dtp_departure_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_sched);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sched_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_bus_number);
            this.Controls.Add(this.label1);
            this.Name = "FRM_ADD_EDIT_SCHEDULES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGE SCHEDULES";
            this.Load += new System.EventHandler(this.FRM_ADD_EDIT_SCHEDULES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_bus_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sched_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_sched;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_departure_time;
    }
}