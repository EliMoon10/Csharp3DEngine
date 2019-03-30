using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTKGameEngine
{
    public partial class infoform : Form
    {
        public infoform()
        {
            InitializeComponent();
        }

        private void close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
