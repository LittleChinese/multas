using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class MultasDB : DbContext
    {
        //construtor da classe
        public MultasDB() : base("MultasDBConnectionString")
        {
        }
        //Identificar as tabelas da base de dados

        public virtual DbSet<Multas> Multas { get; set; }
        public virtual DbSet<Condutores> Condutores { get; set; }
        public virtual DbSet<Viaturas> Viaturas { get; set; }
        public virtual DbSet<Agentes> Agente { get; set; }
    }
}