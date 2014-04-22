using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Ciudades : WebEntity
    {

        private int _clave;
        private int _estado;
        private int _pais;
        private string _nomCiudad;


	    public int ClaCiudad
	       {
		    get { return _clave;}
		    set { _clave = value;}
	}
	 
        public string NomCiudad
        {
            get { return _nomCiudad; }
            set { _nomCiudad = value; }
        }

        public int ClaEstado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public int ClaPais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public Ciudades() : this(false)
        {

        }

        public Ciudades(bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}
