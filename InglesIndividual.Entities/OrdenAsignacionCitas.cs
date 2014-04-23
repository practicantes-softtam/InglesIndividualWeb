using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class OrdenAsignacionCitas : WebEntity
    {
        private Campus _campus;
        private int _claProfesor;
        private int _orden;

        public Campus ClaCampus
        {
            get { return _campus; }
            set { _campus = value; }
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

        public OrdenAsignacionCitas() 
            : this(false)
        {

        }


        public OrdenAsignacionCitas(bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}