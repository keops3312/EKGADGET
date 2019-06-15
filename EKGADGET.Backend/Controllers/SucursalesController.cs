

namespace EKGADGET.Backend.Controllers
{
    using System;
    #region Libraries
    using System.Data.Entity;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using EKGADGET.Backend.Models;
    using EKGADGET.Backend.Models.Security;
    using EKGADGET.Common.Models;

    #endregion

    public class SucursalesController : Controller
    {
        #region Properties
        private LocalDataContext db;
        #endregion

        #region Constructors
        public SucursalesController()
        {
            db = new LocalDataContext();
        }

        #endregion

        #region Views
        // GET: Sucursales

        [MyAuthorizeAttribute(Roles = "ADMIN")]
        public async Task<ActionResult> Index()
        {
            return View(await db.sucursales.ToListAsync());
        }

        // GET: Sucursales/Details/5
        [MyAuthorizeAttribute(Roles = "ADMIN")]
        [HttpGet]
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            var sucursales = await db.sucursales.FindAsync(int.Parse(id));


            if (sucursales == null)
            {
                return HttpNotFound();
            }
            return PartialView(sucursales);
        }

        // GET: Sucursales/Edit/5
        [MyAuthorizeAttribute(Roles = "ADMIN")]
        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            Sucursales sucursales = await db.sucursales.FindAsync(int.Parse(id));
            if (sucursales == null)
            {
                return HttpNotFound();
            }
            return PartialView(sucursales);
        }

        #endregion

        #region Methods POST
        // POST: Sucursales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyAuthorizeAttribute(Roles = "ADMIN")]
        public async Task<ActionResult> Edit(Sucursales view)
        {

            if (view == null)
            {
                return RedirectToAction("Index");
            }

            if (!ModelState.IsValid)
            {
              
              return RedirectToAction("Index");
            }


            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {



                    var sucursales = await db.sucursales.FindAsync(view.localidadId);
                    sucursales.localidadId = view.localidadId;
                    sucursales.objetivoMes = view.objetivoMes;
                    sucursales.ObjetivoSemanal = view.ObjetivoSemanal;
                    sucursales.ObjetivoSemanalJefe = view.ObjetivoSemanalJefe;
                    sucursales.diasOperaMes = view.diasOperaMes;

                   
                    db.Entry(sucursales).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                    transaction.Commit();
                    return RedirectToAction("Index");

                }
                catch (Exception)
                {

                    transaction.Rollback();
                    ViewBag.ResultMessage = "0";
                    return RedirectToAction("Index");
                }
            }

          
          
      

         
        }



        #endregion

        #region Methods
        private Sucursales ToSucursalView(Sucursales View)
        {
            return new Sucursales
            {
                localidadId = View.localidadId,
                nombreSucursal = View.nombreSucursal,
                localidad = View.localidad,
                fechaAlta = View.fechaAlta,
                concepto = View.concepto,
                encargado = View.encargado,
                direccion = View.direccion,
                telefono = View.telefono,
                calle = View.calle,
                colonia = View.colonia,
                noint = View.noint,
                noext = View.noext,
                cp = View.cp,
                ciudad = View.ciudad,
                estado = View.estado,
                pais = View.pais,
                email = View.email,
                marca = View.marca,
                empresa = View.empresa,
                xxx = View.xxx,
                bd = View.bd,
                central = View.central,
                impresora = View.impresora,
                TonerEnMano = View.TonerEnMano,
                TonerXrecibir = View.TonerXrecibir,
                TonerEnTransito = View.TonerEnTransito,



            };

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion



        #region MyRegion
        // GET: Sucursales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "localidadId,localidad,nombreSucursal,fechaAlta,concepto,encargado,direccion,telefono,calle,colonia,noint,noext,cp,ciudad,estado,pais,email,marca,empresa,xxx,objetivoMes,bd,central,impresora,TonerEnMano,TonerXrecibir,TonerEnTransito,diasOperaMes,ObjetivoSemanal,ObjetivoSemanalJefe")] Sucursales sucursales)
        {
            if (ModelState.IsValid)
            {
                db.sucursales.Add(sucursales);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sucursales);
        }


        #endregion
     
    }
}
