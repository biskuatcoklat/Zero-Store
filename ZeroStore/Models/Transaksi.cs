using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroStore.Models
{
    public class Transaksi : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string id_transaksi;
        public string Id_transaksi
        {
            get { return id_transaksi; }
            set { id_transaksi = value; OnPropertyChanged("Id_transaksi"); }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        private string id_konsumen;
        public string Id_konsumen
        {
            get { return id_konsumen; }
            set { id_konsumen = value; OnPropertyChanged("Id_konsumen"); }
        }

        private DateTime Tanggal;
        public DateTime tanggal
        {
            get { return Tanggal; }
            set { Tanggal = value;OnPropertyChanged("tanggal"); }
        }

        private string Keterangan;
        public string keterangan
        {
            get { return Keterangan; }
            set { Keterangan = value; OnPropertyChanged("keterangan"); }
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
