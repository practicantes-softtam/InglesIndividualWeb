using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class FwkUsuarios : WebEntity
    {
        private string _idUsuario;
        private string _nomUsuario;
        private string _password;
        private string _email;

        public string IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string NomUsuario
        {
            get { return _nomUsuario; }
            set { _nomUsuario = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public FwkUsuarios() 
            : this(false)
        {

        }

       
        public FwkUsuarios(bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}
