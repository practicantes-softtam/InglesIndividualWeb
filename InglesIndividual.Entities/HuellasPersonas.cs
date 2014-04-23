using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class HuellasPersonas : WebEntity
    {
        private int _idRegistro;
        private Campus _campus;
        private string _matricula;
        private Empleados _claEmpleado;
        private int _tipoPersona;
        private string _huella;

       public int IdRegistro
	
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        public Campus ClaCampus
	
        {
            get { return _campus; }
            set { _campus= value; }
        }

        public Empleados ClaEmpleado
        {
            get { return _claEmpleado; }
            set { _claEmpleado = value; }
        }

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public int TipoPersona
        {
            get { return _tipoPersona; }
            set { _tipoPersona = value; }
        }

        public string Huella
        {
            get { return _huella; }
            set { _huella = value; }
        }

        public HuellasPersonas() 
            : this(false)
        {

        }

        public HuellasPersonas(bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}