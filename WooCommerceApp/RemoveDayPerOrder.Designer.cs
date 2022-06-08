
namespace WooCommerceApp
{
    partial class RemoveDayPerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveDayPerOrder));
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.lblWarningText01 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWarningText02 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConfirm
            // 
            this.lblConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfirm.Location = new System.Drawing.Point(12, 114);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(115, 35);
            this.lblConfirm.TabIndex = 0;
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCancel.Image = global::WooCommerceApp.Properties.Resources.buttonOnLeave_ConfirmRemove;
            this.lblCancel.Location = new System.Drawing.Point(152, 114);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(122, 35);
            this.lblCancel.TabIndex = 1;
            this.lblCancel.Text = "Anuluj";
            this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            this.lblCancel.MouseLeave += new System.EventHandler(this.lblCancel_MouseLeave);
            this.lblCancel.MouseHover += new System.EventHandler(this.lblCancel_MouseHover);
            // 
            // lblWarningText01
            // 
            this.lblWarningText01.AutoSize = true;
            this.lblWarningText01.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWarningText01.ForeColor = System.Drawing.Color.Black;
            this.lblWarningText01.Location = new System.Drawing.Point(12, 38);
            this.lblWarningText01.Name = "lblWarningText01";
            this.lblWarningText01.Size = new System.Drawing.Size(87, 20);
            this.lblWarningText01.TabIndex = 2;
            this.lblWarningText01.Text = "ClientName";
            this.lblWarningText01.Click += new System.EventHandler(this.lblWarningText01_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Czy usunąć catering?";
            // 
            // lblWarningText02
            // 
            this.lblWarningText02.AutoSize = true;
            this.lblWarningText02.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWarningText02.ForeColor = System.Drawing.Color.Black;
            this.lblWarningText02.Location = new System.Drawing.Point(12, 68);
            this.lblWarningText02.Name = "lblWarningText02";
            this.lblWarningText02.Size = new System.Drawing.Size(97, 20);
            this.lblWarningText02.TabIndex = 4;
            this.lblWarningText02.Text = "CateringDate";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "OK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.lblConfirm_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // RemoveDayPerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(285, 158);
            this.Controls.Add(this.lblWarningText02);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWarningText01);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveDayPerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ostrzeżenie";
            this.Load += new System.EventHandler(this.RemoveDayPerOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label lblWarningText01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWarningText02;
        private System.Windows.Forms.Label label2;
    }
}