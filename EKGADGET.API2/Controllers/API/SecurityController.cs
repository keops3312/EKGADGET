

namespace EKGADGET.API2.Controllers.API
{
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Web.Http;
    using System.Web.Http.Description;
    using EKGADGET.Common.Models;
    using EKGADGET.Domain.Models;
    using Newtonsoft.Json;


    [RoutePrefix("api/Security")]
    public class SecurityController : ApiController
    {



        #region Properties
        private DataContext db;
        #endregion

        #region Constructors
        public SecurityController()
        {
            db = new DataContext();

        }
        #endregion

        #region APIS
        [HttpGet]
        [Route("GetUser")]
        [ResponseType(typeof(Accounts))]
        public IHttpActionResult GetAccount(string username, string password)
        {
            Accounts accounts = db.accounts.Where(p => p.Username.Equals(username)
                                               && p.Password.Equals(password)).First();
            if (accounts == null)
            {
                return NotFound();
            }

            return Ok(accounts);
        }
        #endregion






        #region trashes
        //[HttpGet]
        //[Route("login")]
        //public HttpResponseMessage login(string username, string password)
        //{
        //    try
        //    {

        //        var accounts = db.accounts.Where(p => p.Username.Equals(username)
        //                                       && p.Password.Equals(password)).First();
        //        var response = new HttpResponseMessage(HttpStatusCode.OK);
        //        response.Content = new StringContent(JsonConvert.SerializeObject(accounts));
        //        response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //       return response;


        //    }
        //    catch
        //    {
        //        return new HttpResponseMessage(HttpStatusCode.BadRequest);
        //    }


        //} 
        #endregion
    }
}
