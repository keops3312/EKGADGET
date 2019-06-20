

namespace EKGADGET.ViewModels
{
    using System;
    #region Libraries
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using EKGADGET.Common.Models;
    using EKGADGET.Services;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms; 
    #endregion

    public class SucursalesViewModel:BaseViewModel
    {

        #region Services
        private ApiService apiService;
        #endregion

        #region attributes
        private bool isRefreshing;
        private ObservableCollection<SucursalesItemViewModel> sucursales;
        private string fecha;
        #endregion

        #region Properties      
        public List<Sucursales> MySucursales { get; set; }/*to edit*/
        public ObservableCollection<SucursalesItemViewModel> Sucursales
        {
            get
            {
                return this.sucursales;
            }
            set
            {
                SetValue(ref this.sucursales, value);
            }
        }
        public bool IsRefreshing
        {
            get
            {
                return this.isRefreshing;
            }
            set
            {
                SetValue(ref this.isRefreshing, value);
            }
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

        #endregion

        #region Constructor 
        public SucursalesViewModel()
        {
            instance = this;//aqui le digo que la instancia es el form actual
            this.apiService = new ApiService();
            DateTime operacion = DateTime.Now;
            Fecha = $"Objetivos correspondientes al mes de:{operacion.ToString("MMMM yyyy")}";
            LoadSucursales();
        }

        #endregion

        #region Methods
      
        private async void LoadSucursales()
        {
            this.IsRefreshing = true;
           

            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSucces)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                     "Fallo la Conexion",
                                      "Aceptar");

                return;
            }



            var url = Application.Current.Resources["UrlAPI"].ToString();
            var prefix = Application.Current.Resources["UrlPrefix"].ToString();
            var controller = Application.Current.Resources["UrlSucursalesController"].ToString();

            var response = await this.apiService.GetList<Sucursales>(
             url,
             prefix,
             controller);

            if (!response.IsSucces)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                                    response.Message,
                                     "Aceptar");
                return;

            }

            this.MySucursales = (List<Sucursales>)response.Result;

            this.IsRefreshing = false;
            this.RefreshList();
           
            return;

            
        }

     
        public void RefreshList()
        {
            var myListSucursalesItemViewModel = MySucursales.Select(p => new SucursalesItemViewModel
            {
                 
      
                ObjetivoSemanalJefe = p.ObjetivoSemanalJefe,
                ObjetivoSemanal = p.ObjetivoSemanal,
                diasOperaMes = p.diasOperaMes,
                TonerEnTransito = p.TonerEnTransito,
                TonerXrecibir = p.TonerXrecibir,
                TonerEnMano = p.TonerEnMano,
                impresora = p.impresora,
                central = p.central,
                bd = p.bd,
                objetivoMes = p.objetivoMes,
                xxx = p.xxx,
                empresa = p.empresa,
                marca = p.marca.Replace(" ",""),
                email = p.email,
                pais = p.pais,
                estado = p.estado,
                localidadId=p.localidadId,
                localidad = p.localidad,
                nombreSucursal = p.nombreSucursal,
                fechaAlta = p.fechaAlta,
                concepto = p.concepto,
                encargado = p.encargado,
                direccion = p.direccion,
                telefono = p.telefono,
                calle = p.calle,
                colonia = p.colonia,
                noint = p.noint,
                noext=p.noext,
                cp = p.cp,
                ciudad = p.ciudad,
              


               

         });

          
           
            this.Sucursales = new ObservableCollection<SucursalesItemViewModel>(
               myListSucursalesItemViewModel.OrderBy(p => p.marca));
        }


     
        #endregion

        #region ICommands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadSucursales);
            }
        }

      

        #endregion

        #region Singleton (para llevar valores entre viewmodels)
        private static SucursalesViewModel instance;
        public static SucursalesViewModel GetInstance()
        {

            if (instance == null)
            {
                return new SucursalesViewModel();
            }

            return instance;

        }

        #endregion



    

    }
}
