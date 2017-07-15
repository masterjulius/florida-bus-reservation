namespace Florida_Bus_Reservation.BUS
{
    partial class FRM_MANAGE_BUS
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
            this.toolStrip_action_menus = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTxt_search = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_buss_class = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_plate_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bus_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripBtn_new = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_cancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_view_all = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_action_menus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_action_menus
            // 
            this.toolStrip_action_menus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip_action_menus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStrip_action_menus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_action_menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_new,
            this.toolStripSeparator1,
            this.toolStripBtn_edit,
            this.toolStripSeparator2,
            this.toolStripBtn_delete,
            this.toolStripSeparator3,
            this.toolStripBtn_save,
            this.toolStripSeparator4,
            this.toolStripBtn_cancel,
            this.toolStripSeparator6,
            this.toolStripTxt_search,
            this.toolStripBtn_view_all});
            this.toolStrip_action_menus.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_action_menus.Name = "toolStrip_action_menus";
            this.toolStrip_action_menus.Size = new System.Drawing.Size(1180, 32);
            this.toolStrip_action_menus.TabIndex = 1;
            this.toolStrip_action_menus.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripTxt_search
            // 
            this.toolStripTxt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTxt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTxt_search.Name = "toolStripTxt_search";
            this.toolStripTxt_search.Size = new System.Drawing.Size(300, 32);
            this.toolStripTxt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTxt_search_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cb_buss_class);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_plate_number);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_bus_number);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 525);
            this.panel1.TabIndex = 2;
            // 
            // cb_buss_class
            // 
            this.cb_buss_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_buss_class.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cb_buss_class.FormattingEnabled = true;
            this.cb_buss_class.Location = new System.Drawing.Point(262, 46);
            this.cb_buss_class.Name = "cb_buss_class";
            this.cb_buss_class.Size = new System.Drawing.Size(342, 36);
            this.cb_buss_class.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "PLATE NUMBER:";
            // 
            // txt_plate_number
            // 
            this.txt_plate_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_plate_number.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plate_number.Location = new System.Drawing.Point(262, 192);
            this.txt_plate_number.Name = "txt_plate_number";
            this.txt_plate_number.Size = new System.Drawing.Size(342, 34);
            this.txt_plate_number.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "BUS NUMBER:";
            // 
            // txt_bus_number
            // 
            this.txt_bus_number.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bus_number.Location = new System.Drawing.Point(262, 116);
            this.txt_bus_number.Name = "txt_bus_number";
            this.txt_bus_number.Size = new System.Drawing.Size(342, 34);
            this.txt_bus_number.TabIndex = 3;
            this.txt_bus_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bus_number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSS CLASS:";
            // 
            // toolStripBtn_new
            // 
            this.toolStripBtn_new.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Plus_Math_40;
            this.toolStripBtn_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_new.Name = "toolStripBtn_new";
            this.toolStripBtn_new.Size = new System.Drawing.Size(78, 29);
            this.toolStripBtn_new.Text = "NEW";
            this.toolStripBtn_new.Click += new System.EventHandler(this.toolStripBtn_new_Click);
            // 
            // toolStripBtn_edit
            // 
            this.toolStripBtn_edit.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Edit_40;
            this.toolStripBtn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_edit.Name = "toolStripBtn_edit";
            this.toolStripBtn_edit.Size = new System.Drawing.Size(74, 29);
            this.toolStripBtn_edit.Text = "EDIT";
            this.toolStripBtn_edit.Click += new System.EventHandler(this.toolStripBtn_edit_Click);
            // 
            // toolStripBtn_delete
            // 
            this.toolStripBtn_delete.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Trash_Can_40;
            this.toolStripBtn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_delete.Name = "toolStripBtn_delete";
            this.toolStripBtn_delete.Size = new System.Drawing.Size(98, 29);
            this.toolStripBtn_delete.Text = "DELETE";
            this.toolStripBtn_delete.Click += new System.EventHandler(this.toolStripBtn_delete_Click);
            // 
            // toolStripBtn_save
            // 
            this.toolStripBtn_save.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Save_40;
            this.toolStripBtn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_save.Name = "toolStripBtn_save";
            this.toolStripBtn_save.Size = new System.Drawing.Size(79, 29);
            this.toolStripBtn_save.Text = "SAVE";
            this.toolStripBtn_save.Click += new System.EventHandler(this.toolStripBtn_save_Click);
            // 
            // toolStripBtn_cancel
            // 
            this.toolStripBtn_cancel.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Cancel_2_40;
            this.toolStripBtn_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_cancel.Name = "toolStripBtn_cancel";
            this.toolStripBtn_cancel.Size = new System.Drawing.Size(105, 29);
            this.toolStripBtn_cancel.Text = "CANCEL";
            this.toolStripBtn_cancel.Click += new System.EventHandler(this.toolStripBtn_cancel_Click);
            // 
            // toolStripBtn_view_all
            // 
            this.toolStripBtn_view_all.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Search_40;
            this.toolStripBtn_view_all.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_view_all.Name = "toolStripBtn_view_all";
            this.toolStripBtn_view_all.Size = new System.Drawing.Size(116, 29);
            this.toolStripBtn_view_all.Text = "VIEW ALL";
            this.toolStripBtn_view_all.Click += new System.EventHandler(this.toolStripBtn_view_all_Click);
            // 
            // FRM_MANAGE_BUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip_action_menus);
            this.Name = "FRM_MANAGE_BUS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUS MANAGEMENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_MANAGE_BUS_Load);
            this.toolStrip_action_menus.ResumeLayout(false);
            this.toolStrip_action_menus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_action_menus;
        private System.Windows.Forms.ToolStripButton toolStripBtn_new;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtn_edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtn_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBtn_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBtn_cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox toolStripTxt_search;
        private System.Windows.Forms.ToolStripButton toolStripBtn_view_all;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_plate_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bus_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_buss_class;
    }
}