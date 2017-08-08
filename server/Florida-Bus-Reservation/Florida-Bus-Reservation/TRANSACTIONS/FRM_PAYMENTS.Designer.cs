namespace Florida_Bus_Reservation.TRANSACTIONS
{
    partial class FRM_PAYMENTS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip_action_menus = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_accept = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTxt_search = new System.Windows.Forms.ToolStripTextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.dgv_bills = new System.Windows.Forms.DataGridView();
            this.toolStrip_action_menus.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
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
            this.toolStrip_action_menus.Size = new System.Drawing.Size(1099, 32);
            this.toolStrip_action_menus.TabIndex = 7;
            this.toolStrip_action_menus.Text = "toolStrip1";
            // 
            // toolStripBtn_accept
            // 
            this.toolStripBtn_accept.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Coins_40;
            this.toolStripBtn_accept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_accept.Name = "toolStripBtn_accept";
            this.toolStripBtn_accept.Size = new System.Drawing.Size(68, 29);
            this.toolStripBtn_accept.Text = "PAY";
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
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.Controls.Add(this.dgv_bills);
            this.panel_main.Location = new System.Drawing.Point(0, 35);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_main.Size = new System.Drawing.Size(1099, 583);
            this.panel_main.TabIndex = 8;
            // 
            // dgv_bills
            // 
            this.dgv_bills.AllowUserToAddRows = false;
            this.dgv_bills.AllowUserToDeleteRows = false;
            this.dgv_bills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bills.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bills.Location = new System.Drawing.Point(10, 10);
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.ReadOnly = true;
            this.dgv_bills.RowHeadersVisible = false;
            this.dgv_bills.RowTemplate.Height = 24;
            this.dgv_bills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bills.Size = new System.Drawing.Size(1079, 563);
            this.dgv_bills.TabIndex = 0;
            // 
            // FRM_PAYMENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 630);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.toolStrip_action_menus);
            this.Name = "FRM_PAYMENTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGE PAYMENTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FRM_PAYMENTS_Activated);
            this.Load += new System.EventHandler(this.FRM_PAYMENTS_Load);
            this.toolStrip_action_menus.ResumeLayout(false);
            this.toolStrip_action_menus.PerformLayout();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_action_menus;
        private System.Windows.Forms.ToolStripButton toolStripBtn_accept;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTxt_search;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridView dgv_bills;
    }
}