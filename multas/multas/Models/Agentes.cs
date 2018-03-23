using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class Agentes
    {

        public Agentes() {
            ListaDeMultas = new HashSet<Multas>();

        }

        [Key]
        public int ID { get; set; } //chave primaria

        public string Nome { get; set; }

        public string Fotografia { get; set; }
            
        public string Esquadra { get; set; }

        //Complementar a informação sobre o relacionamento de um agente com as Multas por ele passadas

        public virtual ICollection<Multas> ListaDeMultas { get; set; }

    }
}