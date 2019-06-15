

namespace EKGADGET.Backend.Models.Security
{

    using EKGADGET.Common.Models;
    using System.Linq;
    public class AccountModel
    {
        private LocalDataContext db = new LocalDataContext();
        public Accounts find(string username)
        {
            var account = db.accounts.Where(p => p.Username.Equals(username)).FirstOrDefault();
          
            return account;
        }


        public Accounts login(string username, string password)
        {

            var account = db.accounts.Where(p => p.Username.Equals(username) 
            && p.Password.Equals(password)).FirstOrDefault();

            return account;
        }

        
    }
}