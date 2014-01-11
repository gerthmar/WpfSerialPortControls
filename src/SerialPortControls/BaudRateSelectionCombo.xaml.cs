using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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
    public partial class BaudRateSelectionCombo : UserControl
    {
        private ObservableCollection<int> collection = new ObservableCollection<int>();
        private int selectedBaudRate;

        public ObservableCollection<int> BaudRateCollection
        {
            get
            {
                return collection;
            }
            set{}
        }

        public int SelectedBaudRate
        {
            get
            {
                return selectedBaudRate;
            }
            set
            {
                selectedBaudRate = value;
            }
        }

        public void AddBaudRate( int baudRate )
        {
            if (!collection.Contains(baudRate))
            {
                collection.Add(baudRate);
                collection = new ObservableCollection<int>(collection.OrderBy(i => i));
                
                // update the combo box since we have re-created the collection
                ComboBox.GetBindingExpression(ComboBox.ItemsSourceProperty).UpdateTarget();
                ComboBox.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateTarget();                
            }
        }

        public void RemoveBaudRate(int baudRate)
        {
            if (collection.Contains(baudRate))
            {
                collection.Remove(baudRate);
            }
        }

        public BaudRateSelectionCombo()
        {
            selectedBaudRate = 9600;
            /* add common known baud rates */
            collection.Add(2400);
            collection.Add(4800);
            collection.Add(9600);
            collection.Add(14400);
            collection.Add(19200);
            collection.Add(28800);
            collection.Add(38400);
            collection.Add(56000);
            collection.Add(57600);
            collection.Add(115200);
            collection.Add(128000);
            collection.Add(153600);
            collection.Add(230400);
            collection.Add(256000);
            collection.Add(460800);
            collection.Add(921600);
            InitializeComponent();
        }
    }
}
