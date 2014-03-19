using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class HuellasPersonas : WebEntity
    {
       public int IdRegistro
	
        {
            get { return IdRegistro; }
            set { IdRegistro = value; }
        }

        public int ClaCampus
	
        {
            get { return ClaCampus; }
            set { ClaCampus= value; }
        }

        public string Matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }

        public int TipoPersona
        {
            get { return TipoPersona; }
            set { TipoPersona = value; }
        }

        public string Huella
        {
            get { return Huella; }
            set { Huella = value; }
        }

        public HuellasPersonas(bool fromDataSource)
            
        {
        }
    }
}