using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment
{
    public partial class UserInterface : Form
    {
        public UserInterface(string userClass)
        {
            InitializeComponent();
            tempConsole.Text = userClass;
        }

        private void testbutton(object sender, EventArgs e)
        {
            tempConsole.Text += "asdf";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
