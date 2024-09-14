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

namespace inf04._01._2024
{
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string numer2 = numer.Text;
            string imie2 = imie.Text; 
            string nazwisko2 = nazwisko.Text;
            string kolor2 = "";

            if(niebieskie.IsChecked == true)
            {
                kolor2 = "niebieski";
            }
            else if (zielone.IsChecked == true)
            {
                kolor2 = "zielone";
            }
            else if (piwne.IsChecked == true)
            {
                kolor2 = "piwne";
            }

            if (imie2 != "" && nazwisko2 != "") {
                MessageBox.Show(imie2 + " " + nazwisko2 + " kolor oczu " + kolor2);
            }
            else
            {
                MessageBox.Show("Wprowadź dane");
            }
        }
        
        private void numer_TextChanged(object sender, RoutedEventArgs e)
        { 
            string numerek = numer.Text;
            prof.Source = new BitmapImage(new Uri("img/" + numerek + "-zdjecie.jpg", UriKind.Relative));
            odc.Source = new BitmapImage(new Uri("img/" + numerek + "-odcisk.jpg", UriKind.Relative));
        }

    }
}
