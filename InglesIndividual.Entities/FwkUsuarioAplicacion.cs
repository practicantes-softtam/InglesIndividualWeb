using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class FwkUsuarioAplicacion:WebEntity
    {
        private int _claAplicacion;
        private string _idUsusario;

        public string IdUsuario
        {
            get { return _idUsusario; }
            set { _idUsusario = value; }
        }


        public int ClaAplicacion
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
