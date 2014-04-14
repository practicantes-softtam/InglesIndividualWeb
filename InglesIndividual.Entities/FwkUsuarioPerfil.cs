using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
  public  class FwkUsuarioPerfil:WebEntity

    {
        private FwkUsuarios _idUsuario;
        private FwkAplicaciones _claAplicacion;
        private FwkPerfiles _claPerfil;

        public FwkPerfiles  ClaPerfil
        {
            get { return _claPerfil; ; }
            set {_claPerfil = value; }
        }


        public FwkAplicaciones ClaAplicacion
        {
            get { return _claAplicacion; }
            set { _claAplicacion = value; }
        }
        

        public FwkUsuarios IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

          public FwkUsuarioPerfil   (): this(false)
        {
        }

        public FwkUsuarioPerfil(bool fromDataSource) : base(fromDataSource)
        {
        }


    }
}
