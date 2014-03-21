using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
   public class FwkPermisosAdicionales:WebEntity
    {
        private string _idUsusario;
        private int _claAplicacion;
        private int _claModulo;
        private int _claObjeto;
        private string _claAccion;
        private int _permitir;

        public int Permitir
        {
            get { return _permitir; }
            set { _permitir = value; }
        }


        public string ClaAccion
        {
            get { return _claAccion; }
            set { _claAccion = value; }
        }


        public int ClaObjeto
        {
            get { return _claObjeto; }
            set { _claObjeto = value; }
        }


        public int ClaModulo
        {
            get { return _claModulo; }
            set { _claModulo = value; }
        }


        public int ClaAplicacion
        {
            get { return _claAplicacion; }
            set { _claAplicacion = value; }
        }


        public string IdUsuario
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
