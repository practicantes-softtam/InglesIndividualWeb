using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Ciudad : WebEntity
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

        public Estado Estado
        {
            get;
            set;
        }

        public Ciudad() : this(false)
        {
        }

        public Ciudad(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
