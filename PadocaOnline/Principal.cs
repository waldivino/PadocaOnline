
using System;
using System.Collections.Generic;
using System.Linq;

namespace PadocaOnline
{
    public class Principal
    {
        public List<ClienteDAL>  Main()
        {
            var db = new Contexto();

            List<ClienteDAL> lista = new List<ClienteDAL>();
            ClienteDAL dal = null;

            var g1 = new ClienteDAL() { nome = "Fred", endereco = "Rua Iaco", email = "x" };
            var g2 = new ClienteDAL() { nome = "Frederico", endereco = "Rua Combú", email = "x" };

            db.ClienteContexto.Add(g1);
            db.ClienteContexto.Add(g2);

            var p1 = new FornadaDAL() { descricao = "Pão Francês", dataHora = DateTime.Now };
            var p2 = new FornadaDAL() { descricao = "Pão Suíço", dataHora = DateTime.Now };

            db.FornadaContexto.Add(p1);
            db.FornadaContexto.Add(p2);

            db.SaveChanges();

            var dados = from p in db.ClienteContexto
                        select p;


            foreach(var cli in dados)
            {
                dal = new ClienteDAL();
                dal.id = cli.id;
                dal.nome = cli.nome;
                dal.email = cli.email;
                dal.endereco = cli.endereco;

                lista.Add(dal);
            }


            return lista;

        }
    }
}
