using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class FwkUsuarioAplicacion:WebEntity
    {
        private FwkAplicaciones _claAplicacion;
        private FwkUsuarios _idUsusario;

        public FwkUsuarios FwkUsuario
        {
            get { return _idUsusario; }
            set { _idUsusario = value; }
        }


        public  FwkAplicaciones FwkAplicacion
        {
            get { return _claAplicacion; }
            set { _claAplicacion = value; }
        }

          public FwkUsuarioAplicacion() : this(false)
        {
        }

        public FwkUsuarioAplicacion(bool fromDataSource) : base(fromDataSource)
        {
        }

    }
}
