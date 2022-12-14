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
        public UserPage(List<Operator> operators)
        {
            Operators = operators;
            
            InitializeComponent();
        }

        List<Operator> Operators;
        public string selectedUser { get; set; }
        private void UserPage_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) 
            {
                selectedUser = comboBox1.Text;
                this.DialogResult= DialogResult.OK;
                this.Close();
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
