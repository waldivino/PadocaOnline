using DataAccess.ContextoDAL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PadocaOnline.Controllers
{
    public class ClienteController : ApiController
    {
        // GET: api/Cliente
        public IEnumerable<ClienteDAL> Get()
        {

            ClienteContextDAL dal = new ClienteContextDAL();
            List<ClienteDAL> lista = dal.listarClientes();

            return lista;

        }

        // POST: api/Cliente
        public void Post([FromBody]ClienteDAL value)
        {
            ClienteContextDAL dal = new ClienteContextDAL();
            dal.CadastrarCliente(value);
        }

        // GET: api/Cliente/5
        public string Get(int id)
        {
            return "value";
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
