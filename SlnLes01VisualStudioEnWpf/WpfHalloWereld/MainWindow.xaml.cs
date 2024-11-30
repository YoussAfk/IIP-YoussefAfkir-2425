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

namespace WpfHalloWereld
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            txtHello.Text = "Hallo " + txtNaam.Text;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            txtHello.Text = "Hoe is je naam?";
            txtNaam.Text = "";
        }

        private void BtnSayHello_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}