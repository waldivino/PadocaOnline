using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadocaOnline.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<ClienteDAL> ClienteContexto { get; set; }
        public DbSet<FornadaDAL> FornadaContexto { get; set; }
    }
}
