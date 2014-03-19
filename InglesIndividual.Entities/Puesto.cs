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
            get { return ID; }
            set { ID = value; }
        }

        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public Puesto() : this(false)
        {
        }

        public Puesto(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
