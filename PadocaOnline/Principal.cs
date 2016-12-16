
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadocaOnline
{
    public class Principal
    {
        public void Main()
        {
            var db = new Contexto();

            var g1 = new ClienteDAL() { nome = "Fred", endereco = "Rua Iaco", email = "x" };
            var g2 = new ClienteDAL() { nome = "Frederico", endereco = "Rua Combú", email = "x" };

            db.ClienteContexto.Add(g1);
            db.ClienteContexto.Add(g2);

            var p1 = new FornadaDAL() { descricao = "Pão Francês", dataHora = DateTime.Now };
            var p2 = new FornadaDAL() { descricao = "Pão Suíço", dataHora = DateTime.Now };

            db.FornadaContexto.Add(p1);
            db.FornadaContexto.Add(p2);

            db.SaveChanges();

            var dados = from p in db.FornadaContexto
                        select p;

            foreach (var linha in dados)
            {
                Console.WriteLine("{0,-30} data e hora da fornada {1}", linha.descricao, linha.descricao);
            }

        }
    }
}
