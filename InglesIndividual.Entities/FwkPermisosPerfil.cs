using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class FwkPermisosPerfil: WebEntity
    {

        
        private FwkAplicaciones _claAplicacion;
        private FwkPerfiles _claPerfil;
        private FwkModulos _claModulo;
        private FwkObjetos _claObjeto;
        private FwkAcciones _claAccion;
        private int _permitir;

        public int Permitir
        {
            get { return _permitir; }
            set { _permitir = value; }
        }


        public FwkAcciones ClaAccion
        {
            get { return _claAccion; }
            set { _claAccion = value; }
        }


        public FwkObjetos ClaObjeto
        {
            get { return _claObjeto; }
            set { _claObjeto = value; }
        }


        public FwkModulos ClaModulo
        {
            get { return _claModulo; }
            set { _claModulo = value; }
        }

        public FwkPerfiles ClaPerfil
        {
            get { return _claPerfil; }
            set { _claPerfil = value; }
        }
        public FwkAplicaciones ClaAplicacion
        {
            get { return _claAplicacion; }
            set { _claAplicacion = value; }
        }

          public FwkPermisosPerfil  (): this(false)
        {
        }

        public FwkPermisosPerfil(bool fromDataSource) : base(fromDataSource)
        {
        }


        

    }
}
