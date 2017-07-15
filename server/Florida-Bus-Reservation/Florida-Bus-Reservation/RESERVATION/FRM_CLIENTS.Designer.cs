namespace Florida_Bus_Reservation.RESERVATION
{
    partial class FRM_CLIENTS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new System.Windows.Forms.Panel();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.toolStrip_action_menus = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTxt_search = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtn_new = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_accept = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_view_all = new System.Windows.Forms.ToolStripButton();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            this.toolStrip_action_menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.Controls.Add(this.dgv_clients);
            this.panel_main.Location = new System.Drawing.Point(12, 34);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(10);
            this.panel_main.Size = new System.Drawing.Size(1290, 587);
            this.panel_main.TabIndex = 4;
            // 
            // dgv_clients
            // 
            this.dgv_clients.AllowUserToAddRows = false;
            this.dgv_clients.AllowUserToDeleteRows = false;
            this.dgv_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clients.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clients.Location = new System.Drawing.Point(10, 10);
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.ReadOnly = true;
            this.dgv_clients.RowHeadersVisible = false;
            this.dgv_clients.RowTemplate.Height = 24;
            this.dgv_clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clients.Size = new System.Drawing.Size(1270, 567);
            this.dgv_clients.TabIndex = 0;
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
            this.toolStripBtn_accept,
            this.toolStripSeparator4,
            this.toolStripTxt_search,
            this.toolStripBtn_view_all});
            this.toolStrip_action_menus.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_action_menus.Name = "toolStrip_action_menus";
            this.toolStrip_action_menus.Size = new System.Drawing.Size(1314, 32);
            this.toolStrip_action_menus.TabIndex = 5;
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
            // toolStripTxt_search
            // 
            this.toolStripTxt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTxt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTxt_search.Name = "toolStripTxt_search";
            this.toolStripTxt_search.Size = new System.Drawing.Size(300, 32);
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
            // toolStripBtn_accept
            // 
            this.toolStripBtn_accept.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Checked_40;
            this.toolStripBtn_accept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_accept.Name = "toolStripBtn_accept";
            this.toolStripBtn_accept.Size = new System.Drawing.Size(102, 29);
            this.toolStripBtn_accept.Text = "ACCEPT";
            this.toolStripBtn_accept.Click += new System.EventHandler(this.toolStripBtn_accept_Click);
            // 
            // toolStripBtn_view_all
            // 
            this.toolStripBtn_view_all.Image = global::Florida_Bus_Reservation.Properties.Resources.icons8_Search_40;
            this.toolStripBtn_view_all.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_view_all.Name = "toolStripBtn_view_all";
            this.toolStripBtn_view_all.Size = new System.Drawing.Size(116, 29);
            this.toolStripBtn_view_all.Text = "VIEW ALL";
            // 
            // FRM_CLIENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 633);
            this.Controls.Add(this.toolStrip_action_menus);
            this.Controls.Add(this.panel_main);
            this.Name = "FRM_CLIENTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FRM_CLIENTS_Activated);
            this.Load += new System.EventHandler(this.FRM_CLIENTS_Load);
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            this.toolStrip_action_menus.ResumeLayout(false);
            this.toolStrip_action_menus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.ToolStrip toolStrip_action_menus;
        private System.Windows.Forms.ToolStripButton toolStripBtn_new;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtn_edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtn_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBtn_accept;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTxt_search;
        private System.Windows.Forms.ToolStripButton toolStripBtn_view_all;
    }
}