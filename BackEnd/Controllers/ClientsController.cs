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
using System.Web.Routing;

namespace SearchName.Controllers
{
    public class ClientsController : ApiController
    {
        private SearchNameContext db = new SearchNameContext();

        // GET: api/Clients

            [Route("searchClient/")]
        public IQueryable<Client> GetClients()
        {
            int records = 5;
            return db.Clients.Include(s=>s.clientAdd).Take(records);
        }

        // GET: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult GetClient(int id)
        {
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }



        [Route("searchClient/{name}/")]
        [ResponseType(typeof(Client))]
        public IHttpActionResult GetClientByOnlyname(string name)
        {
            //IList<Client> clientresult = null;
            var clientresult = db.Clients.Include(c_details => c_details.clientAdd).Where(v => (v.firstName==name) || (v.lastName==name)).ToList();
            if (clientresult == null)
            {
                return NotFound();
            }
            return Ok(clientresult);

        }

        [Route("searchClient/{fname}/{lname}/")]
        [ResponseType(typeof(Client))]

        public IHttpActionResult GetClientByFnameLname(string fname,string lname)
        {
            //IList<Client> clientresult = null;
            var clientresult = db.Clients.Include(c_details => c_details.clientAdd).Where(v => (v.firstName==fname) && (v.lastName==lname)).ToList();
            if (clientresult == null)
            {
                return NotFound();
            }
            return Ok(clientresult);
        }




        // PUT: api/Clients/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClient(int id, Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != client.clientId)
            {
                return BadRequest();
            }

            db.Entry(client).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/Clients
        [ResponseType(typeof(Client))]
        public IHttpActionResult PostClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Clients.Add(client);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = client.clientId }, client);
        }

        // DELETE: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult DeleteClient(int id)
        {
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            db.Clients.Remove(client);
            db.SaveChanges();

            return Ok(client);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientExists(int id)
        {
            return db.Clients.Count(e => e.clientId == id) > 0;
        }

       /* public IHttpActionResult GetClientData(string name)
        {
            IList<Client> clients = null;
            {
                clients = db.Clients.Include(x => x.clientAdd).Where(s => s.firstName == name || s.lastName ==name).ToList();
                if(clients==null)
                {
                    return NotFound();
                }
                 return Ok(clients);
            }
        }*/

    }
}