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


        public FwkAcciones FwkAcciones
        {
            get { return _claAccion; }
            set { _claAccion = value; }
        }


        public FwkObjetos FwkObjetos
        {
            get { return _claObjeto; }
            set { _claObjeto = value; }
        }


        public FwkModulos FwkModulos
        {
            get { return _claModulo; }
            set { _claModulo = value; }
        }

        public FwkPerfiles FwkPerfil
        {
            get { return _claPerfil; }
            set { _claPerfil = value; }
        }
        public FwkAplicaciones FwkAplicacion
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
