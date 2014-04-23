using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class HorarioClubConversacion : WebEntity
     {
        private Campus _campus;
        private Empleados _empleado;
        private int _claHorario;
        private int _claDia;
        private int _horas;


        public Campus Campus
	
        {
            get { return _campus; }
            set { _campus = value; }
        }

        public Empleados Empleado
	
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public int ClaHorario
        {
            get { return _claHorario; }
            set { _claHorario = value; }
        }

        public int ClaDia
        {
            get { return _claDia; }
            set { _claDia = value; }
        }

        public int Horas
        {
            get { return _horas; }
            set { _horas = value; }
        }

        public HorarioClubConversacion() 
            : this(false)
        {

        }
        
        public HorarioClubConversacion(bool fromDataSource) : base (fromDataSource)
        {

        }
    }
}

