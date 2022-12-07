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
        List<Equipment> EquipmentCheckedOut = new List<Equipment>();
        public bool Licensed;

        public Operator(string name) 
        {
            Name = name;
        }

        public void CheckoutEquipment(Equipment equipment)
        {
            EquipmentCheckedOut.Add(equipment);
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
