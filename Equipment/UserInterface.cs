using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Equipment
{
    public partial class UserInterface : Form
    {
        
        public UserInterface(Operator oper)
        {
            InitializeComponent();
            //this.DataContext = new Operator("Hank");
            
            tempConsole.Text = oper.Name;
            tempConsole.Text += oper.ViewEquipment();
            CurrentUser = oper;
        }

        private void testbutton(object sender, EventArgs e)
        {
            tempConsole.Text += CurrentUser.Name;

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }
        Operator CurrentUser;

        
    }
}
