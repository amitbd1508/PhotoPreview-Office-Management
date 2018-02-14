using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoPreview.UC_photographers;

namespace PhotoPreview
{
    public partial class UCPhotoGraphers : UserControl
    {
        public UCPhotoGraphers()
        {
            InitializeComponent();
        }

        private void UCPhotoGraphers_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            UC_PG_Personal_Info uc = new UC_PG_Personal_Info();
            pnlGrid.Controls.Add(uc);
        }
    }
}
