using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class ExtensionesCurso : WebEntity
    {
        private int _idRegistro;

        public int IdRegistro
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

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

        private int _fehaIni;

        public int FechaIni
        {
            get { return _fehaIni; }
            set { _fehaIni = value; }
        }

        private int _fechaFin;

        public int FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }

        private string _comentarios;

        public string Comentarios
        {
            get { return _comentarios; }
            set { _comentarios = value; }
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
        private int _tipoRegistro;

        public int TipoRegistro
        {
            get { return _tipoRegistro; }
            set { _tipoRegistro = value; }
        }
        

                public ExtensionesCurso() : this(false)
        {
        }

        public ExtensionesCurso(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
