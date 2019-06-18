using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EKGADGET.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        #region Properties
       //public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region ViewModels

        public LoginViewModel Login
        {
            get;
            set;

        }

        public SucursalesViewModel Sucursales
        {
            get;
            set;

        }

        public EditSucursalViewModel EditSucursal
        {
            get;
            set;

        }


        #endregion

        #region Constructor
        public MainViewModel()
        {

            instance = this;       
            this.Login = new LoginViewModel();

        }
        #endregion

        #region Clase singleton para cambiar de viewmodels

        private static MainViewModel instance;



        public static MainViewModel GetInstance()
        {

            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }



        #endregion

    
    

    }
}
