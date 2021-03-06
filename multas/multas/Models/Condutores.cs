﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class Condutores
    {
        public Condutores()
        {
            ListaDeMultas = new HashSet<Multas>();
        }

        [Key]
        public int ID { get; set; } //chave primaria

        //Dados próprios do condutor
        public string Nome { get; set; }

        public string BI { get; set; }

        public string Telemóvel { get; set; }

        public DateTime DataNascimento { get; set; }

        //Dados da carta de condução do condutor
        public string NumCartaConducao { get; set; }

        public string LocalEmissao { get; set; }

        public DateTime DataValidadeCarta { get; set; }


        //Complementar a informação sobre o relacionamento de um agente com as Multas por ele passadas

        public virtual ICollection<Multas> ListaDeMultas { get; set; }

    }
   
    
}