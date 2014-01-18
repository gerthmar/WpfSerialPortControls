using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für SerialPortControl.xaml
    /// </summary>
    public partial class SerialPortControl : UserControl
    {
        public SerialPortControl()
        {
            InitializeComponent();
        }

        public bool Enable002400
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(2400); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(2400); } else { BaudRateSelectionCombo.RemoveBaudRate(2400); } }
        }
        public bool Enable004800
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(4800); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(4800); } else { BaudRateSelectionCombo.RemoveBaudRate(4800); } }
        }
        public bool Enable009600
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(9600); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(9600); } else { BaudRateSelectionCombo.RemoveBaudRate(9600); } }
        }
        public bool Enable014400
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(14400); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(14400); } else { BaudRateSelectionCombo.RemoveBaudRate(14400); } }
        }
        public bool Enable019200
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(19200); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(19200); } else { BaudRateSelectionCombo.RemoveBaudRate(19200); } }
        }
        public bool Enable028800
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(28800); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(28800); } else { BaudRateSelectionCombo.RemoveBaudRate(28800); } }
        }
        public bool Enable038400
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(38400); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(38400); } else { BaudRateSelectionCombo.RemoveBaudRate(38400); } }
        }
        public bool Enable056000
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(56000); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(56000); } else { BaudRateSelectionCombo.RemoveBaudRate(56000); } }
        }
        public bool Enable057600
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(57600); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(57600); } else { BaudRateSelectionCombo.RemoveBaudRate(57600); } }
        }
        public bool Enable115200
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(115200); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(115200); } else { BaudRateSelectionCombo.RemoveBaudRate(115200); } }
        }
        public bool Enable128000
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(128000); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(128000); } else { BaudRateSelectionCombo.RemoveBaudRate(128000); } }
        }
        public bool Enable153600
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(153600); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(153600); } else { BaudRateSelectionCombo.RemoveBaudRate(153600); } }
        }
        public bool Enable230400
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(230400); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(230400); } else { BaudRateSelectionCombo.RemoveBaudRate(230400); } }
        }
        public bool Enable256000
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(256000); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(256000); } else { BaudRateSelectionCombo.RemoveBaudRate(256000); } }
        }
        public bool Enable460800
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(460800); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(460800); } else { BaudRateSelectionCombo.RemoveBaudRate(460800); } }
        }
        public bool Enable921600
        {
            get { return BaudRateSelectionCombo.IsBaudRateEnabled(921600); }
            set { if (value) { BaudRateSelectionCombo.AddBaudRate(921600); } else { BaudRateSelectionCombo.RemoveBaudRate(921600); } }
        }

    }
}
