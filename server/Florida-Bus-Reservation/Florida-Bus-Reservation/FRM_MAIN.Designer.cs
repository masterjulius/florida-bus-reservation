namespace Florida_Bus_Reservation
{
    partial class FRM_MAIN
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
            this.toolStrip_main = new System.Windows.Forms.ToolStrip();
            this.toolStrip_dropdown_system = new System.Windows.Forms.ToolStripDropDownButton();
            this.uSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sIGNINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_bus_bus = new System.Windows.Forms.ToolStripDropDownButton();
            this.mANAGECLASSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mANAGEBUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_dropdown_schedule = new System.Windows.Forms.ToolStripDropDownButton();
            this.mANAGESCHEDULESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_dropdown_reservation = new System.Windows.Forms.ToolStripDropDownButton();
            this.mANAGERESERVATIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mANAGEPAYMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWTRANSACTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.toolStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_dropdown_system,
            this.toolStripSeparator1,
            this.toolStrip_bus_bus,
            this.toolStripSeparator2,
            this.toolStrip_dropdown_schedule,
            this.toolStripSeparator3,
            this.toolStrip_dropdown_reservation});
            this.toolStrip_main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.Size = new System.Drawing.Size(1375, 32);
            this.toolStrip_main.TabIndex = 0;
            this.toolStrip_main.Text = "toolStrip1";
            // 
            // toolStrip_dropdown_system
            // 
            this.toolStrip_dropdown_system.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERSToolStripMenuItem,
            this.toolStripSeparator4,
            this.sIGNINToolStripMenuItem,
            this.toolStripSeparator7,
            this.eXITToolStripMenuItem});
            this.toolStrip_dropdown_system.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_System_Task_48;
            this.toolStrip_dropdown_system.Name = "toolStrip_dropdown_system";
            this.toolStrip_dropdown_system.Size = new System.Drawing.Size(115, 29);
            this.toolStrip_dropdown_system.Text = "SYSTEM";
            // 
            // uSERSToolStripMenuItem
            // 
            this.uSERSToolStripMenuItem.Name = "uSERSToolStripMenuItem";
            this.uSERSToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.uSERSToolStripMenuItem.Text = "USERS";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // sIGNINToolStripMenuItem
            // 
            this.sIGNINToolStripMenuItem.Name = "sIGNINToolStripMenuItem";
            this.sIGNINToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.sIGNINToolStripMenuItem.Text = "SIGN IN";
            this.sIGNINToolStripMenuItem.Click += new System.EventHandler(this.sIGNINToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(157, 6);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStrip_bus_bus
            // 
            this.toolStrip_bus_bus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANAGECLASSToolStripMenuItem,
            this.toolStripSeparator5,
            this.mANAGEBUSToolStripMenuItem});
            this.toolStrip_bus_bus.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Bus_48;
            this.toolStrip_bus_bus.Name = "toolStrip_bus_bus";
            this.toolStrip_bus_bus.Size = new System.Drawing.Size(80, 29);
            this.toolStrip_bus_bus.Text = "BUS";
            // 
            // mANAGECLASSToolStripMenuItem
            // 
            this.mANAGECLASSToolStripMenuItem.Name = "mANAGECLASSToolStripMenuItem";
            this.mANAGECLASSToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.mANAGECLASSToolStripMenuItem.Text = "MANAGE CLASS";
            this.mANAGECLASSToolStripMenuItem.Click += new System.EventHandler(this.mANAGECLASSToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(228, 6);
            // 
            // mANAGEBUSToolStripMenuItem
            // 
            this.mANAGEBUSToolStripMenuItem.Name = "mANAGEBUSToolStripMenuItem";
            this.mANAGEBUSToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.mANAGEBUSToolStripMenuItem.Text = "MANAGE BUS";
            this.mANAGEBUSToolStripMenuItem.Click += new System.EventHandler(this.mANAGEBUSToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStrip_dropdown_schedule
            // 
            this.toolStrip_dropdown_schedule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANAGESCHEDULESToolStripMenuItem});
            this.toolStrip_dropdown_schedule.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Ticket_Purchase_48;
            this.toolStrip_dropdown_schedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_dropdown_schedule.Name = "toolStrip_dropdown_schedule";
            this.toolStrip_dropdown_schedule.Size = new System.Drawing.Size(138, 29);
            this.toolStrip_dropdown_schedule.Text = "SCHEDULE";
            // 
            // mANAGESCHEDULESToolStripMenuItem
            // 
            this.mANAGESCHEDULESToolStripMenuItem.Name = "mANAGESCHEDULESToolStripMenuItem";
            this.mANAGESCHEDULESToolStripMenuItem.Size = new System.Drawing.Size(279, 30);
            this.mANAGESCHEDULESToolStripMenuItem.Text = "MANAGE SCHEDULES";
            this.mANAGESCHEDULESToolStripMenuItem.Click += new System.EventHandler(this.mANAGESCHEDULESToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStrip_dropdown_reservation
            // 
            this.toolStrip_dropdown_reservation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANAGERESERVATIONSToolStripMenuItem,
            this.toolStripSeparator6,
            this.mANAGEPAYMENTToolStripMenuItem,
            this.vIEWTRANSACTIONSToolStripMenuItem});
            this.toolStrip_dropdown_reservation.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Schedule_48;
            this.toolStrip_dropdown_reservation.Name = "toolStrip_dropdown_reservation";
            this.toolStrip_dropdown_reservation.Size = new System.Drawing.Size(178, 29);
            this.toolStrip_dropdown_reservation.Text = "RESERVATIONS";
            // 
            // mANAGERESERVATIONSToolStripMenuItem
            // 
            this.mANAGERESERVATIONSToolStripMenuItem.Name = "mANAGERESERVATIONSToolStripMenuItem";
            this.mANAGERESERVATIONSToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.mANAGERESERVATIONSToolStripMenuItem.Text = "MANAGE RESERVATIONS";
            this.mANAGERESERVATIONSToolStripMenuItem.Click += new System.EventHandler(this.mANAGERESERVATIONSToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(306, 6);
            // 
            // mANAGEPAYMENTToolStripMenuItem
            // 
            this.mANAGEPAYMENTToolStripMenuItem.Name = "mANAGEPAYMENTToolStripMenuItem";
            this.mANAGEPAYMENTToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.mANAGEPAYMENTToolStripMenuItem.Text = "MANAGE PAYMENT";
            // 
            // vIEWTRANSACTIONSToolStripMenuItem
            // 
            this.vIEWTRANSACTIONSToolStripMenuItem.Name = "vIEWTRANSACTIONSToolStripMenuItem";
            this.vIEWTRANSACTIONSToolStripMenuItem.Size = new System.Drawing.Size(309, 30);
            this.vIEWTRANSACTIONSToolStripMenuItem.Text = "VIEW TRANSACTIONS";
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 717);
            this.Controls.Add(this.toolStrip_main);
            this.Name = "FRM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLORIDA BUS RESERVATION SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FRM_MAIN_Activated);
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton toolStrip_dropdown_system;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStrip_bus_bus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStrip_dropdown_schedule;
        private System.Windows.Forms.ToolStripMenuItem sIGNINToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGECLASSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mANAGEBUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGESCHEDULESToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStrip_dropdown_reservation;
        private System.Windows.Forms.ToolStripMenuItem mANAGERESERVATIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mANAGEPAYMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWTRANSACTIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        public System.Windows.Forms.ToolStrip toolStrip_main;
    }
}

