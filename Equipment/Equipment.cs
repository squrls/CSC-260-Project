using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class Equipment
    {
        //Equipment() { }
        public Equipment(string ename) 
        {
            Name = ename;
            IsEquipped = false;
            
        }
        public string Name;
        public bool IsEquipped;

        public string DataOut()
        {
            return (Name + "\n");
        }
    }
}
