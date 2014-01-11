using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Estado : WebEntity
    {
        public int Clave
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public Pais Pais
        {
            get;
            set;
        }

        public Estado() : this(false)
        {
        }

        public Estado(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
