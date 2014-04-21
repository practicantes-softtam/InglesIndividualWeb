using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class AsistenciaLaboratorio :WebEntity
    {
        private int _idAsistenciaLaboratorio;

        public int IdAsistenciaLaboratorio
        {
            get { return _idAsistenciaLaboratorio; }
            set { _idAsistenciaLaboratorio = value; }
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
        private int _fecha;

        public int Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
                 public AsistenciaLaboratorio() : this(false)
        {
        }

        public AsistenciaLaboratorio(bool fromDataSource) : base(fromDataSource)
        {
        }
        
    }
}
