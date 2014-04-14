using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Entities
{
    public class FwkUsuariosSistemaSeguridad : WebEntity
    {
        private int _idRegistro;
        private string _idUsuario;

        public int IdRegistro
        {
            get { return _idRegistro; ; }
            set { _idRegistro = value; }
        }
        
        public string IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public FwkUsuariosSistemaSeguridad() 
            : this(false)
        {

        }

        
        public FwkUsuariosSistemaSeguridad(bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}
