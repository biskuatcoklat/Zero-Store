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
    class TransaksiViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        TransaksiService ObjTransaksiService;
        public TransaksiViewModel()
        {
            ObjTransaksiService = new TransaksiService();
            LoadData();
            CurrentTransaksi = new Transaksi();

        }
        private ObservableCollection<Transaksi> transaksiList;

        public ObservableCollection<Transaksi> TransaksiList
        {
            get { return transaksiList; }
            set { transaksiList = value; OnPropertyChanged("TransaksiList"); }
        }

        private void LoadData()
        {
            TransaksiList = new ObservableCollection<Transaksi>(ObjTransaksiService.GetAll());
        }

        private Transaksi currentTransaksi;
        public Transaksi CurrentTransaksi
        {
            get { return currentTransaksi; }
            set { currentTransaksi = value; OnPropertyChanged("CurrentTransaksi"); }
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
