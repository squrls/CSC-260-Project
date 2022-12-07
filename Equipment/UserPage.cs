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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        public string selectedUser { get; set; }
        private void UserPage_Load(object sender, EventArgs e)
        {
          
        }

       

        private void DisplayMessageBoxText(string mymessage)
        {
            MessageBox.Show(mymessage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) 
            {
                DisplayMessageBoxText(comboBox1.Text);
                selectedUser = comboBox1.Text;
                this.DialogResult= DialogResult.OK;
                this.Close();
                
            }
        }
    }
}
