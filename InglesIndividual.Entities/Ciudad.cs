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
        private string _nomCiudad;


	    public int Clave
	       {
		    get { return _clave;}
		    set { _clave = value;}
	}
	 
        public string NomCiudad
        {
            get { return _nomCiudad; }
            set { _nomCiudad = value; }
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
