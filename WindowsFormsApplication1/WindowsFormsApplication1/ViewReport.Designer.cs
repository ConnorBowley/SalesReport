namespace WindowsFormsApplication1
{
    partial class ViewReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReport));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleName = "";
            this.btnBrowse.Location = new System.Drawing.Point(12, 141);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 29);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(108, 141);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richDisplay
            // 
            this.richDisplay.Location = new System.Drawing.Point(13, 13);
            this.richDisplay.Name = "richDisplay";
            this.richDisplay.Size = new System.Drawing.Size(451, 122);
            this.richDisplay.TabIndex = 2;
            this.richDisplay.Text = "";
            this.richDisplay.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ViewReport
            // 
            this.AccessibleName = "ViewReport";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 182);
            this.Controls.Add(this.richDisplay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewReport";
            this.Text = "View Report";
            this.Load += new System.EventHandler(this.ViewReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richDisplay;
    }
}