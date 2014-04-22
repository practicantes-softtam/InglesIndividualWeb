using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class FwkPerfiles:WebEntity
    {
        private  FwkAplicaciones _claAplicacion;
        private int _claPerfil;
        private string _nomPerfil;

        public string NomPerfil
        {
            get { return _nomPerfil; }
            set { _nomPerfil = value; }
        }
        

        public int ClaPerfil
        {
            get { return _claPerfil; }
            set { _claPerfil = value; }
        }


        public FwkAplicaciones FwkAplicaciones
        {
            get { return _claAplicacion; }
            set { _claAplicacion = value; }
        }

          public FwkPerfiles(): this(false)
        {
        }

        public FwkPerfiles(bool fromDataSource) : base(fromDataSource)
        {
        }


    }
}
