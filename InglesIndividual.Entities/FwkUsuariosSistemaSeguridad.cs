using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class FwkUsuariosSistemaSeguridad : WebEntity
    {
         public int IdRegistro
        {
            get { return IdRegistro; }
            set { IdRegistro = value; }
        }

        public string IdUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }

       
        public FwkUsuariosSistemaSeguridad(bool fromDataSource)
                 {
        }
    }


    }
