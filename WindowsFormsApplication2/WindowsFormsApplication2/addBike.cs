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
    public partial class addBike : Form
    {
        private ucCross ucCross = new ucCross();
        private ucHard ucHard = new ucHard();
        private ucHardTale ucHardTale = new ucHardTale();

        public addBike()
        {
            InitializeComponent();
            cbBikeType.Items.Add(bikeTipe.Cross);
            cbBikeType.Items.Add(bikeTipe.Hard);
            cbBikeType.Items.Add(bikeTipe.Hardtale);



        }

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bikeTipe type =(bikeTipe) Enum.Parse(typeof(bikeTipe), cbBikeType.SelectedItem.ToString());
                switch (type)
            {
                case bikeTipe.Cross :
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucCross);
                    break;

                case bikeTipe.Hard:
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucHard);
                    break;

                case bikeTipe.Hardtale:
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucHardTale);
                    break;
            }
        }

        public Bike SetCreateBike();
        {
            
        }
        private void addBike_Load(object sender, EventArgs e)
        {

        }
    }
}
