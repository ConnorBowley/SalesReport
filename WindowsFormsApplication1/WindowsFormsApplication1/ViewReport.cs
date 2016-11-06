using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.RestoreDirectory = true;
            if (result == DialogResult.OK) // Test result.
            {
                try
                {
                    String file = openFileDialog1.FileName;
                    FileStream fr = new FileStream(file, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fr);
                    String r = sr.ReadToEnd();
                    fr.Close();
                    sr.Close();
                    richDisplay.Text = r;
                    
                }
                catch (IOException)
                {
                }
                
            }

        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
