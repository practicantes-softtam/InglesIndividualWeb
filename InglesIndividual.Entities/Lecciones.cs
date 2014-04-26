using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InglesIndividual.Entities
{
    public class Lecciones : WebEntity
    {
        private int _clave;
        private string _nombre;

    public int Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public Lecciones() : this(false)
        {

        }

        public Lecciones(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}