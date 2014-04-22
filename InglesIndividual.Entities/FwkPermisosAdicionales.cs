using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
   public class FwkPermisosAdicionales:WebEntity
    {
        private FwkUsuarios _idUsusario;
        private FwkAplicaciones _claAplicacion;
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


        public FwkAplicaciones FwkAplicaciones
        {
            get { return _claAplicacion; }
            set { _claAplicacion = value; }
        }


        public FwkUsuarios FwkUsuario
        {
            get { return _idUsusario; }
            set { _idUsusario = value; }
        }

          public FwkPermisosAdicionales (): this(false)
        {
        }

        public FwkPermisosAdicionales(bool fromDataSource) : base(fromDataSource)
        {
        }

    }
}
