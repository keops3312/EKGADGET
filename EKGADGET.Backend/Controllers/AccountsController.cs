

namespace EKGADGET.Backend.Controllers
{

    using EKGADGET.Backend.Models.Security;
    using System;
    using System.Web.Mvc;

    public class AccountsController : Controller
    {


        /*Login*/
        public ActionResult Login()
        {
            
            return View();
        }


        /*Post of Login*/
        [HttpPost]
        public ActionResult Login(AccountViewModel accountViewModel)
        {

            bool isValid = checkUser(accountViewModel.Account.Username
                             , accountViewModel.Account.Password);


            if (isValid)
            {
                SimpleSessionPersister.Username = accountViewModel.Account.Username;
            }

            var obj = new
            {
                valid = isValid
            };
            return Json(obj);


        }

        private bool checkUser(string username, string password)
        {
            AccountModel accountModel = new AccountModel();
            if (accountModel.login(username, password) == null)
            {

                return false;
            }


            return true;


        }


        /*Log Out of Login*/
        public ActionResult Logout()
        {
            SimpleSessionPersister.Username = string.Empty;
            return RedirectToAction("Login");
        }


        #region Examples
        //public ActionResult Login(AccountViewModel accountViewModel)
        //{
        //    AccountModel accountModel = new AccountModel();
        //    if (accountModel.login(accountViewModel.Account.Username, accountViewModel.Account.Password) == null)
        //    {


        //        var result = new JsonResult
        //        {

        //            Data = new { response = false }
        //        };

        //        return result;

        //    }


        //    SimpleSessionPersister.Username = accountViewModel.Account.Username;

        //    var response = new JsonResult
        //    {

        //        Data = new { response = true }
        //    };

        //    return response;

        //}



        #endregion


    }
}