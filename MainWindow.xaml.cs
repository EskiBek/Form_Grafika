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

namespace form_galery
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

        private void Ok_Button_Click(object sender, RoutedEventArgs e)
        {
            string imieOsoby = imie_box.Text;
            string nazwiskoOsoby = nazwisko_box.Text;
            string numerOsoby = numer_box.Text;

            //var selectedRadioButton = RadioButtons_StackPanel.Children.OfType<RadioButton>().FirstOrDefault(v => v.IsChecked.Value == true);
            //if (selectedRadioButton != null)
            //{
            //    MessageBox.Show($"Wybrano: {selectedRadioButton.Content}");
            //}

            // combobox, przez radio, karuzela, przez wpisanie, GRAFIKA boi (C# edition)

            if(imieOsoby != "" && nazwiskoOsoby != "" && numerOsoby != "")
            {
                MessageBox.Show(imieOsoby, nazwiskoOsoby + ", kolor oczu: ");
            }
        }
    }
}
