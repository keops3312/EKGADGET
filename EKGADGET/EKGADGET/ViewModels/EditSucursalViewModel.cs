
namespace EKGADGET.ViewModels
{
    
    using EKGADGET.Common.Models;
    using EKGADGET.Services;
    using GalaSoft.MvvmLight.Command;
    using Newtonsoft.Json;
    using System;
    using System.Globalization;
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

        private string diasOperacionText;
        private decimal objetivoMensualText;
        private decimal objetivoSemanalText;
        private decimal objetivoJefeText;
        private string fecha;

        #endregion

        #region Constructors
        public EditSucursalViewModel(Sucursales sucursales)
        {
            this.sucursal = sucursales;
          
            this.apiService = new ApiService();
            this.IsEnabled = true;
            DateTime operacion = DateTime.Now;
            Fecha = $"Objetivos correspondientes al mes de: {operacion.ToString("MMMM yyyy")}";



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



        public string DiasOperacionText
        {
            get
            {
                return this.diasOperacionText;
            }
            set
            {
                this.SetValue(ref this.diasOperacionText, value);
            }
        }

        public decimal ObjetivoMensualText
        {

            get { return objetivoMensualText; }
            set
            {
                if (objetivoMensualText != value)
                {
                    objetivoMensualText = value;
                    OnPropertyChanged("ObjetivoMensualText");
                }
            }
            //get
            //{

            //    return this.objetivoMensualText;

            //}
            //set
            //{

            //    this.SetValue(ref this.objetivoMensualText, value);
            //}
        }


        public decimal ObjetivoSemanalText
        {

            get { return objetivoSemanalText; }
            set
            {
                if (objetivoSemanalText != value)
                {
                    objetivoSemanalText = value;
                    OnPropertyChanged("ObjetivoSemanalText");
                }
            }
            //get
            //{
            //    return this.objetivoSemanalText;
            //}
            //set
            //{
            //    this.SetValue(ref this.objetivoSemanalText, value);
            //}
        }

        public decimal ObjetivoJefeText
        {
            get { return objetivoJefeText; }
            set
            {
                if (objetivoJefeText != value)
                {
                    objetivoJefeText = value;
                    OnPropertyChanged("ObjetivoJefeText");
                }
            }
            //get
            //{
            //    return this.objetivoJefeText;
            //}
            //set
            //{
            //    this.SetValue(ref this.objetivoJefeText, value);
            //}
        }

        public string Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                SetValue(ref this.fecha, value);
            }
        }

        private decimal someProperty;

     
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

            if (string.IsNullOrEmpty(ObjetivoMensualText.ToString()))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                    "NO puede quedar OBJETIVO MENSUAL en Blanco!",
                                    "Aceptar");
                return;
            }


            if (objetivoMensualText == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                   "Ingrese Objetivo Mensual",
                                   "Aceptar");
                return;
            }



            if (string.IsNullOrEmpty(objetivoSemanalText.ToString()))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                    "NO puede quedar OBJETIVO SEMANAL en Blanco!",
                                    "Aceptar");
                return;
            }


            if (objetivoSemanalText == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                   "Ingrese Objetivo Semanal",
                                   "Aceptar");
                return;
            }



            if (string.IsNullOrEmpty(objetivoJefeText.ToString()))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                    "NO puede quedar OBJETIVO SEMANAL JEFE en Blanco!",
                                    "Aceptar");
                return;
            }


            if (objetivoJefeText == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                   "Ingrese Objetivo Semanal Jefe",
                                   "Aceptar");
                return;
            }



            if (string.IsNullOrEmpty(diasOperacionText))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                    "NO puede quedar DIAS OPERACION en Blanco!",
                                    "Aceptar");
                return;
            }


            if (decimal.Parse(diasOperacionText) == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                   "Ingrese Dias de Operacion",
                                   "Aceptar");
                return;
            }

           // decimal isInt = decimal.Parse(diasOperacionText) % 1;
            //isInt = ;
            if (decimal.Parse(diasOperacionText) % 1 != 0)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                 "NO se acepan numeros decimales en dia de Mes Operativo!",
                                 "Aceptar");
                return;
            }





            int diasEnMEs = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            if (decimal.Parse(diasOperacionText) > diasEnMEs )
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                  "Los Dias de Operacion no puede ser MAYOR a los dias del Mes!",
                                  "Aceptar");
                return;
            }


            var res = await Application.Current.MainPage.DisplayAlert("Resumen:",
                                "Dias de operacion: " + diasOperacionText + "\n" +
                                 "Objetivo Mensual: " + objetivoMensualText.ToString("C2") + "\n" +
                                 "Objetivo Jefe Sucursal: " + objetivoJefeText.ToString("C2") + "\n" +
                                 "Objetivo Semanal: " + objetivoSemanalText.ToString("C2") + "\n" +
                                 "¿Desea continuar?",
                                 "Aceptar", "Cancelar");


            if (res == true)
            {
                ///*check Connection*/
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



                this.sucursal.diasOperaMes = int.Parse(diasOperacionText);
                this.sucursal.objetivoMes = objetivoMensualText;
                this.sucursal.ObjetivoSemanal = objetivoSemanalText;
                this.sucursal.ObjetivoSemanalJefe = objetivoJefeText;

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

                //  var newSucursal = JsonConvert.DeserializeObject<Sucursales>(response.Result.ToString());

                //var newSucursal = (Sucursales)response.Result; /*locasteamos*/
                var sucursalViewModel = SucursalesViewModel.GetInstance();/*de esta manera se actualiza la lista de productos cuandose agraga uno nuevo*/

                var oldSucursal = sucursalViewModel.MySucursales.Where(p => p.localidadId == this.sucursal.localidadId).FirstOrDefault();

                if (oldSucursal != null)
                {

                    sucursalViewModel.MySucursales.Remove(oldSucursal);
                }



                sucursalViewModel.MySucursales.Add(this.sucursal);
                sucursalViewModel.RefreshList();


                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.Navigation.PopAsync();
                //ProductsPage();
                // await Application.Current.MainPage.Navigation.PopAsync();/*para desapilar */
                //await App.Navigator.PopAsync();
            }

            return;






        }




        #endregion

        
      

    }
}
