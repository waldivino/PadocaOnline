using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ContextoDAL
{
    public class FornadaContextDAL
    {
        #region - Listar Fornadas da Padoca On line
        public List<FornadaDAL> listarFornadas()
        {
            List<FornadaDAL> lista = new List<FornadaDAL>();
            FornadaDAL dal = null;

            try
            {
                using (var db = new Contexto())
                {
                    var dados = from p in db.FornadaContexto
                                select p;

                    foreach (var obj in dados)
                    {
                        dal = new FornadaDAL();
                        dal.id = obj.id;
                        dal.descricao = obj.descricao;
                        dal.dataHora = obj.dataHora;

                        lista.Add(dal);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;

        }
        #endregion


        #region - Cadastrar Fornadas da Padoca On line
        public bool CadastrarFornada(FornadaDAL fornada)
        {
            try
            {
                using (var db = new Contexto())
                {
                    db.FornadaContexto.Add(fornada);

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;

        }
        #endregion


        #region - Alterar Fornadas da Padoca On line
        public bool AlterarFornada(FornadaDAL fornada)
        {
            try
            {
                using (var db = new Contexto())
                {
                    db.Entry(fornada).State = EntityState.Modified;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;

        }
        #endregion


    }
}
