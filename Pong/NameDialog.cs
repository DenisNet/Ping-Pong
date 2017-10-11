using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class NameDialog : Form
    {
        public string LiefereName()
        {
            return textBox1.Text;
        }

        public NameDialog()
        {
            InitializeComponent();
        }
    }
}
