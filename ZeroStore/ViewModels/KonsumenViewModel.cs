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
    public class KonsumenViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        KonsumenService ObjKonsumenService;
        public KonsumenViewModel()
        {
            ObjKonsumenService = new KonsumenService();
            LoadData();
            CurrentKonsumen = new Konsumen();
            saveCommand1 = new RelayCommand(Save1);
            searchCommand1 = new RelayCommand(Search1);
            updateCommand1 = new RelayCommand(Update1);
            deleteCommand1 = new RelayCommand(Delete1);

        }
        private ObservableCollection<Konsumen> konsumenList;

        public ObservableCollection<Konsumen> KonsumenList
        {
            get { return konsumenList; }
            set { konsumenList = value; OnPropertyChanged("KonsumenList"); }
        }

        private void LoadData()
        {
            KonsumenList = new ObservableCollection<Konsumen>(ObjKonsumenService.GetAll());
        }

        private Konsumen currentKonsumen;
        public Konsumen CurrentKonsumen
        {
            get { return currentKonsumen; }
            set { currentKonsumen = value; OnPropertyChanged("CurrentKonsumen"); }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        private RelayCommand saveCommand1;
        public RelayCommand SaveCommand
        {
            get { return saveCommand1; }
        }

        public void Save1()
        {
            try
            {
                var IsSaved = ObjKonsumenService.Tambah(currentKonsumen);
                LoadData();
                if ((bool)IsSaved)
                    Message = "konsumen Tersimpan";
                else
                    Message = "Gagal tersimpan";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        private RelayCommand searchCommand1;
        public RelayCommand SearchCommand
        {
            get { return searchCommand1; }
        }

        public void Search1()
        {
            try
            {
                var ObjKonsumen = ObjKonsumenService.Search(CurrentKonsumen.Id_konsumen);

                if (ObjKonsumen != null)
                {
                    CurrentKonsumen.Nama_konsumen = ObjKonsumen.Nama_konsumen;
                    CurrentKonsumen.Alamat_konsumen = ObjKonsumen.Alamat_konsumen;
                }
                else
                    Message = "Not Found";
            }
            catch (Exception)
            {

            }
        }

        private RelayCommand updateCommand1;
        public RelayCommand UpdateCommand
        {
            get { return updateCommand1; }
        }

        public void Update1()
        {
            try
            {
                var Isupdate = ObjKonsumenService.Update(CurrentKonsumen);
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

        private RelayCommand deleteCommand1;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand1; }
        }

        public void Delete1()
        {
            try
            {
                var IsDelete = ObjKonsumenService.Hapus(CurrentKonsumen.Id_konsumen);
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
