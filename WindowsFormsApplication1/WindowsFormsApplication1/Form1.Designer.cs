namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnEmailReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExportReport
            // 
            this.btnExportReport.Location = new System.Drawing.Point(12, 12);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(117, 23);
            this.btnExportReport.TabIndex = 0;
            this.btnExportReport.Text = "Export Report";
            this.btnExportReport.UseVisualStyleBackColor = true;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(12, 41);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(117, 23);
            this.btnViewReport.TabIndex = 1;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // btnEmailReport
            // 
            this.btnEmailReport.Location = new System.Drawing.Point(12, 70);
            this.btnEmailReport.Name = "btnEmailReport";
            this.btnEmailReport.Size = new System.Drawing.Size(117, 23);
            this.btnEmailReport.TabIndex = 2;
            this.btnEmailReport.Text = "Email Report";
            this.btnEmailReport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnEmailReport);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnExportReport);
            this.Name = "Form1";
            this.Text = "Snacks on Racks Sales Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnEmailReport;
    }
}

