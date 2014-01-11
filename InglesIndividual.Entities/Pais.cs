using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Pais : WebEntity
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

        public Pais() : this(false)
        {
        }

        public Pais(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
