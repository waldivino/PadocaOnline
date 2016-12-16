using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadocaOnline.DAL
{
    [Table("Fornada")]
    public class FornadaDAL
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Descrição não pode ser branco.")]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Data e hora não pode ser branco.")]
        public DateTime dataHora { get; set; }
    }
}
