using Lab3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.ViewModel
{
    public class TabbedPageViewModel : INotifyPropertyChanged
    {
        #region Singleton
        private static TabbedPageViewModel instance = null;

        private TabbedPageViewModel()
        {
            InitClassAsync();

        }



        public static TabbedPageViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new TabbedPageViewModel();
            }
            return instance;
        }

        public static void DeleteInstance()
        {
            if (instance != null)
            {
                instance = null;
            }
        }
        #endregion
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) // if there is any subscribers 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region Propiedades
        private ObservableCollection<CdModel> _lstCd = new ObservableCollection<CdModel>();

        public ObservableCollection<CdModel> lstCd
        {
            get
            {
                return _lstCd;
            }
            set
            {
                _lstCd = value;
                OnPropertyChanged("lstCd");
            }
        }
        #endregion

        #region Metodos
        private async Task InitClassAsync()
        {
            lstCd = await CdModel.LoadXMLData();
        }
        #endregion
       



    }
}
