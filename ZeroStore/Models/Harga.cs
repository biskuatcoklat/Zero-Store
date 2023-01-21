using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroStore.Models
{
    public class Harga : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string id_harga;
        public string Id_harga
        {
            get { return id_harga; }
            set { id_harga = value; OnPropertyChanged("Id_harga"); }
        }

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        private string Hargabarang;
        public string hargabarang
        {
            get { return Hargabarang; }
            set { Hargabarang = value; OnPropertyChanged("hargabarang"); }
        }
    }
}
