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

        public bool Enable002400{ 
            get { return collection.Contains(2400); }
            set {if (value) {AddBaudRate(2400);}else{RemoveBaudRate(2400);}}
        }
        public bool Enable004800
        {
            get { return collection.Contains(4800); }
            set { if (value) { AddBaudRate(4800); } else { RemoveBaudRate(4800); } }
        }
        public bool Enable009600
        {
            get { return collection.Contains(9600); }
            set { if (value) { AddBaudRate(9600); } else { RemoveBaudRate(9600); } }
        }
        public bool Enable014400
        {
            get { return collection.Contains(14400); }
            set { if (value) { AddBaudRate(14400); } else { RemoveBaudRate(14400); } }
        }
        public bool Enable019200
        {
            get { return collection.Contains(19200); }
            set { if (value) { AddBaudRate(19200); } else { RemoveBaudRate(19200); } }
        }
        public bool Enable028800
        {
            get { return collection.Contains(28800); }
            set { if (value) { AddBaudRate(28800); } else { RemoveBaudRate(28800); } }
        }
        public bool Enable038400
        {
            get { return collection.Contains(38400); }
            set { if (value) { AddBaudRate(38400); } else { RemoveBaudRate(38400); } }
        }
        public bool Enable056000
        {
            get { return collection.Contains(56000); }
            set { if (value) { AddBaudRate(56000); } else { RemoveBaudRate(56000); } }
        }
        public bool Enable057600
        {
            get { return collection.Contains(57600); }
            set { if (value) { AddBaudRate(57600); } else { RemoveBaudRate(57600); } }
        }
        public bool Enable115200
        {
            get { return collection.Contains(115200); }
            set { if (value) { AddBaudRate(115200); } else { RemoveBaudRate(115200); } }
        }
        public bool Enable128000
        {
            get { return collection.Contains(128000); }
            set { if (value) { AddBaudRate(128000); } else { RemoveBaudRate(128000); } }
        }
        public bool Enable153600
        {
            get { return collection.Contains(153600); }
            set { if (value) { AddBaudRate(153600); } else { RemoveBaudRate(153600); } }
        }
        public bool Enable230400
        {
            get { return collection.Contains(230400); }
            set { if (value) { AddBaudRate(230400); } else { RemoveBaudRate(230400); } }
        }
        public bool Enable256000
        {
            get { return collection.Contains(256000); }
            set { if (value) { AddBaudRate(256000); } else { RemoveBaudRate(256000); } }
        }
        public bool Enable460800
        {
            get { return collection.Contains(460800); }
            set { if (value) { AddBaudRate(460800); } else { RemoveBaudRate(460800); } }
        }
        public bool Enable921600
        {
            get { return collection.Contains(921600); }
            set { if (value) { AddBaudRate(921600); } else { RemoveBaudRate(921600); } }
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

            InitializeComponent();
        }
    }
}
