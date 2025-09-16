using System.IO;
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
using System.Windows.Shapes;

namespace Fuggohidak
{
    /// <summary>
    /// Interaction logic for kereses.xaml
    /// </summary>
    public partial class kereses : Window
    {
        public kereses()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window window = new MainWindow();
            window.Show();

        }
        List<Fuggohid> adatok = new List<Fuggohid>();
        List<string> orszaglist = new List<string>();

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Fuggohid asd in adatok)
            {
                if (!orszaglist.Contains(asd.orszag))
                {
                    orszaglist.Add(asd.orszag);
                }

            }
            comboBox.ItemsSource = orszaglist;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            string[] line = File.ReadAllLines("fuggohidak.csv");
            foreach (string adat in line.Skip(1))
            {
                adatok.Add(new Fuggohid(adat));
            }

        }
    }
}
