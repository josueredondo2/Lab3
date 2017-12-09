using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.ViewModel
{
    class LoginViewModel : INotifyChanged
    {
        #region Singleton
        private static TabbedPageViewModel instance = null;

        private LoginViewModel()
        {
            IniciarClase();

        }

        private static void IniciarClase()
        {
            InitClassAsync();
        }

        public static LoginViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginViewModel();
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

        #region Propiedades
        private string _IdUsuario;

        public string IdUsuario
        {
            get => _IdUsuario;
            set
            {
                _IdUsuario = value;
                OnPropertyChanged("IdUsuario");
            }
        }

        private string _Pass;

        public string Pass
        {
            get => _Pass;
            set
            {
                _Pass = value;
                OnPropertyChanged("Pass");
            }
        }


    }
}
