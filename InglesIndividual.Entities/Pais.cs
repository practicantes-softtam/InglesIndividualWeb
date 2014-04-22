using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Pais : WebEntity
    {
        private int _clave; 

        public int Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public Pais() : this(false)
        {
        }

        public Pais(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
