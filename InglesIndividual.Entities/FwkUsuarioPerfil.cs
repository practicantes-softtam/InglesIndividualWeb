using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
  public  class FwkUsuarioPerfil:WebEntity

    {
        private string _idUsuario;
        private int _claAplicacion;
        private int _claPerfil;

        public int ClaPerfil
        {
            get { return _claPerfil; }
            set { _claPerfil = value; }
        }


        public int ClaAplicacion
        {
            get { return _claAplicacion; }
            set { _claAplicacion = value; }
        }
        

        public string IsUsuario
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
