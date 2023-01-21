using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroStore.Models;
using ZeroStore.Command;
using System.Collections.ObjectModel;

namespace ZeroStore.ViewModels
{
    public class BarangViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        BarangService ObjBarangService;
        public BarangViewModel()
        {
            ObjBarangService = new BarangService();
            LoadData();
            CurrentBarang = new Barang();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);

        }
        private ObservableCollection<Barang> barangList;

        public ObservableCollection<Barang> BarangList
        {
            get { return barangList; }
            set { barangList = value; OnPropertyChanged("BarangList"); }
        }

        private void LoadData()
        {
            BarangList = new ObservableCollection<Barang>(ObjBarangService.GetAll());
        }

        private Barang currentBarang;
        public Barang CurrentBarang
        {
            get { return currentBarang; }
            set { currentBarang = value; OnPropertyChanged("CurrentBarang"); }
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

        public void Save()
        {
            try
            {
                var IsSaved = ObjBarangService.Tambah(currentBarang);
                LoadData();
                if ((bool)IsSaved)
                    Message = "Barang Tersimpan";
                else
                    Message = "Gagal tersimpan";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Search()
        {
            try
            {
                var ObjBarang = ObjBarangService.Search(CurrentBarang.Id);

                if (ObjBarang != null)
                {
                    CurrentBarang.Namebarang = ObjBarang.Namebarang;
                    CurrentBarang.Statusbarang = ObjBarang.Statusbarang;
                }
                else
                    Message = "Not Found";
            }
            catch (Exception)
            {

            }
        }

        private RelayCommand updateCommand;
        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }

        public void Update()
        {
            try
            {
                var Isupdate = ObjBarangService.Update(CurrentBarang);
                if (Isupdate)
                {
                    Message = "Data sudah di ubah";
                    LoadData();
                }
                else
                {
                    Message = "Gagal di update";
                }
            }
            catch (Exception)
            {

            }

        }

        private RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }

        public void Delete()
        {
            try
            {
                var IsDelete = ObjBarangService.Hapus(CurrentBarang.Id);
                if (IsDelete)
                {
                    Message = "Berhasil di Hapus";
                    LoadData();
                }
                else
                {
                    Message = "Gagal Hapus Data";
                }
            }
            catch
            {

            }
        }
    }
}
