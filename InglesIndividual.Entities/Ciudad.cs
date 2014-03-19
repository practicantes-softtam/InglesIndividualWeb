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
		    get { return Clave;}
		    set { Clave = value;}
	}
	 
        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public Estado Estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

        public Ciudad() : this(false)
        {
        }

        public Ciudad(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
