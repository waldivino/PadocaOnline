using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    [Table("Cliente")]
    public class ClienteDAL
    {
        public Int32 id { get; set; }
        [Required(ErrorMessage = "Nome não pode ser branco.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Email não pode ser branco.")]
        public string email { get; set; }
        [Required(ErrorMessage = "Endereço não pode ser branco.")]
        public string endereco { get; set; }
    }

