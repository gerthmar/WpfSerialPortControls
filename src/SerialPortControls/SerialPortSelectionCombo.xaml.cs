using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SerialPortControls
{

    /// <summary>
    /// Combo box control that lets the user choose a serial port out of all 
    /// currently available serial ports. The combo box also contains a button
    /// to refresh the available serial ports eg. when a USB to serial converter
    /// has been attached or removed.
    /// </summary>
    public partial class SerialPortSelectionCombo : UserControl
    {
        private SerialPortLister serialPortLister = new SerialPortLister();

        public SerialPortSelectionCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Observable collection to be bound to the WPF element.
        /// </summary>
        public ObservableCollection<SerialPortInfo> PortCollection
        {
            get
            {
                return serialPortLister.PortCollection;
            }
            set { }
        }

        /// <summary>
        /// Selected serial port to be bound to the WPF element.
        /// </summary>
        public SerialPortInfo SelectedPort
        {
            get
            {
                return serialPortLister.SelectedPort;
            }
            set { serialPortLister.SelectedPort = value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            serialPortLister.Refresh();
            // refresh the data source for the selected value, since this is not done by wpf
            ComboBox.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateTarget();
        }
    }
}
