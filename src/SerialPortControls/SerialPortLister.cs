using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortControls
{
    public class SerialPortLister
    {
        private string[] portNames = new string[0];
        private ObservableCollection<SerialPortInfo> portCollection = new ObservableCollection<SerialPortInfo>();
        private SerialPortInfo selectedPort = null;

        public SerialPortLister()
        {
            Refresh();
        }


        public ObservableCollection<SerialPortInfo> PortCollection
        {
            get
            {
                return portCollection;
            }
            set { }
        }

        public SerialPortInfo SelectedPort
        {
            get
            {
                return selectedPort;
            }
            set
            {
                if (value == null)
                {
                    selectDefaultPort();
                }
                else
                {
                    selectedPort = value;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Refresh()
        {
            string[] newPortNames = SerialPort.GetPortNames();

            // remove missing ports ( ports may have been removed since last refresh )
            //
            // walk through the collection and check if all port names are 
            // still in the newPortNames array
            //
            // the ToList conversion is done to avoid issues when the collection that
            // is operated on is modified during iterations
            foreach (SerialPortInfo port in portCollection.ToList<SerialPortInfo>())
            {
                if (!isStringInArray(newPortNames, port.Name))
                {

                    portCollection.Remove(port);
                    if (selectedPort == port)
                    {
                        selectDefaultPort();
                    }
                }
            }

            // add new ports
            foreach (string portName in newPortNames)
            {
                if (!isPortInCollection(portName))
                {
                    portCollection.Add(new SerialPortInfo(portName));
                }
            }

            // check the selected port
            // todo: verify if collection is empty 
            if (selectedPort != null)
            {
                if (!portCollection.Contains(selectedPort))
                {
                    // if the previously selected port does not exist anymore, select
                    // the first of the list.
                    selectDefaultPort();
                }
            }
            else
            {
                selectDefaultPort();
            }

        }

        private void removePortFromCollection(string portName)
        {
            foreach (SerialPortInfo port in portCollection)
            {
                if (port.Name == portName)
                {
                    portCollection.Remove(port);
                }
            }
        }

        private bool isStringInArray(string[] stringArray, string searchString)
        {
            bool found = false;
            foreach (string currentString in stringArray)
            {
                if (currentString == searchString)
                {
                    found = true;
                }
            }
            return found;
        }

        private void selectDefaultPort()
        {
            if (portCollection.Count > 0)
            {
                selectedPort = portCollection[0];
            }
            else
            {
                selectedPort = null;
            }
        }
        /// <summary>
        /// Searches the local portCollection for a given port name.
        /// </summary>
        /// <param name="portName">Name of the port to search for.</param>
        /// <returns>True if a port with the given portName was found in the collection.</returns>
        private bool isPortInCollection(string portName)
        {
            bool found = false;

            foreach (SerialPortInfo port in portCollection)
            {
                if (port.Name == portName)
                {
                    found = true;
                }
            }
            return found;
        }

    }
}
