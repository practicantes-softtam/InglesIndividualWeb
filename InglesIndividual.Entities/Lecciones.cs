using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InglesIndividual.Entities
{
    public class Lecciones : WebEntity
    {
        private int _claLeccion;
        private Nivel _nivel;
        private string _nomLeccion;
        private int _esReview;

    public int ClaLeccion
        {
            get { return _claLeccion; }
            set { _claLeccion = value; }
        }

        public Nivel ClaNivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
        
        public string NomLeccion
        {
            get { return _nomLeccion; }
            set { _nomLeccion = value; }
        }
        
        public int EsReview
        {
            get { return _esReview; }
            set { _esReview = value; }
        }
        
       
        public Lecciones() 
            : this(false)
        {

        }

        public Lecciones(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}