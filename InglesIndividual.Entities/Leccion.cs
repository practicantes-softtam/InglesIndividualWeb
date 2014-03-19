using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Leccion : WebEntity
    {
    public int ClaLeccion
        {
            get { return ClaLeccion; }
            set { ClaLeccion = value; }
        }

        public int ClaNivel
        {
            get { return ClaNivel; }
            set { ClaNivel = value; }
        }
        
        public string NomLeccion
        {
            get { return NomLeccion; }
            set { NomLeccion = value; }
        }
        
        public int EsReview
        {
            get { return EsReview; }
            set { EsReview = value; }
        }
        
        
        public Leccion() : this(false)
        {
        }

        public Leccion(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}