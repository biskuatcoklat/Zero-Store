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
    public class SupplierViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        SupplierService ObjSupplierService;
        public SupplierViewModel()
        {
            ObjSupplierService = new SupplierService();

        }
        private ObservableCollection<Supplier> supplierList;

        public ObservableCollection<Supplier> SupplierList
        {
            get { return supplierList; }
            set { supplierList = value; OnPropertyChanged("SUpplierList"); }
        }


        private Supplier currentSupplier;
        public Supplier CurrentSupplier
        {
            get { return currentSupplier; }
            set { currentSupplier = value; OnPropertyChanged("CurrentSupplier"); }
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
