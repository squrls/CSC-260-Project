using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class Vehicle : Equipment
    {
        public Vehicle(string name) : base(name)
        {
            this.Name = name;
            IsEquipped = false;
        }

        //public string Name;
        //public bool IsEquipped;
        

        //string DataOut()
        //{
        //    return (Name +  "is a truckkkkkk\n");
        //}
    }
}
