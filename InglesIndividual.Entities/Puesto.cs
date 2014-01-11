using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Entities
{
    public class Puesto : WebEntity
    {
        public int ID
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public Puesto() : this(false)
        {
        }

        public Puesto(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
