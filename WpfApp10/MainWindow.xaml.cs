using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp10.Models;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<TheImages> ImagesG { get; set; } = new ObservableCollection<TheImages>
        {
            new TheImages
            {
                ImagePath = "Image/i1.jpg"
            },
            new TheImages
            {
                ImagePath = "Image/i2.jpg"
            },
            new TheImages
            {
                ImagePath = "Image/i3.jpg"
            },
            new TheImages
            {
                ImagePath = "Image/i4.jpg"
            },
            new TheImages
            {
                ImagePath = "Image/i5.jpg"
            }
        };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as MenuItem).Header.ToString() == "Large")
            {
                this.Resources["SizePh"] = Convert.ToDouble(200);
            }
            else if ((sender as MenuItem).Header.ToString() == "Default")
            {
                this.Resources["SizePh"] = Convert.ToDouble(160);
            }
            else if ((sender as MenuItem).Header.ToString() == "Small")
            {
                this.Resources["SizePh"] = Convert.ToDouble(100);
            }
        }

        private void mage_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var win2 = new W2();
            win2.images = ImagesG.ToList();
            win2.index = (sender as ListBox).SelectedIndex;
            win2.Show();
        }

        private void mage_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
