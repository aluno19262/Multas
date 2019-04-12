using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Multas
    {
        public int ID { get; set; }

        public string Infracao { get; set; }

        public string LocalDaMulta { get; set; }

        public decimal ValorMulta { get; set; }

        public DateTime DataDaMulta { get; set; }

        //*************************************
        //criação das chaves forasteiras (FKs)

        //FK para a tabela dos agentes
        [ForeignKey("Agente")]
        public int AgentesFK {get; set; }
        public Agentes Agente { get; set; }

        //FK para a tabela dos condutores
        [ForeignKey("Condutor")]
        public int CondutoresFK { get; set; }
        public Condutores Condutor { get; set; }

        //FK para a tabela das Viaturas
        [ForeignKey("Viatura")]
        public int ViaturasFK { get; set; }
        public Viaturas Viatura { get; set; }
    }
}