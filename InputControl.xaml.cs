using System;
using System.Collections.Generic;
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
using ConversionCalc.Resources;

namespace ConversionCalc
{
    /// <summary>
    /// Interaction logic for InputControl.xaml
    /// </summary>
    public partial class InputControl : UserControl
    {
        public event EventHandler UCInputChanged;
        public event EventHandler UCSelectionChanged;

        public InputControl()
        {
            InitializeComponent();
        }

        private void InputTextChanged(object sender, TextChangedEventArgs e)
        {
            UCInputChanged?.Invoke(this, EventArgs.Empty);
            
        }

        private void InputSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UCSelectionChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    
}
