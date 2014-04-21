using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Pais : WebEntity
    {
        private int _claPais;
        private string _nomPais;

        public int ClaPais
        {
            get { return _claPais; }
            set { _claPais = value; }
        }

        public string NomPais
        {
            get { return _nomPais; }
            set { _nomPais = value; }
        }

        public Pais() : this(false)
        {
        }

        public Pais(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
