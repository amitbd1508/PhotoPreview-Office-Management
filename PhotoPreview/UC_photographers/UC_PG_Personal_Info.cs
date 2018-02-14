using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoPreview.UC_photographers
{
    public partial class UC_PG_Personal_Info : UserControl
    {
        public UC_PG_Personal_Info()
        {
            InitializeComponent();
        }

        private void UC_PG_Personal_Info_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
