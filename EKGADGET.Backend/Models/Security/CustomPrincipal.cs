

namespace EKGADGET.Backend.Models.Security
{

    using EKGADGET.Common.Models;
    using System.Linq;
    using System.Security.Principal;
    public class CustomPrincipal:IPrincipal
    {

        public IIdentity Identity
        {
            get;
            set;
        }

        private Accounts Account;

        public CustomPrincipal(Accounts Account)
        {
            this.Account = Account;
            this.Identity = new GenericIdentity(Account.Username);
        }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => this.Account.Roles.Contains(r));
        }

    }
}