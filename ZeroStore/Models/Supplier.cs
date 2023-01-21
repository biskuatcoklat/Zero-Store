using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroStore.Models
{
    public class Supplier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string id_supplier;
        public string Id_supplier
        {
            get { return id_supplier; }
            set { id_supplier = value; OnPropertyChanged("Id_supplier"); }
        }

        private string nama_supplier;
        public string Nama_supplier
        {
            get { return nama_supplier; }
            set { nama_supplier = value; OnPropertyChanged("Nama_supplier"); }
        }

        private string alamat_supplier;
        public string Alamat_supplier
        {
            get { return alamat_supplier; }
            set { alamat_supplier = value; OnPropertyChanged("Alamat_supplier"); }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }
    }
}
