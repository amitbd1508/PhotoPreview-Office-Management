using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoPreview.UC_photographers;

namespace PhotoPreview
{
    public partial class frmControlPanel : Form
    {
        public frmControlPanel()
        {
            InitializeComponent();
            
        }

       

        private void btnPhotographers_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPhotoGraphers ucPhotographers = new UCPhotoGraphers();
            pnlMain.Controls.Add(ucPhotographers);
        }

        private void btnDummyPhotographers_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_PG_Photographer_Tab ucPhotographers = new UC_PG_Photographer_Tab();
            pnlMain.Controls.Add(ucPhotographers);
        }
    }
}
