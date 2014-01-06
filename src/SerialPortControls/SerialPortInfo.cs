using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortControls
{
    /// <summary>
    /// Class encapsulating information about the serial port.
    /// So far there is only the name, but maybe there will be additions
    /// in the future.
    /// </summary>
    public class SerialPortInfo
    {
        /// <summary>
        /// Name of the serial port as it is named by the OS. Eg. "COM1"
        /// </summary>
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
