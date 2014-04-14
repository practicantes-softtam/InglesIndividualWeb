using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
  public  class FwkAcciones : WebEntity
    {
        private string  _claAccion;
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        

        public string ClaAccion
        {
            get { return _claAccion; }
            set { _claAccion = value; }
        }
        
        
          public FwkAcciones() : this(false)
        {
        }

        public FwkAcciones(bool fromDataSource) : base(fromDataSource)
        {
        }



    }
}
