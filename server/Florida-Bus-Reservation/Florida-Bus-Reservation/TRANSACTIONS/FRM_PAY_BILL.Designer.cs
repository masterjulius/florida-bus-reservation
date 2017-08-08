namespace Florida_Bus_Reservation.TRANSACTIONS
{
    partial class FRM_PAY_BILL
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
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_client = new System.Windows.Forms.Label();
            this.lbl_res_code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMOUNT:";
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(156, 216);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(519, 34);
            this.txt_amount.TabIndex = 1;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyDown);
            this.txt_amount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_amount_KeyUp);
            // 
            // btn_accept
            // 
            this.btn_accept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_accept.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_accept.Location = new System.Drawing.Point(156, 264);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(519, 52);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "SAVE";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(26, 152);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(68, 25);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "TOTAL:";
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client.Location = new System.Drawing.Point(26, 95);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(76, 25);
            this.lbl_client.TabIndex = 4;
            this.lbl_client.Text = "CLIENT:";
            // 
            // lbl_res_code
            // 
            this.lbl_res_code.AutoSize = true;
            this.lbl_res_code.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_res_code.Location = new System.Drawing.Point(26, 42);
            this.lbl_res_code.Name = "lbl_res_code";
            this.lbl_res_code.Size = new System.Drawing.Size(186, 25);
            this.lbl_res_code.TabIndex = 5;
            this.lbl_res_code.Text = "RESERVATION CODE:";
            // 
            // FRM_PAY_BILL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 339);
            this.Controls.Add(this.lbl_res_code);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label1);
            this.Name = "FRM_PAY_BILL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAY BILL";
            this.Load += new System.EventHandler(this.FRM_PAY_BILL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Label lbl_res_code;
    }
}