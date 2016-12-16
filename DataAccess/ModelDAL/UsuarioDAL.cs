using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
