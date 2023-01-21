using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroStore.Models
{
    public class Barang : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        private string namebarang;
        public string Namebarang
        {
            get { return namebarang; }
            set { namebarang = value; OnPropertyChanged("Namebarang"); }
        }

        private string statusbarang;
        public string Statusbarang
        {
            get { return statusbarang; }
            set { statusbarang = value; OnPropertyChanged("Statusbarang"); }
        }

        private string id_harga;
        public string Id_harga
        {
            get { return id_harga; }
            set { id_harga = value; OnPropertyChanged("Id_harga"); }
        }

        private string Hargabarang;
        public string hargabarang
        {
            get { return Hargabarang; }
            set { Hargabarang = value; OnPropertyChanged("hargabarang"); }
        }
    }
}
