namespace Florida_Bus_Reservation.RESERVATION
{
    partial class FRM_CURRENT_SCHEDULES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip_action_menus = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_accept = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTxt_search = new System.Windows.Forms.ToolStripTextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.dgv_schedules = new System.Windows.Forms.DataGridView();
            this.toolStrip_action_menus.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_action_menus
            // 
            this.toolStrip_action_menus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip_action_menus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStrip_action_menus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_action_menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_accept,
            this.toolStripSeparator1,
            this.toolStripTxt_search});
            this.toolStrip_action_menus.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_action_menus.Name = "toolStrip_action_menus";
            this.toolStrip_action_menus.Size = new System.Drawing.Size(993, 32);
            this.toolStrip_action_menus.TabIndex = 3;
            this.toolStrip_action_menus.Text = "toolStrip1";
            // 
            // toolStripBtn_accept
            // 
            this.toolStripBtn_accept.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Checked_40;
            this.toolStripBtn_accept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_accept.Name = "toolStripBtn_accept";
            this.toolStripBtn_accept.Size = new System.Drawing.Size(102, 29);
            this.toolStripBtn_accept.Text = "ACCEPT";
            this.toolStripBtn_accept.Click += new System.EventHandler(this.toolStripBtn_accept_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripTxt_search
            // 
            this.toolStripTxt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTxt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTxt_search.Name = "toolStripTxt_search";
            this.toolStripTxt_search.Size = new System.Drawing.Size(300, 32);
            this.toolStripTxt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTxt_search_KeyPress);
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.Controls.Add(this.dgv_schedules);
            this.panel_main.Location = new System.Drawing.Point(3, 37);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_main.Size = new System.Drawing.Size(990, 578);
            this.panel_main.TabIndex = 5;
            // 
            // dgv_schedules
            // 
            this.dgv_schedules.AllowUserToAddRows = false;
            this.dgv_schedules.AllowUserToDeleteRows = false;
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
            this.dgv_schedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_schedules.Location = new System.Drawing.Point(10, 10);
            this.dgv_schedules.Name = "dgv_schedules";
            this.dgv_schedules.ReadOnly = true;
            this.dgv_schedules.RowHeadersVisible = false;
            this.dgv_schedules.RowTemplate.Height = 24;
            this.dgv_schedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_schedules.Size = new System.Drawing.Size(970, 558);
            this.dgv_schedules.TabIndex = 0;
            // 
            // FRM_CURRENT_SCHEDULES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 627);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.toolStrip_action_menus);
            this.Name = "FRM_CURRENT_SCHEDULES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SCHEDULE FINDER";
            this.Load += new System.EventHandler(this.FRM_CURRENT_SCHEDULES_Load);
            this.toolStrip_action_menus.ResumeLayout(false);
            this.toolStrip_action_menus.PerformLayout();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_action_menus;
        private System.Windows.Forms.ToolStripButton toolStripBtn_accept;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTxt_search;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridView dgv_schedules;
    }
}