
namespace WooCommerceApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lbMonthYear = new System.Windows.Forms.Label();
            this.lbArrowNext = new System.Windows.Forms.Label();
            this.lbArrowPrevious = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayContainer
            // 
            this.dayContainer.BackColor = System.Drawing.Color.Black;
            this.dayContainer.Location = new System.Drawing.Point(9, 112);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(1316, 642);
            this.dayContainer.TabIndex = 0;
            this.dayContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lbMonthYear
            // 
            this.lbMonthYear.BackColor = System.Drawing.Color.Black;
            this.lbMonthYear.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMonthYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(53)))), ((int)(((byte)(111)))));
            this.lbMonthYear.Location = new System.Drawing.Point(9, -2);
            this.lbMonthYear.Name = "lbMonthYear";
            this.lbMonthYear.Size = new System.Drawing.Size(276, 44);
            this.lbMonthYear.TabIndex = 10;
            this.lbMonthYear.Text = "MONTH YEAR";
            this.lbMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMonthYear.Click += new System.EventHandler(this.lbMonthYear_Click);
            // 
            // lbArrowNext
            // 
            this.lbArrowNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbArrowNext.ForeColor = System.Drawing.Color.White;
            this.lbArrowNext.Image = global::WooCommerceApp.Properties.Resources.kindpng_105650_2_;
            this.lbArrowNext.Location = new System.Drawing.Point(1262, 9);
            this.lbArrowNext.Name = "lbArrowNext";
            this.lbArrowNext.Size = new System.Drawing.Size(62, 33);
            this.lbArrowNext.TabIndex = 11;
            this.lbArrowNext.Click += new System.EventHandler(this.label8_Click);
            this.lbArrowNext.MouseLeave += new System.EventHandler(this.SetArrowNextOnLeave);
            this.lbArrowNext.MouseHover += new System.EventHandler(this.SetArrowNextOnHover);
            // 
            // lbArrowPrevious
            // 
            this.lbArrowPrevious.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbArrowPrevious.ForeColor = System.Drawing.Color.White;
            this.lbArrowPrevious.Image = global::WooCommerceApp.Properties.Resources.kindpng_105650_3_;
            this.lbArrowPrevious.Location = new System.Drawing.Point(1194, 9);
            this.lbArrowPrevious.Name = "lbArrowPrevious";
            this.lbArrowPrevious.Size = new System.Drawing.Size(62, 33);
            this.lbArrowPrevious.TabIndex = 12;
            this.lbArrowPrevious.Click += new System.EventHandler(this.label9_Click);
            this.lbArrowPrevious.MouseLeave += new System.EventHandler(this.SetArrowPreviousOnLeave);
            this.lbArrowPrevious.MouseHover += new System.EventHandler(this.SetArrowPreviousOnHover);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1316, 61);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 61);
            this.label8.TabIndex = 0;
            this.label8.Text = "Poniedziałek";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(191, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 61);
            this.label9.TabIndex = 1;
            this.label9.Text = "Wtorek";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(379, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 61);
            this.label10.TabIndex = 2;
            this.label10.Text = "Środa";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(567, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 61);
            this.label11.TabIndex = 3;
            this.label11.Text = "Czwartek";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(755, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 61);
            this.label12.TabIndex = 4;
            this.label12.Text = "Piątek";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(943, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 61);
            this.label13.TabIndex = 5;
            this.label13.Text = "Sobota";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(1131, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 61);
            this.label14.TabIndex = 6;
            this.label14.Text = "Niedziela";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1336, 763);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbArrowPrevious);
            this.Controls.Add(this.lbArrowNext);
            this.Controls.Add(this.lbMonthYear);
            this.Controls.Add(this.dayContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalendarz zamówień";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dayContainer;
        private System.Windows.Forms.Label lbMonthYear;
        private System.Windows.Forms.Label lbArrowNext;
        private System.Windows.Forms.Label lbArrowPrevious;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

