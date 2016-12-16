using DataAccess.ContextoDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PadocaOnline.Controllers
{
    public class FornadaController : ApiController
    {

        // GET: api/Fornada
        public IEnumerable<FornadaDAL> Get()
        {

            FornadaContextDAL dal = new FornadaContextDAL();
            List<FornadaDAL> lista = dal.listarFornadas();

            return lista;

        }

        // POST: api/Fornada
        public void Post([FromBody]FornadaDAL value)
        {
            FornadaContextDAL dal = new FornadaContextDAL();
            dal.CadastrarFornada(value);
        }

        // GET: api/Fornada/5
        public string Get(int id)
        {
            return "value";
        }

        // PUT: api/Fornada/5
        public void Put(int id, [FromBody]FornadaDAL value)
        {
            FornadaContextDAL dal = new FornadaContextDAL();
            dal.AlterarFornada(value);
        }

        // DELETE: api/Fornada/5
        public void Delete(int id)
        {
        }
    }
}
