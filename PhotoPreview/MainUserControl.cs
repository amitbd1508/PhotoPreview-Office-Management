using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoPreview
{
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            this.Width = this.Parent.Height;
            this.Dock = DockStyle.Fill;
        }
    }
}
