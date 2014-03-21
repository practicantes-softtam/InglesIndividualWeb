using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class FwkModulos:WebEntity
    {
        private int _claAplicacion;
        private int _claModulo;
        private string _nomModulo;
        private int _claModuloPadre;

        public int ClaModuloPadre
        {
            get { return _claModuloPadre; }
            set { _claModuloPadre = value; }
        }



        public string NomModulo
        {
            get { return _nomModulo; }
            set { _nomModulo = value; }
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

          public FwkModulos(): this(false)
        {
        }

        public FwkModulos(bool fromDataSource) : base(fromDataSource)
        {
        }


    }
}
