using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Citas : WebEntity
    {
        private int _idCita;

        public int IdCita
        {
            get { return _idCita; }
            set { _idCita = value; }
        }
        private Campus _Campus;

        public Campus Campus
        {
            get { return _Campus; }
            set { _Campus = value; }
        }
        private string _matricula;

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        private int _claProfesosr;

        public int ClaProfesor
        {
            get { return _claProfesosr; }
            set { _claProfesosr = value; }
        }

        private int _fechaHora;

        public int FechaHora
        {
            get { return _fechaHora; }
            set { _fechaHora = value; }
        }

        private int _tipoClase;

        public int TipoClase
        {
            get { return _tipoClase; }
            set { _tipoClase = value; }
        }

        private int _estatus;

        public int Estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }
        private int _claNivel;

        public int ClaNivel
        {
            get { return _claNivel; }
            set { _claNivel = value; }
        }
        private int _claLeccion;

        public int ClaLeccion
        {
            get { return _claLeccion; }
            set { _claLeccion = value; }
        }
        private int _fechaHoraOriginal;

        public int FechaHoraOriginal
        {
            get { return _fechaHoraOriginal; }
            set { _fechaHoraOriginal = value; }
        }

        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        private int _modManual;

        public int ModManual
        {
            get { return _modManual; }
            set { _modManual = value; }
        }

        private int _fechaHoraAsistencia;

        public int FechaHoraAsistencia
        {
            get { return _fechaHoraAsistencia; }
            set { _fechaHoraAsistencia = value; }
        }
        private int _aprobo;

        public int Aprobo
        {
            get { return _aprobo; }
            set { _aprobo = value; }
        }
        

                public Citas() : this(false)
        {
        }

        public Citas(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
