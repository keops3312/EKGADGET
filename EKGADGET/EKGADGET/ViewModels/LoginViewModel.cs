

namespace EKGADGET.ViewModels
{
    #region Librerias
    using System.Windows.Input;
    using Xamarin.Forms;
    using Newtonsoft.Json;
    using GalaSoft.MvvmLight.Command;
    using EKGADGET.Common.Models;
    using EKGADGET.Services;
    using EKGADGET.Views; 
    #endregion

    public class LoginViewModel : BaseViewModel
    {



        #region Services
        private ApiService apiService;

        #endregion

        #region attributes
        private string usuario;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        private Accounts accounts;
        #endregion

        #region properties
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
                SetValue(ref this.isEnabled, value);
            }
        }


        public string Usuario
        {
            get
            {
                return this.usuario;
            }

            set
            {
                SetValue(ref this.usuario, value);
            }
        }


        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                SetValue(ref this.password, value);
            }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {

            this.apiService = new ApiService();
            this.IsEnabled = true;
            this.IsRunning = false;
        }
        #endregion

        #region Commands


        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }




        #endregion

        #region Methods
        private async void Login()
        {
           
            if (string.IsNullOrEmpty(Usuario))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                     "Ingresa tu Usuario Por favor",
                                      "Aceptar");


                return;


            }

            if (string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                     "Ingresa tu Contrasela Por favor",
                                      "Aceptar");


                return;
            }

            /*check conection*/

            this.IsRunning = true;
            this.IsEnabled = false;
            var connection = await this.apiService.CheckConnection();


            if (!connection.IsSucces)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                      "Error de Conexion",
                                      "Aceptar");
                //await Application.Current.MainPage.DisplayAlert(Languages.Error,
                //                        connection.Message,
                //                        Languages.Accept);

                this.IsRunning = false;
                this.IsEnabled = true;
                return;

            }

            
            var url = Application.Current.Resources["UrlAPI"].ToString();
            var prefix = Application.Current.Resources["UrlPrefix"].ToString();
            var controller = Application.Current.Resources["UrlUsersController"].ToString();

            var response = await this.apiService.GetUser(url, prefix, $"{controller}", this.usuario, this.password);

            this.IsRunning = true;
            this.IsEnabled = false;


            if (!response.IsSucces)
            {

                await Application.Current.MainPage.DisplayAlert("Error",
                                     "Usuario y/o Contraseña Incorrecto",
                                     "Aceptar");
                this.IsRunning = false;
                this.IsEnabled = true;
                return;
            }


            if (response.IsSucces)
            {
                accounts = JsonConvert.DeserializeObject<Accounts>(response.Result.ToString());
                //var accounts

                this.IsRunning = false;
                this.IsEnabled = true;

                MainViewModel.GetInstance().Sucursales = new SucursalesViewModel();
                //Application.Current.MainPage = new SucursalesPage();//ProductsPage();
                await Application.Current.MainPage.Navigation.PushAsync(new SucursalesPage());
            }
           





          

          

         
          
       
        }


        #endregion


    }
}
