using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class OrdenAsignacionCitas : WebEntity
    {
       

        public int ClaCampus
        {
            get { return ClaCampus; }
            set { ClaCampus = value; }
        }

        public int ClaProfesor
        {
            get { return ClaProfesor; }
            set { ClaProfesor = value; }
        }

        public int Orden
        {
            get { return Orden; }
            set { Orden= value; }
        }


        public OrdenAsignacionCitas(bool fromDataSource)
                 {
        }
    }


    }
