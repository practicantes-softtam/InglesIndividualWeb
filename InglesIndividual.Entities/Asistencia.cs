using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Asistencia : WebEntity
    {

        private Campus _campus;

        public Campus Campus
        {
            get { return _campus; }
            set { _campus = value; }
        }

        private string _matricula;

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        private Empleados _empleado;

        public Empleados Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        private int _tipoPersona;

        public int TipoPersona
        {
            get { return _tipoPersona; }
            set { _tipoPersona = value; }
        }


        private DateTime _fechaHora;

        public DateTime FechaHora
        {
            get { return _fechaHora; }
            set { _fechaHora = value; }
        }

        private string _mensaje;

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        private int _idCita;

        public int idCita
        {
            get { return _idCita; }
            set { _idCita = value; }
        }

        private int _registroValido;

        public int RegistroValido
        {
            get { return _registroValido; }
            set { _registroValido = value; }
        }


        private int _idRegistro;

        public int idRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }
        

                public Asistencia() : this(false)
        {
        }

        public Asistencia(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
