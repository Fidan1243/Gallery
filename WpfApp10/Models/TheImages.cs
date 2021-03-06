using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10.Models
{
    public class TheImages : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; OnPropertyChanged(); }
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
