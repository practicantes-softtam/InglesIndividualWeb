using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Ciudad : WebEntity
    {
        private int _clave;
        private Estado _estado;
        private string _nombre;


	    public int Clave
	       {
		    get { return _clave;}
		    set { _clave = value;}
	}
	 
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Estado Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public Ciudad() : this(false)
        {

        }

        public Ciudad(bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}
