
namespace EKGADGET.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using EKGADGET.Common.Models;
    using EKGADGET.Services;
    using EKGADGET.Views;
    using System.Windows.Input;
    using Xamarin.Forms;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    public class SucursalesItemViewModel:Sucursales
    {

        #region Services
        private ApiService apiService;

        #endregion

        #region Commands


        public ICommand EditSucursalCommand
        {

            get
            {
                return new RelayCommand(EditSucursal);
            }
        }




        #endregion

        #region Constructors
        public SucursalesItemViewModel()
        {
            this.apiService = new ApiService();
        }
        #endregion

        #region Methods

        private void EditSucursal()
        {

          
           


            MainViewModel.GetInstance().EditSucursal = new EditSucursalViewModel(this);
            Application.Current.MainPage.Navigation.PushAsync(new EditSucursalPage());
           // Application.Current.MainPage = new EditSucursalPage();//ProductsPage();
            //await Application.Current.MainPage.popo(new EditSucursalPage());
            //await Application.Current.MainPage.pus(new EditSucursalPage());
            //await Application.Current.MainPage.Navigation.pa.PushAsync(new EditSucursalPage());
        }

    
        #endregion
    }
}
