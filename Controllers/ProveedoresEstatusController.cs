using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProyProveedor.Models;

namespace ProyProveedor.Controllers
{
    public class ProveedoresEstatusController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/ProveedoresEstatus
      

       
        // PUT: api/ProveedoresEstatus/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProveedores(int id, string Estatus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Proveedores prov = new Proveedores();

            var validar = db.Proveedores.Where(x => x.Id == id).FirstOrDefault();

            if (validar==null)
            {
                return BadRequest();
            }

            if(Estatus=="Inactivo")
            {
                validar.Estatus = "Inactivo";
            }
            else
            {
                validar.Estatus = "Activo";
            }
          
            db.Entry(validar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProveedoresExists(id))
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

       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProveedoresExists(int id)
        {
            return db.Proveedores.Count(e => e.Id == id) > 0;
        }
    }
}