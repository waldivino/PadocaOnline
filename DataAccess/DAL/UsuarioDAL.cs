using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    [Table("Usuario")]
    public class UsuarioDAL
    {
        public int id { get; set; }
        [Required]
        public String login { get; set; }
        [Required]
        public String senha { get; set; }
    }
}
