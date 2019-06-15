
namespace EKGADGET.ViewModels
{
    using EKGADGET.Common.Models;
    using EKGADGET.Services;
    using GalaSoft.MvvmLight.Command;
    using System.Linq;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class EditSucursalViewModel:BaseViewModel
    {

        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private Sucursales sucursal;

        private bool isRunning;

        private bool isEnabled;

       
        #endregion

        #region Constructors
        public EditSucursalViewModel(Sucursales sucursales)
        {
            this.sucursal = sucursales;
            this.apiService = new ApiService();
            this.IsEnabled = true;
         
        }
        #endregion

        #region Properties
        public Sucursales Sucursal
        {
            get
            {
                return this.sucursal;
            }
            set
            {
                SetValue(ref this.sucursal, value);
            }
        }

        public bool IsRunning
        {
            get
            {
                return this.isRunning;
            }
            set
            {
                SetValue(ref this.isRunning, value);
            }
        }

        public bool IsEnabled
        {
            get
            {
                return this.isEnabled;
            }
            set
            {
                this.SetValue(ref this.isEnabled, value);
            }
        }

 
        #endregion


        #region Commands

     
        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(Save);
            }
        }

     

        #endregion

        #region Methods
        private async void Save()
        {
            if (this.Sucursal.diasOperaMes<0)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                       "Ingrese dias de Operacion",
                                       "Aceptar");


                return;
            }

            if (string.IsNullOrEmpty(this.Sucursal.objetivoMes))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                       "Ingrese Objetivo Mensual",
                                       "Aceptar");


                return;
            }

            if (string.IsNullOrEmpty(this.Sucursal.ObjetivoSemanal))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                       "Ingrese Objetivo Semanal",
                                       "Aceptar");


                return;
            }

            if (string.IsNullOrEmpty(this.Sucursal.ObjetivoSemanalJefe))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                       "Ingrese Objetivo Semanal Jefe",
                                       "Aceptar");


                return;
            }



            /*check Connection*/
            this.IsRunning = true;
            this.IsEnabled = false;

            var connection = await this.apiService.CheckConnection();


            if (!connection.IsSucces)
            {

                await Application.Current.MainPage.DisplayAlert("Error",
                                        connection.Message,
                                        "Aceptar");


                this.IsRunning = false;
                this.IsEnabled = true;
                return;

            }


            var url = Application.Current.Resources["UrlAPI"].ToString();
            var prefix = Application.Current.Resources["UrlPrefix"].ToString();
            var controller = Application.Current.Resources["UrlSucursalesController"].ToString();


            var response = await this.apiService.Put(
                url,
               prefix,
               controller, this.sucursal, this.sucursal.localidadId);



            if (!response.IsSucces)
            {
                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert("Error",
                                         response.Message,
                                         "Aceptar");
                return;

            }


            var newSucursal = (Sucursales)response.Result; /*locasteamos*/
            var sucursalViewModel = SucursalesViewModel.GetInstance();/*de esta manera se actualiza la lista de productos cuandose agraga uno nuevo*/

            var oldProduct = sucursalViewModel.MySucursales.Where(p => p.localidadId == this.sucursal.localidadId).FirstOrDefault();

            if (oldProduct != null)
            {

                sucursalViewModel.MySucursales.Remove(oldProduct);
            }



            sucursalViewModel.MySucursales.Add(newSucursal);
            sucursalViewModel.RefreshList();


            this.IsRunning = false;
            this.IsEnabled = true;

            await Application.Current.MainPage.Navigation.PopAsync();/*para desapilar */
            //await App.Navigator.PopAsync();


        }

      


        #endregion
    }
}
