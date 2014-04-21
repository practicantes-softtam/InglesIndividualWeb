using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Ampliaciones : WebEntity
    {
        private int _idAmpliacion;

        public int idAmpliacion
        {
            get { return _idAmpliacion; }
            set { _idAmpliacion = value; }
        }


        private string _matricula;

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        private int _vigencia;

        public int Vigencia
        {
            get { return _vigencia; }
            set { _vigencia = value; }
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
        

                public Ampliaciones() : this(false)
        {
        }

        public Ampliaciones(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
