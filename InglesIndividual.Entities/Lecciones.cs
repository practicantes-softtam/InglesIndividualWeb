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
        private Nivel _nivel;
        private int _esReview;

  
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

        public int EsReview
        {
            get { return _esReview; }
            set { _esReview = value; }
        }

        public Nivel Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
        
        public Lecciones() : this(false)
        {

        }

        public Lecciones(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}