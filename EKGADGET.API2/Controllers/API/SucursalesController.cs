using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EKGADGET.API2.Models;
using EKGADGET.Common.Models;

namespace EKGADGET.API2.Controllers.API
{
    public class SucursalesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Sucursales
        public IQueryable<Sucursales> GetSucursales()
        {
            return db.Sucursales;
        }

        // GET: api/Sucursales/5
        [ResponseType(typeof(Sucursales))]
        public async Task<IHttpActionResult> GetSucursales(int id)
        {
            Sucursales sucursales = await db.Sucursales.FindAsync(id);
            if (sucursales == null)
            {
                return NotFound();
            }

            return Ok(sucursales);
        }

        // PUT: api/Sucursales/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSucursales(int id, Sucursales sucursales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sucursales.localidadId)
            {
                return BadRequest();
            }

            db.Entry(sucursales).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SucursalesExists(id))
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

        // POST: api/Sucursales
        [ResponseType(typeof(Sucursales))]
        public async Task<IHttpActionResult> PostSucursales(Sucursales sucursales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sucursales.Add(sucursales);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sucursales.localidadId }, sucursales);
        }

        // DELETE: api/Sucursales/5
        [ResponseType(typeof(Sucursales))]
        public async Task<IHttpActionResult> DeleteSucursales(int id)
        {
            Sucursales sucursales = await db.Sucursales.FindAsync(id);
            if (sucursales == null)
            {
                return NotFound();
            }

            db.Sucursales.Remove(sucursales);
            await db.SaveChangesAsync();

            return Ok(sucursales);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SucursalesExists(int id)
        {
            return db.Sucursales.Count(e => e.localidadId == id) > 0;
        }
    }
}