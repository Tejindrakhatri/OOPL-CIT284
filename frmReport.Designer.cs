namespace disturbo_tax
{
    partial class frmReport
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
            this.tbReports = new System.Windows.Forms.DataGridView();
            this.btbOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbReports)).BeginInit();
            this.SuspendLayout();
            // 
            // tbReports
            // 
            this.tbReports.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbReports.Location = new System.Drawing.Point(83, 92);
            this.tbReports.Name = "tbReports";
            this.tbReports.Size = new System.Drawing.Size(433, 211);
            this.tbReports.TabIndex = 0;
            // 
            // btbOk
            // 
            this.btbOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbOk.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btbOk.Location = new System.Drawing.Point(249, 340);
            this.btbOk.Name = "btbOk";
            this.btbOk.Size = new System.Drawing.Size(101, 33);
            this.btbOk.TabIndex = 1;
            this.btbOk.Text = "ok";
            this.btbOk.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tax Payers Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbOk);
            this.Controls.Add(this.tbReports);
            this.Name = "frmReport";
            this.Text = "Disturbo Tax";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tbReports;
        private System.Windows.Forms.Button btbOk;
        private System.Windows.Forms.Label label1;
    }
}