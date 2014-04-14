using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Entities
{
    public class Kardex : WebEntity
    {
        private int _idCalificacion;
        private string _matricula;
        private Campus _campus;
        private Nivel _nivel;
        private Leccion _leccion;
        private int _claProfesor;
        private decimal _calificacion;
        private int _tipoClase;
        private DateTime _fecha;
        private int _claCalificacion;
        private int _idCita;

        public int IdCalificacion
        {
            get { return _idCalificacion; }
            set { _idCalificacion = value; }
        }

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public Campus Campus
        {
            get { return _campus; }
            set { _campus = value; }
        }

        public Nivel Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

         public int ClaLeccion
        {
            get { return _claLeccion; }
            set { _claLeccion = value; }
        }

         public int ClaProfesor
        {
            get { return _claProfesor; }
            set { _claProfesor = value; }
        }

         public decimal Calificacion
        {
            get { return _calificacion; }
            set { _calificacion = value; }
        }

         public int TipoClase
        {
            get { return _tipoClase; }
            set { _tipoClase = value; }
        }

         public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

         public int ClaCalificacion
        {
            get { return _claCalificacion; }
            set { _claCalificacion = value; }
        }

         public int IdCita
        {
            get { return _idCita; }
            set { _idCita = value; }
        }

        public Kardex()
            : this(false)
        { 

        }

        public Kardex(bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}
