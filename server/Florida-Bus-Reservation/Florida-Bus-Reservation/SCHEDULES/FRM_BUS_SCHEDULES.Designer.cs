namespace Florida_Bus_Reservation.SCHEDULES
{
    partial class FRM_BUS_SCHEDULES
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip_action_menus = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTxt_search = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_schedules = new System.Windows.Forms.DataGridView();
            this.dtp_sched = new System.Windows.Forms.DateTimePicker();
            this.toolStripBtn_new = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_view_all = new System.Windows.Forms.ToolStripButton();
            this.panel_available = new System.Windows.Forms.Panel();
            this.panel_departed = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip_action_menus.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).BeginInit();
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
            this.toolStripTxt_search,
            this.toolStripBtn_view_all});
            this.toolStrip_action_menus.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_action_menus.Name = "toolStrip_action_menus";
            this.toolStrip_action_menus.Size = new System.Drawing.Size(1522, 32);
            this.toolStrip_action_menus.TabIndex = 2;
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
            // toolStripTxt_search
            // 
            this.toolStripTxt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTxt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTxt_search.Name = "toolStripTxt_search";
            this.toolStripTxt_search.Size = new System.Drawing.Size(300, 32);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_departed);
            this.panel1.Controls.Add(this.panel_available);
            this.panel1.Controls.Add(this.dtp_sched);
            this.panel1.Controls.Add(this.dgv_schedules);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(1498, 706);
            this.panel1.TabIndex = 3;
            // 
            // t1
            // 
            this.t1.Interval = 10000;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // dgv_schedules
            // 
            this.dgv_schedules.AllowUserToAddRows = false;
            this.dgv_schedules.AllowUserToDeleteRows = false;
            this.dgv_schedules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_schedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_schedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_schedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_schedules.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_schedules.Location = new System.Drawing.Point(18, 61);
            this.dgv_schedules.Name = "dgv_schedules";
            this.dgv_schedules.ReadOnly = true;
            this.dgv_schedules.RowHeadersVisible = false;
            this.dgv_schedules.RowTemplate.Height = 24;
            this.dgv_schedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_schedules.Size = new System.Drawing.Size(1467, 627);
            this.dgv_schedules.TabIndex = 1;
            // 
            // dtp_sched
            // 
            this.dtp_sched.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_sched.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_sched.Location = new System.Drawing.Point(18, 12);
            this.dtp_sched.Name = "dtp_sched";
            this.dtp_sched.Size = new System.Drawing.Size(364, 31);
            this.dtp_sched.TabIndex = 2;
            this.dtp_sched.ValueChanged += new System.EventHandler(this.dtp_sched_ValueChanged);
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
            // toolStripBtn_view_all
            // 
            this.toolStripBtn_view_all.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Search_40;
            this.toolStripBtn_view_all.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_view_all.Name = "toolStripBtn_view_all";
            this.toolStripBtn_view_all.Size = new System.Drawing.Size(116, 29);
            this.toolStripBtn_view_all.Text = "VIEW ALL";
            // 
            // panel_available
            // 
            this.panel_available.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_available.Location = new System.Drawing.Point(783, 12);
            this.panel_available.Name = "panel_available";
            this.panel_available.Size = new System.Drawing.Size(281, 31);
            this.panel_available.TabIndex = 3;
            // 
            // panel_departed
            // 
            this.panel_departed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_departed.Location = new System.Drawing.Point(1199, 12);
            this.panel_departed.Name = "panel_departed";
            this.panel_departed.Size = new System.Drawing.Size(281, 31);
            this.panel_departed.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(667, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "AVAILABLE";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1089, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "DEPARTED";
            // 
            // FRM_BUS_SCHEDULES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 762);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip_action_menus);
            this.Name = "FRM_BUS_SCHEDULES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCHEDULES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_BUS_SCHEDULES_Load);
            this.toolStrip_action_menus.ResumeLayout(false);
            this.toolStrip_action_menus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).EndInit();
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
        private System.Windows.Forms.ToolStripTextBox toolStripTxt_search;
        private System.Windows.Forms.ToolStripButton toolStripBtn_view_all;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.DataGridView dgv_schedules;
        private System.Windows.Forms.DateTimePicker dtp_sched;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_departed;
        private System.Windows.Forms.Panel panel_available;
    }
}