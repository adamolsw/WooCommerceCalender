
namespace WooCommerceApp
{
    partial class DayDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbArrowPrevious = new System.Windows.Forms.Label();
            this.lbArrowNext = new System.Windows.Forms.Label();
            this.lbDayMonthYear = new System.Windows.Forms.Label();
            this.dgvDailyDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbArrowPrevious);
            this.panel1.Controls.Add(this.lbArrowNext);
            this.panel1.Controls.Add(this.lbDayMonthYear);
            this.panel1.Controls.Add(this.dgvDailyDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1893, 934);
            this.panel1.TabIndex = 0;
            // 
            // lbArrowPrevious
            // 
            this.lbArrowPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArrowPrevious.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbArrowPrevious.ForeColor = System.Drawing.Color.White;
            this.lbArrowPrevious.Image = global::WooCommerceApp.Properties.Resources.kindpng_105650_3_;
            this.lbArrowPrevious.Location = new System.Drawing.Point(1769, 0);
            this.lbArrowPrevious.Name = "lbArrowPrevious";
            this.lbArrowPrevious.Size = new System.Drawing.Size(62, 48);
            this.lbArrowPrevious.TabIndex = 14;
            this.lbArrowPrevious.Click += new System.EventHandler(this.lbArrowPrevious_Click);
            // 
            // lbArrowNext
            // 
            this.lbArrowNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArrowNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbArrowNext.ForeColor = System.Drawing.Color.White;
            this.lbArrowNext.Image = global::WooCommerceApp.Properties.Resources.kindpng_105650_2_;
            this.lbArrowNext.Location = new System.Drawing.Point(1831, 0);
            this.lbArrowNext.Name = "lbArrowNext";
            this.lbArrowNext.Size = new System.Drawing.Size(62, 48);
            this.lbArrowNext.TabIndex = 13;
            this.lbArrowNext.Click += new System.EventHandler(this.lbArrowNext_Click);
            // 
            // lbDayMonthYear
            // 
            this.lbDayMonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDayMonthYear.BackColor = System.Drawing.Color.Black;
            this.lbDayMonthYear.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDayMonthYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(53)))), ((int)(((byte)(111)))));
            this.lbDayMonthYear.Location = new System.Drawing.Point(0, 0);
            this.lbDayMonthYear.Name = "lbDayMonthYear";
            this.lbDayMonthYear.Size = new System.Drawing.Size(525, 48);
            this.lbDayMonthYear.TabIndex = 11;
            this.lbDayMonthYear.Text = "MONTH YEAR";
            this.lbDayMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDailyDetails
            // 
            this.dgvDailyDetails.AllowUserToAddRows = false;
            this.dgvDailyDetails.AllowUserToDeleteRows = false;
            this.dgvDailyDetails.AllowUserToResizeRows = false;
            this.dgvDailyDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDailyDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailyDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvDailyDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDailyDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDailyDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailyDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailyDetails.ColumnHeadersHeight = 30;
            this.dgvDailyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDailyDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDailyDetails.EnableHeadersVisualStyles = false;
            this.dgvDailyDetails.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDailyDetails.Location = new System.Drawing.Point(0, 48);
            this.dgvDailyDetails.Name = "dgvDailyDetails";
            this.dgvDailyDetails.ReadOnly = true;
            this.dgvDailyDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailyDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDailyDetails.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDailyDetails.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDailyDetails.RowTemplate.Height = 25;
            this.dgvDailyDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDailyDetails.Size = new System.Drawing.Size(1893, 886);
            this.dgvDailyDetails.TabIndex = 0;
            // 
            // DayDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1893, 934);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DayDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayDetails";
            this.Load += new System.EventHandler(this.DayDetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDailyDetails;
        private System.Windows.Forms.Label lbDayMonthYear;
        private System.Windows.Forms.Label lbArrowPrevious;
        private System.Windows.Forms.Label lbArrowNext;
    }
}