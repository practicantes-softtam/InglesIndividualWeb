using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Estado : WebEntity
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

        private Pais _pais;

        public Pais Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        
        public Estado() : this(false)
        {
        }

        public Estado(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
