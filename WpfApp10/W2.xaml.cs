using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfApp10.Models;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for W2.xaml
    /// </summary>
    public partial class W2 : Window
    {
        public List<TheImages> images { get; set; }
        public string firstlc { get; set; }
        public int index { get; set; }
        DispatcherTimer timer = new DispatcherTimer();
        public bool IsClicked { get; set; } = false;
        public W2()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void PlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (!IsClicked)
            {

                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += Timer_Tick;
                timer.Start();
                IsClicked = true;
            }
            else
            {
                timer.Stop();
                IsClicked = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (index + 1 < images.Count)
            {
                string a2 = images[index + 1].ImagePath;
                int cn = index + 1;
                name1.Source = new BitmapImage(new Uri($@"{a2}", UriKind.RelativeOrAbsolute));
                index += 1;
            }
            else
            {
                index = 0;
                string a2 = images[index].ImagePath;
                name1.Source = new BitmapImage(new Uri($@"{a2}", UriKind.RelativeOrAbsolute));

            }
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button br)
            {

                if (br.Name == "Next")
                {
                    if (index + 1 < images.Count)
                    {
                        string a2 = images[index + 1].ImagePath;
                        int cn = index + 1;
                        name1.Source = new BitmapImage(new Uri($@"{a2}", UriKind.RelativeOrAbsolute));
                        index += 1;
                    }
                    else
                    {
                        index = 0;
                        string a2 = images[index].ImagePath;
                        name1.Source = new BitmapImage(new Uri($@"{a2}", UriKind.RelativeOrAbsolute));

                    }
                }
                else
                {
                    if (index <= images.Count && index > 0)
                    {
                        string a2 = images[index - 1].ImagePath;
                        name1.Source = new BitmapImage(new Uri($@"{a2}", UriKind.RelativeOrAbsolute));
                        index -= 1;
                    }
                    else
                    {
                        index = images.Count - 1;
                        string a2 = images[index].ImagePath;
                        name1.Source = new BitmapImage(new Uri($@"{a2}", UriKind.RelativeOrAbsolute));

                    }
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
