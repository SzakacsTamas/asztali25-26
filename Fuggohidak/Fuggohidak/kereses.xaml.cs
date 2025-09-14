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
        }
    }
}
