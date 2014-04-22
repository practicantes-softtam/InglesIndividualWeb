using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
   public class FwkObjetos: WebEntity
    {
        private FwkAplicaciones _claAplicacion;
        private FwkModulos  _claModulo;
        private int _claObjeto;
        private string _claveObjeto;
        private string _nomObjeto;
        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }


        public string NomObjeto
        {
            get { return _nomObjeto; }
            set { _nomObjeto = value; }
        }


        public string ClaveObjeto
        {
            get { return _claveObjeto; }
            set { _claveObjeto = value; }
        }


        public int ClaObjeto
        {
            get { return _claObjeto; }
            set { _claObjeto = value; }
        }


        public FwkModulos ClaModulo
        {
            get { return _claModulo; }
            set { _claModulo = value; }
        }


        public FwkAplicaciones ClaAplicacion
        {
            get { return _claAplicacion; }
            set { _claAplicacion = value; }
        }

          public FwkObjetos(): this(false)
        {
        }

        public FwkObjetos(bool fromDataSource) : base(fromDataSource)
        {
        }

    }
}
