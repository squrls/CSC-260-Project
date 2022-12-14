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
        Operator CurrentUser;
        List<Equipment> Equipments;

        public UserInterface(Operator oper, List<Equipment> equipments)
        {
            
            CurrentUser = oper;
            Equipments = equipments;

            InitializeComponent();

            tempConsole.Text = oper.Name;
            tempConsole.Text += oper.ViewEquipment();

        }

        private void testbutton(object sender, EventArgs e)
        {
            tempConsole.Text += CurrentUser.ViewEquipment();

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (ComboAvailableEquip.SelectedIndex != -1)
            {
                //tempConsole.Text += "Check";
                string selectedEquipmentName = ComboAvailableEquip.Text;
                var selectedEquipment = Equipments.Find(x => x.Name.Contains(selectedEquipmentName));
                CurrentUser.CheckoutEquipment(selectedEquipment);
                
                ComboAvailableEquip.Items.Remove(selectedEquipment.Name);
                ComboAvailableEquip.Refresh();
                
                ComboReturnEquip.Items.Add(selectedEquipment.Name);
                ComboReturnEquip.Refresh();
            }
        }
        private void Return_Click(object sender, EventArgs e)
        {
            if (ComboReturnEquip.SelectedIndex!= -1)
            {
                tempConsole.Text += "Return";
                string selectedEquipmentName = ComboReturnEquip.Text;
                var selectedEquipment = CurrentUser.EquipmentCheckedOut.Find(x => x.Name.Contains(selectedEquipmentName));
                CurrentUser.ReturnEquipment(selectedEquipment);
                
                ComboReturnEquip.Items.Remove(selectedEquipment.Name);
                ComboReturnEquip.Refresh();

                ComboAvailableEquip.Items.Add(selectedEquipment.Name);
                ComboAvailableEquip.Refresh();
            }
        }

        private void ComboAvailableEquip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
