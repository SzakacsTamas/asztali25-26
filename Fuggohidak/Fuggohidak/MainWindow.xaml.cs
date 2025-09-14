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
        List<Fuggohid> adatok = new List<Fuggohid>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
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

        private void radio1_Checked(object sender, RoutedEventArgs e)
        {
            int szam = 0;
            foreach (Fuggohid asd in adatok)
            {
                if (asd.ev < 2000)
                {
                    szam++;
                }
            }

            szovegHelye.Text = szam.ToString();
        }

        private void radio2_Checked(object sender, RoutedEventArgs e)
        {
            int szam = 0;
            foreach (Fuggohid asd in adatok)
            {
                if (asd.ev >= 2000)
                {
                    szam++;
                }
            }

            szovegHelye.Text = szam.ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            kereses kereses = new kereses();
            kereses.Show();
            this.Hide();
        }
    }
}