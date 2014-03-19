using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class HorarioClubConversacion : WebEntity
     {
        public int ClaCampus
	
        {
            get { return ClaCampus; }
            set { ClaCampus = value; }
        }

        public int ClaEmpleado
	
        {
            get { return ClaEmpleado; }
            set { ClaEmpleado = value; }
        }

        public int ClaHorario
        {
            get { return ClaHorario; }
            set { ClaHorario = value; }
        }

        public int ClaDia
        {
            get { return ClaDia; }
            set { ClaDia = value; }
        }

        public int Horas
        {
            get { return Horas; }
            set { Horas = value; }
        }

        public HorarioClubConversacion(bool fromDataSource)
            
        {
        }
    }
}

