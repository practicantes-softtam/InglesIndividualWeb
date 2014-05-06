using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class CategoriaConfiguracion : WebEntity
    {
        private int _claCategoria;

        public int ClaCategoria
        {
            get { return _claCategoria; }
            set { _claCategoria = value; }
        }
        private string _nomCategoria;

        public string Nombre
        {
            get { return _nomCategoria; }
            set { _nomCategoria = value; }
        }
        

                public CategoriaConfiguracion() : this(false)
        {
        }

        public CategoriaConfiguracion(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
