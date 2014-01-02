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
    /// </summary>
    public partial class SerialPortSelectionCombo : UserControl
    {

        private SerialPortLister serialPortLister = new SerialPortLister();

        public ObservableCollection<SerialPortInfo> PortCollection
        {
            get
            {
                return serialPortLister.PortCollection;
            }
            set { }
        }

        public SerialPortInfo SelectedPort
        {
            get
            {
                return serialPortLister.SelectedPort;
            }
            set { serialPortLister.SelectedPort = value; }
        }

        public SerialPortSelectionCombo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            serialPortLister.Refresh();
            // refresh the data source for the selected value, since this is not done by wpf
            ComboBox.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateTarget();
        }
    }
}
