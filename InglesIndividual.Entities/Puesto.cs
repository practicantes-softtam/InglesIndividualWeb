
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Entities
{
    public class Puesto : WebEntity
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

           public Puesto(): this(false)
        {
        }

        public Puesto(bool fromDataSource) : base(fromDataSource)
        {
        }


    }
}