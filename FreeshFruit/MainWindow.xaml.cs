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

namespace FreeshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller Toni;
        public MainWindow()
        {
            InitializeComponent();

            Bucket Keranjang = new Bucket(2);
            BucketController bucketController = new BuckeetController(KeranjangBuah, this);

                   }

        private void OnButtonAnggurCliked(object sender, RoutedEventArgs e)
        {

        }
        private void OnButtonApelCliked(object sender, RoutedEventArgs e)
        {

        }
     
      

        private void buttonAddPisangClicked(object sender, RoutedEventArgs e)
        {

        }

        private void buttonAddOrangeCliked(object sender, RoutedEventArgs e)
        {

        }
    }
}
