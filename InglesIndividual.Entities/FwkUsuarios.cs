using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class FwkUsuarios : WebEntity
    {
        public string IdUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }

        public string NomUsuario
        {
            get { return NomUsuario; }
            set { NomUsuario = value; }
        }

        public string Password
        {
            get { return Password; }
            set { Password = value; }
        }

        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }

       
        public FwkUsuarios(bool fromDataSource)
            : base(fromDataSource)
        {
        }
    }
}
