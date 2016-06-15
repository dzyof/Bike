using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FORMA : Form
    {
        public FORMA()
        {
            InitializeComponent();
            splitContainer.Panel2.Controls.Add(new ucCross());
        }

        
        private void lvBike_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBike ab = new addBike();
                if (ab.ShowDialog()== DialogResult.OK)
            {

            }
        }

        private void remuveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FORMA_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FORMA_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("By","inform", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
