using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class HorarioMaestros : WebEntity
      {
        public int ClaEmpleado
	
        {
            get { return ClaEmpleado; }
            set { ClaEmpleado = value; }
        }

        public int ClaCampus
	
        {
            get { return ClaCampus; }
            set { ClaCampus = value; }
        }

        public int ClaHorario
        {
            get { return ClaHorario; }
            set { ClaHorario = value; }
        }

        public int Lunes
        {
            get { return Lunes; }
            set { Lunes = value; }
        }

        public int Martes
        {
            get { return Martes; }
            set { Martes = value; }
        }

        public int Miercoles
        {
            get { return Miercoles; }
            set { Miercoles = value; }
        }

        public int Jueves
        {
            get { return Jueves; }
            set { Jueves = value; }
        }

        public int Viernes
        {
            get { return Viernes; }
            set { Viernes = value; }
        }

        public int Sabado
        {
            get { return Sabado; }
            set { Sabado = value; }
        }

        public int Domingo
        {
            get { return Domingo; }
            set { Domingo = value; }
        }

        public int OrdenLun
        {
            get { return OrdenLun; }
            set { OrdenLun = value; }
        }

        public int OrdenMar
        {
            get { return OrdenMar; }
            set { OrdenMar = value; }
        }

        public int OrdenMie
        {
            get { return OrdenMie; }
            set { OrdenMie = value; }
        }

        public int OrdenJue
        {
            get { return OrdenJue; }
            set { OrdenJue = value; }
        }

        public int OrdenVie
        {
            get { return OrdenVie; }
            set { OrdenVie = value; }
        }

        public int OrdenSab
        {
            get { return OrdenSab; }
            set { OrdenSab = value; }
        }

        public int OrdenDom
        {
            get { return OrdenDom; }
            set { OrdenDom = value; }
        }

        
        public HorarioMaestros(bool fromDataSource)
            
        {
        }
    }
}