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

namespace PhotoPreview.UC_photographers
{
    public partial class UC_PG_Photographer_Tab : UserControl
    {
        public UC_PG_Photographer_Tab()
        {
            InitializeComponent();
        }

        private void UC_PG_Photographer_Tab_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnPhotographers_Click(object sender, EventArgs e)
        {
            btnPhotographers.BackColor = Color.White;
            UC_PG_Photographer_tab_select uc = new UC_PG_Photographer_tab_select();
            pnlTabPhotographers.Controls.Add(uc);

        }
    }
}
