
namespace WooCommerceApp
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDays = new System.Windows.Forms.Label();
            this.lbNumOfOrders = new System.Windows.Forms.Label();
            this.lbDescriptionNumOfOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lbDays.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDays.ForeColor = System.Drawing.Color.Black;
            this.lbDays.Location = new System.Drawing.Point(4, 4);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(25, 19);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "00";
            this.lbDays.Click += new System.EventHandler(this.UserControlDays_Load);
            // 
            // lbNumOfOrders
            // 
            this.lbNumOfOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lbNumOfOrders.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNumOfOrders.ForeColor = System.Drawing.Color.Black;
            this.lbNumOfOrders.Location = new System.Drawing.Point(80, 45);
            this.lbNumOfOrders.Name = "lbNumOfOrders";
            this.lbNumOfOrders.Size = new System.Drawing.Size(79, 45);
            this.lbNumOfOrders.TabIndex = 1;
            this.lbNumOfOrders.Text = "0";
            this.lbNumOfOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbNumOfOrders.Click += new System.EventHandler(this.UserControlDays_Load);
            // 
            // lbDescriptionNumOfOrders
            // 
            this.lbDescriptionNumOfOrders.AutoSize = true;
            this.lbDescriptionNumOfOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lbDescriptionNumOfOrders.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescriptionNumOfOrders.ForeColor = System.Drawing.Color.Black;
            this.lbDescriptionNumOfOrders.Location = new System.Drawing.Point(3, 45);
            this.lbDescriptionNumOfOrders.Name = "lbDescriptionNumOfOrders";
            this.lbDescriptionNumOfOrders.Size = new System.Drawing.Size(78, 38);
            this.lbDescriptionNumOfOrders.TabIndex = 2;
            this.lbDescriptionNumOfOrders.Text = "Ilość \r\nzamówień:";
            this.lbDescriptionNumOfOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDescriptionNumOfOrders.Click += new System.EventHandler(this.UserControlDays_Load);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.lbDescriptionNumOfOrders);
            this.Controls.Add(this.lbNumOfOrders);
            this.Controls.Add(this.lbDays);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(159, 91);
            this.Load += new System.EventHandler(this.UserControlDays_Load_1);
            this.Click += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label lbNumOfOrders;
        private System.Windows.Forms.Label lbDescriptionNumOfOrders;
    }
}
