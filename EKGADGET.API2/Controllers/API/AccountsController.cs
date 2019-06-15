

namespace EKGADGET.API2.Controllers.API
{

    #region Libraries
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Description;
    using EKGADGET.Common.Models;
    using EKGADGET.Domain.Models; 
    #endregion


   
    public class AccountsController : ApiController
    {

        #region Properties
        private DataContext db;
        #endregion

        #region Constructors
        public AccountsController()
        {
            db = new DataContext();

        }
        #endregion


     

        // GET: api/Accounts
        public IQueryable<Accounts> Getaccounts()
        {
            return db.accounts;
        }

        // GET: api/Accounts/5
        [ResponseType(typeof(Accounts))]
        public async Task<IHttpActionResult> GetAccounts(int id)
        {
            Accounts accounts = await db.accounts.FindAsync(id);
            if (accounts == null)
            {
                return NotFound();
            }

            return Ok(accounts);
        }

        // PUT: api/Accounts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAccounts(int id, Accounts accounts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != accounts.IdAccounts)
            {
                return BadRequest();
            }

            db.Entry(accounts).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Accounts
        [ResponseType(typeof(Accounts))]
        public async Task<IHttpActionResult> PostAccounts(Accounts accounts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.accounts.Add(accounts);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = accounts.IdAccounts }, accounts);
        }

        // DELETE: api/Accounts/5
        [ResponseType(typeof(Accounts))]
        public async Task<IHttpActionResult> DeleteAccounts(int id)
        {
            Accounts accounts = await db.accounts.FindAsync(id);
            if (accounts == null)
            {
                return NotFound();
            }

            db.accounts.Remove(accounts);
            await db.SaveChangesAsync();

            return Ok(accounts);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AccountsExists(int id)
        {
            return db.accounts.Count(e => e.IdAccounts == id) > 0;
        }
    }
}