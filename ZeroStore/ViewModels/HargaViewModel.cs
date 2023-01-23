using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroStore.Command;
using ZeroStore.Models;

namespace ZeroStore.ViewModels
{
    class HargaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        HargaService ObjHargaService;
        public HargaViewModel()
        {
            ObjHargaService = new HargaService();

        }
        private ObservableCollection<Harga> hargaList;

        public ObservableCollection<Harga> HargaList
        {
            get { return hargaList; }
            set { hargaList = value; OnPropertyChanged("HargaList"); }
        }


        private Transaksi currentHarga;
        public Transaksi CurrentHarga
        {
            get { return currentHarga; }
            set { currentHarga = value; OnPropertyChanged("CurrentHarga"); }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }



        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
        }



        private RelayCommand updateCommand;
        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }



        private RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }
    }
}
