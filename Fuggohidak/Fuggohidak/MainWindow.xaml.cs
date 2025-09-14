using System.IO;
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

namespace Fuggohidak
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Fuggohid> adatok = new List<Fuggohid>();
            string[] line = File.ReadAllLines("fuggohidak.csv");
            foreach (string adat in line.Skip(1))
            {
                adatok.Add(new Fuggohid(adat));
            }
            foreach (Fuggohid hid in adatok)
            {
                liszt.Items.Add(hid.nev);
              
            }
        }
    
    }
}