
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Entities
{
    public class Puestos : WebEntity
    {

        private int _claPuesto;
        private string _Nombre;
       
        
        public int ClaPuesto
        {
            get { return _claPuesto; }
            set { _claPuesto = value; }
        }

        public string NomPuesto
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

           public Puestos(): this(false)
        {
        }

        public Puestos(bool fromDataSource) : base(fromDataSource)
        {
        }


    }
}