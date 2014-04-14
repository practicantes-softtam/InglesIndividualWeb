using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class OrdenAsignacionCitas : WebEntity
    {
        private int _claCampus;
        private int _claProfesor;
        private int _orden;

        public int ClaCampus
        {
            get { return _claCampus; }
            set { _claCampus = value; }
        }

        public int ClaProfesor
        {
            get { return _claProfesor; }
            set { _claProfesor = value; }
        }

        public int Orden
        {
            get { return _orden; }
            set { _orden= value; }
        }


        public OrdenAsignacionCitas(bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}