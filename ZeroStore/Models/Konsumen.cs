using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroStore.Models
{
    public class Konsumen : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string id_konsumen;
        public string Id_konsumen
        {
            get { return id_konsumen; }
            set { id_konsumen = value; OnPropertyChanged("Id_konsumen"); }
        }

        private string nama_konsumen;
        public string Nama_konsumen
        {
            get { return nama_konsumen; }
            set { nama_konsumen = value; OnPropertyChanged("Nama_konsumen"); }
        }

        private string alamat_konsumen;
        public string Alamat_konsumen
        {
            get { return alamat_konsumen; }
            set { alamat_konsumen = value; OnPropertyChanged("Alamat_konsumen"); }
        }
    }
    
}
