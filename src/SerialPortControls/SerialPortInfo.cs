using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortControls
{
    public class SerialPortInfo
    {
        public String Name = "";

        public override string ToString()
        {
            return Name;
        }


        public SerialPortInfo(string name)
        {
            Name = name;
        }
    }
}
