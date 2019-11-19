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
using SearchName.Models;

namespace SearchName.Controllers
{
    public class ClientAddsController : ApiController
    {
        private SearchNameContext db = new SearchNameContext();

        // GET: api/ClientAdds
        public IQueryable<ClientAdd> GetClientAdds()
        {
            return db.ClientAdds;
        }

        // GET: api/ClientAdds/5
        [ResponseType(typeof(ClientAdd))]
        public IHttpActionResult GetClientAdd(int id)
        {
            ClientAdd clientAdd = db.ClientAdds.Find(id);
            if (clientAdd == null)
            {
                return NotFound();
            }

            return Ok(clientAdd);
        }

        // PUT: api/ClientAdds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClientAdd(int id, ClientAdd clientAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientAdd.a_Id)
            {
                return BadRequest();
            }

            db.Entry(clientAdd).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientAddExists(id))
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

        // POST: api/ClientAdds
        [ResponseType(typeof(ClientAdd))]
        public IHttpActionResult PostClientAdd(ClientAdd clientAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClientAdds.Add(clientAdd);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = clientAdd.a_Id }, clientAdd);
        }

        // DELETE: api/ClientAdds/5
        [ResponseType(typeof(ClientAdd))]
        public IHttpActionResult DeleteClientAdd(int id)
        {
            ClientAdd clientAdd = db.ClientAdds.Find(id);
            if (clientAdd == null)
            {
                return NotFound();
            }

            db.ClientAdds.Remove(clientAdd);
            db.SaveChanges();

            return Ok(clientAdd);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientAddExists(int id)
        {
            return db.ClientAdds.Count(e => e.a_Id == id) > 0;
        }
    }
}