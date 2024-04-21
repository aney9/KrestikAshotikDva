using krestikashotikDva.View;
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

namespace krestikashotikDva
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

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            igra igra = new igra();
            igra.Show();
            this.Close();
        }

        private void registr_Click(object sender, RoutedEventArgs e)
        {
            registration registr = new registration();
            registr.Show();
            this.Close();
        }
    }
}