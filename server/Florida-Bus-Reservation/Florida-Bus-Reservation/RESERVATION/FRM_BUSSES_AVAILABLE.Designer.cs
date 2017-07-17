namespace Florida_Bus_Reservation.RESERVATION
{
    partial class FRM_BUSSES_AVAILABLE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new System.Windows.Forms.Panel();
            this.dgv_BUSES = new System.Windows.Forms.DataGridView();
            this.toolStrip_action_menus = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_accept = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTxt_search = new System.Windows.Forms.ToolStripTextBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BUSES)).BeginInit();
            this.toolStrip_action_menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.Controls.Add(this.dgv_BUSES);
            this.panel_main.Location = new System.Drawing.Point(3, 34);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_main.Size = new System.Drawing.Size(1176, 571);
            this.panel_main.TabIndex = 7;
            // 
            // dgv_BUSES
            // 
            this.dgv_BUSES.AllowUserToAddRows = false;
            this.dgv_BUSES.AllowUserToDeleteRows = false;
            this.dgv_BUSES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BUSES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BUSES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BUSES.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_BUSES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BUSES.Location = new System.Drawing.Point(10, 10);
            this.dgv_BUSES.Name = "dgv_BUSES";
            this.dgv_BUSES.ReadOnly = true;
            this.dgv_BUSES.RowHeadersVisible = false;
            this.dgv_BUSES.RowTemplate.Height = 24;
            this.dgv_BUSES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BUSES.Size = new System.Drawing.Size(1156, 551);
            this.dgv_BUSES.TabIndex = 0;
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
            this.toolStrip_action_menus.Size = new System.Drawing.Size(1181, 32);
            this.toolStrip_action_menus.TabIndex = 6;
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
            // 
            // FRM_BUSSES_AVAILABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 608);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.toolStrip_action_menus);
            this.Name = "FRM_BUSSES_AVAILABLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSES AVAILABLE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_BUSSES_AVAILABLE_Load);
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BUSES)).EndInit();
            this.toolStrip_action_menus.ResumeLayout(false);
            this.toolStrip_action_menus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridView dgv_BUSES;
        private System.Windows.Forms.ToolStrip toolStrip_action_menus;
        private System.Windows.Forms.ToolStripButton toolStripBtn_accept;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTxt_search;
    }
}