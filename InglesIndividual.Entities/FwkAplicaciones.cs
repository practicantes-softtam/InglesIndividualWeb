using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
   public class FwkAplicaciones : WebEntity
    {
        private int _claAplicacion;
        private string _nomAplicacion;
            
        public string NomAplicacion    
        {
            get { return _nomAplicacion; }
            set { _nomAplicacion = value; }
        }
        

        public int ClaAplicacion
        {   
            get { return _claAplicacion; }
            set { _claAplicacion = value; }
        }

        public FwkAplicaciones(): this(false)
        {
        }

        public FwkAplicaciones(bool fromDataSource) : base(fromDataSource)
        {
        }
        

    }
}

//propfull control+j