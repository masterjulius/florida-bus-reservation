namespace Florida_Bus_Reservation.BUS
{
    partial class FRM_VIEW_ALL_BUS_CLASS
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
            this.toolStrip_menu = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_fetch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTxt_search = new System.Windows.Forms.ToolStripTextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.dgv_datas = new System.Windows.Forms.DataGridView();
            this.toolStrip_menu.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_menu
            // 
            this.toolStrip_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_fetch,
            this.toolStripSeparator1,
            this.toolStripTxt_search});
            this.toolStrip_menu.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_menu.Name = "toolStrip_menu";
            this.toolStrip_menu.Size = new System.Drawing.Size(1180, 32);
            this.toolStrip_menu.TabIndex = 0;
            this.toolStrip_menu.Text = "toolStrip1";
            // 
            // toolStripBtn_fetch
            // 
            this.toolStripBtn_fetch.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Checked_40;
            this.toolStripBtn_fetch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_fetch.Name = "toolStripBtn_fetch";
            this.toolStripBtn_fetch.Size = new System.Drawing.Size(91, 29);
            this.toolStripBtn_fetch.Text = "FETCH";
            this.toolStripBtn_fetch.Click += new System.EventHandler(this.toolStripBtn_fetch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripTxt_search
            // 
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
            this.panel_main.Controls.Add(this.dgv_datas);
            this.panel_main.Location = new System.Drawing.Point(12, 49);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_main.Size = new System.Drawing.Size(1156, 520);
            this.panel_main.TabIndex = 1;
            // 
            // dgv_datas
            // 
            this.dgv_datas.AllowUserToAddRows = false;
            this.dgv_datas.AllowUserToDeleteRows = false;
            this.dgv_datas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_datas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_datas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_datas.Location = new System.Drawing.Point(10, 10);
            this.dgv_datas.Name = "dgv_datas";
            this.dgv_datas.ReadOnly = true;
            this.dgv_datas.RowHeadersVisible = false;
            this.dgv_datas.RowTemplate.Height = 24;
            this.dgv_datas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datas.Size = new System.Drawing.Size(1136, 500);
            this.dgv_datas.TabIndex = 0;
            // 
            // FRM_VIEW_ALL_BUS_CLASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 581);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.toolStrip_menu);
            this.Name = "FRM_VIEW_ALL_BUS_CLASS";
            this.Text = "VIEW ALL BUS CLASS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_VIEW_ALL_BUS_CLASS_Load);
            this.toolStrip_menu.ResumeLayout(false);
            this.toolStrip_menu.PerformLayout();
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_menu;
        private System.Windows.Forms.ToolStripButton toolStripBtn_fetch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTxt_search;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridView dgv_datas;
    }
}