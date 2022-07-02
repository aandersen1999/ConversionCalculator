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
using System.Collections.ObjectModel;
using ConversionCalc.Resources;

namespace ConversionCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConvObject typesObject = new ConvObject();
        public MainWindow()
        {
            InitializeComponent();
            
            ConversionComboType.ItemsSource = typesObject.Types;
            ConversionComboType.SelectedIndex = 0;
            Input1.InputValue.Text = "0";
            Input2.InputValue.Text = "0";
        }

        private void Input1_ChangedHandler()
        {
            Decimal x = 0.0m;
            Decimal y = 0.0m;
            if (Decimal.TryParse(Input1.InputValue.Text, out x))
            {
                if (Formulas.Handler != null) { y = Formulas.Handler(x); }
                Input2.InputValue.Text = y.ToString();
            }
        }

        private void Input2_ChangedHandler()
        {
            Decimal x = 0.0m;
            Decimal y = 0.0m;
            if (Decimal.TryParse(Input2.InputValue.Text, out x))
            {
                if (Formulas.Handler != null) { y = Formulas.Handler(x); }
                Input1.InputValue.Text = y.ToString();
            }
        }

        private void OnConversionTypeUpdate(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox temp)
            {
                Input1.Units.ItemsSource = Units.Instance.GetCollection(temp.SelectedIndex);
                Input2.Units.ItemsSource = Units.Instance.GetCollection(temp.SelectedIndex);
                Input1.Units.SelectedIndex = 0;
                Input2.Units.SelectedIndex = 1;
            }
            else
            {
                return;
            }
        }

        private void Input1_Changed(object sender, EventArgs e)
        {
            Input1_ChangedHandler();
        }

        private void Input1_SlcChanged(object sender, EventArgs e)
        {
            Formulas.changeFormula(Input1.Units.SelectedIndex, Input2.Units.SelectedIndex, ConversionComboType.SelectedIndex);
            Input1_ChangedHandler();
        }

        private void Input2_Changed(object sender, EventArgs e)
        {

        }

        private void Input2_SlcChanged(object sender, EventArgs e)
        {
            Formulas.changeFormula(Input1.Units.SelectedIndex, Input2.Units.SelectedIndex, ConversionComboType.SelectedIndex);
            Input1_ChangedHandler();
        }


    }
}
