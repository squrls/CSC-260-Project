using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    public class Equipment
    {
        
        public Equipment(string name) 
        {
            Name= name;
        }
        public string Name;

        public string DataOut()
        {
            return (Name + "\n");
        }
    }
}
