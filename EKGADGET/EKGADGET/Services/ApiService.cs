

namespace EKGADGET.Services
{
    using EKGADGET.Common.Models;
    using Newtonsoft.Json;
    using Plugin.Connectivity;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    public class ApiService
    {

        /*Prueba la conexion a internet*/
        public async Task<Response> CheckConnection()
        {

            if (!CrossConnectivity.Current.IsConnected)
            {
                return new Response
                {

                    IsSucces = false,
                    Message = "Enciende tu Wifi",//Languages.TurnOnInternet,
            };

            }

            var isReachable = await CrossConnectivity.Current.IsRemoteReachable("google.com");

            if (!isReachable)
            {

                return new Response
                {
                    IsSucces = false,
                    Message = "REvisa tu conexion a internet",// Languages.CheckInternet,

            };
        }

            return new Response
            {
                IsSucces = true,
                Message = "ok",

            };


        }

        /*GET USER*/
        public async Task<Response> GetUser(string urlBase,
            string prefix, string controller, string user,string password)
        {
            try
            {


                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = $"{prefix}{controller}?username={user}&password={password}";//string.Format("{0}{1}", prefix, controller);
                var response = await client.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync();          
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {

                        IsSucces = false,
                        Message = answer,

                    };
                }
               
                var list = JsonConvert.DeserializeObject(answer);
                return new Response
                {

                    IsSucces = true,
                    Message = "Ok",
                    Result = list,

                };

            }
            catch (Exception ex)
            {

                return new Response
                {

                    IsSucces = false,
                    Message = ex.Message,

                };
            }


        }

        /*GET SUCURSALES*/
        public async Task<Response> GetList<T>(string urlBase,
            string prefix, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = $"{prefix}{controller}";//string.Format("{0}{1}", prefix, controller);
                var response = await client.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync();
                //si falla
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {

                        IsSucces = false,
                        Message = answer,

                    };
                }
                //si es exitoso
                var list = JsonConvert.DeserializeObject<List<T>>(answer);
                return new Response
                {

                    IsSucces = true,
                    Message = "Ok",
                    Result = list,

                };

            }
            catch (Exception ex)
            {

                return new Response
                {

                    IsSucces = false,
                    Message = ex.Message,

                };
            }


        }

        /*PUT SUCURSALES*/

        ///*Metodo Put Object*/
        public async Task<Response> Put<T>(string urlBase,
            string prefix, string controller, T model, int id)
        {
            try
            {
                var request = JsonConvert.SerializeObject(model);
                var content = new StringContent(request, Encoding.UTF8, "application/json");



                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = $"{prefix}{controller}/{id}";//string.Format("{0}{1}", prefix, controller);
                var response = await client.PutAsync(url, content);
                var answer = await response.Content.ReadAsStringAsync();
                //si falla
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {

                        IsSucces = false,
                        Message = answer,

                    };
                }
                //si es exitoso
                var obj = JsonConvert.DeserializeObject<T>(answer);
                return new Response
                {

                    IsSucces = true,
                    Message = "Ok",
                    Result = obj,

                };

            }
            catch (Exception ex)
            {

                return new Response
                {

                    IsSucces = false,
                    Message = ex.Message,

                };
            }


        }




        #region MyRegion
        ///*Metodo Get List*/

        //public async Task<Response> GetList<T>(string urlBase,
        //    string prefix, string controller)
        //{
        //    try
        //    {
        //        var client = new HttpClient();
        //        client.BaseAddress = new Uri(urlBase);
        //        var url = $"{prefix}{controller}";//string.Format("{0}{1}", prefix, controller);
        //        var response = await client.GetAsync(url);
        //        var answer = await response.Content.ReadAsStringAsync();
        //        //si falla
        //        if (!response.IsSuccessStatusCode)
        //        {
        //            return new Response
        //            {

        //                IsSucces = false,
        //                Message = answer,

        //            };
        //        }
        //        //si es exitoso
        //        var list = JsonConvert.DeserializeObject<List<T>>(answer);
        //        return new Response
        //        {

        //            IsSucces = true,
        //            Message = "Ok",
        //            Result = list,

        //        };

        //    }
        //    catch (Exception ex)
        //    {

        //        return new Response
        //        {

        //            IsSucces = false,
        //            Message = ex.Message,

        //        };
        //    }


        //}



        ///*Metodo Add Object*/
        //public async Task<Response> Post<T>(string urlBase,
        //    string prefix, string controller, T model)
        //{
        //    try
        //    {
        //        var request = JsonConvert.SerializeObject(model);
        //        var content = new StringContent(request, Encoding.UTF8, "application/json");



        //        var client = new HttpClient();
        //        client.BaseAddress = new Uri(urlBase);
        //        var url = $"{prefix}{controller}";//string.Format("{0}{1}", prefix, controller);
        //        var response = await client.PostAsync(url, content);
        //        var answer = await response.Content.ReadAsStringAsync();
        //        //si falla
        //        if (!response.IsSuccessStatusCode)
        //        {
        //            return new Response
        //            {

        //                IsSucces = false,
        //                Message = answer,

        //            };
        //        }
        //        //si es exitoso
        //        var obj = JsonConvert.DeserializeObject<T>(answer);
        //        return new Response
        //        {

        //            IsSucces = true,
        //            Message = "Ok",
        //            Result = obj,

        //        };

        //    }
        //    catch (Exception ex)
        //    {

        //        return new Response
        //        {

        //            IsSucces = false,
        //            Message = ex.Message,

        //        };
        //    }


        //}


        ///*Metodo Delete Object*/
        //public async Task<Response> Delete(string urlBase,
        //    string prefix, string controller, int id)
        //{
        //    try
        //    {


        //        var client = new HttpClient();
        //        client.BaseAddress = new Uri(urlBase);
        //        var url = $"{prefix}{controller}/{id}";//string.Format("{0}{1}", prefix, controller);
        //        var response = await client.DeleteAsync(url);
        //        var answer = await response.Content.ReadAsStringAsync();
        //        //si falla
        //        if (!response.IsSuccessStatusCode)
        //        {
        //            return new Response
        //            {

        //                IsSucces = false,
        //                Message = answer,

        //            };
        //        }
        //        //si es exitoso

        //        return new Response
        //        {

        //            IsSucces = true,

        //        };

        //    }
        //    catch (Exception ex)
        //    {

        //        return new Response
        //        {

        //            IsSucces = false,
        //            Message = ex.Message,

        //        };
        //    }


        //}



        #endregion


    }
}
