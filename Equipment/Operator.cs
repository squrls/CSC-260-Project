using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class Operator
    {
        public string Name;
        public List<Equipment> EquipmentCheckedOut = new List<Equipment>();
        public bool Licensed;

        public Operator(string name) 
        {
            Name = name;
            Licensed = false;
        }

        public Operator(string name, bool license)
        {
            Name = name;
            Licensed = license;
        }

        public void CheckoutEquipment(Equipment equipment)
        {
            EquipmentCheckedOut.Add(equipment);
            equipment.IsEquipped= true;
        }

        public void CheckoutEquipment(Vehicle equipment)
        {
            EquipmentCheckedOut.Add(equipment);
            if (Licensed == false)
            {
                System.Windows.Forms.MessageBox.Show("Unlicensed");
                return;
            }
            else {
                equipment.IsEquipped = true;
            }
        }

        public void ReturnEquipment(Equipment equipment)
        {
            EquipmentCheckedOut.Remove(equipment);
            equipment.IsEquipped = false;
        }

        public string ViewEquipment() 
        {
            string output = "";
            foreach (Equipment thing in EquipmentCheckedOut)
            {
                output += thing.DataOut();
            }
            return output;
        }

    }
}
