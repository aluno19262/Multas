using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Agentes
    {
        [Key]
        public int ID { get; set; }
        [Required (ErrorMessage ="O Nome é de preenchimento obrigatório.")]
        [StringLength(40)]
        [RegularExpression("", ErrorMessage ="só são aceites palavras começadas por letra Maiscula, separadas por um espaço em branco")]
        public string Nome { get; set; }
        [Required (ErrorMessage = "A Esquadra é de preenchimento obrigatório.")]
        [StringLength(30)]
        public string Esquadra { get; set; }
        //[Required (ErrorMessage = "A Fotografia é de preenchimento obrigatório.")]
        [StringLength(20)]
        public string Fotografia { get; set; }

        //lista das multas associadas ao agente
        public ICollection<Multas> ListaDeMultas { get; set; }
    }
}