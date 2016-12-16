using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Contexto : DbContext
{
    public Contexto()
        : base("Name=Padoca")
    {

    }
    public DbSet<ClienteDAL> ClienteContexto { get; set; }
    public DbSet<FornadaDAL> FornadaContexto { get; set; }
    public DbSet<UsuarioDAL> UsuarioContexto { get; set; }
}

