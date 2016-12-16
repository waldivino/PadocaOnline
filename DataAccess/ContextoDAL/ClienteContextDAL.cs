using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ContextoDAL
{
    public class ClienteContextDAL
    {

        #region - Listar Clientes da Padoca On line
        public List<ClienteDAL> listarClientes()
        {
            List<ClienteDAL> lista = new List<ClienteDAL>();
            ClienteDAL dal = null;

            try
            {
                using (var db = new Contexto())
                {
                    var dados = from p in db.ClienteContexto
                                select p;

                    foreach (var cli in dados)
                    {
                        dal = new ClienteDAL();
                        dal.id = cli.id;
                        dal.nome = cli.nome;
                        dal.email = cli.email;
                        dal.endereco = cli.endereco;

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

        #region - Cadastrar Cliente da Padoca On line
        public bool CadastrarCliente(ClienteDAL cliente)
        {
            try
            {
                using (var db = new Contexto())
                {
                    db.ClienteContexto.Add(cliente);

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

        #region - Alterar Cliente da Padoca On line
        public bool AlterarCliente(ClienteDAL cliente)
        {
            try
            {
                using (var db = new Contexto())
                {
                    db.Entry(cliente).State = EntityState.Modified;
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
