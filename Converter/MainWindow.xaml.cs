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

namespace Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Feet_Click(object sender, RoutedEventArgs e)
        {
            double feet;

            if (validateMetersInputs())
            {
                feet = double.Parse(TextBox_Meters.Text) * 3.28;

                TextBox_Feet.Text = feet.ToString();
            }
            
        }

        private void Button_Meters_Click(object sender, RoutedEventArgs e)
        {
            double meters;

            if (validateFeetInputs())
            {
                meters = double.Parse(TextBox_Feet.Text) / 3.28;

                TextBox_Meters.Text = meters.ToString();
            }

        }

        private bool validateFeetInputs()
        {
            bool validInputs = true;

            if (!double.TryParse(TextBox_Feet.Text, out double feet))
            {
                MessageBox.Show("Please enter numbers for the feild");
                validInputs = false;
                ResetInputs();
            }

            return validInputs;
        }

        private bool validateMetersInputs()
        {
            bool validInputs = true;

            if (!double.TryParse(TextBox_Meters.Text, out double meters))
            {
                MessageBox.Show("Please enter numbers for the feild");
                validInputs = false;
                ResetInputs();
            }

            return validInputs;
        }

        private void ResetInputs()
        {
            TextBox_Feet.Text = "";
            TextBox_Meters.Text = "";
            TextBox_Feet.Focus();
        }
    }
}
