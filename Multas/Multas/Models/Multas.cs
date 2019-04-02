using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Multas
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public Decimal ValorMulta { get; set; }

        public string Descricao { get; set; }
    }
}