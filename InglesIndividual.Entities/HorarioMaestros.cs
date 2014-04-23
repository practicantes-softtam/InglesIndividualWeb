using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class HorarioMaestros : WebEntity
      {
        private Empleados _empleado;
        private Campus _campus;
        private int _claHorario;
        private int _lun;
        private int _mar;
        private int _mie;
        private int _jue;
        private int _vie;
        private int _sab;
        private int _dom;
        private int _ordenLun;
        private int _ordenMar;
        private int _ordenMie;
        private int _ordenJue;
        private int _ordenVie;
        private int _ordenSab;
        private int _ordenDom;

        public Empleados Empleado
	
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public Campus ClaCampus
	
        {
            get { return _campus; }
            set { _campus = value; }
        }

        public int ClaHorario
        {
            get { return _claHorario; }
            set { _claHorario = value; }
        }

        public int Lun
        {
            get { return _lun; }
            set { _lun = value; }
        }

        public int Mar
        {
            get { return _mar; }
            set { _mar = value; }
        }

        public int Mie
        {
            get { return _mie; }
            set { _mie = value; }
        }

        public int Jue
        {
            get { return _jue; }
            set { _jue = value; }
        }

        public int Vie
        {
            get { return _vie; }
            set { _vie = value; }
        }

        public int Sab
        {
            get { return _sab; }
            set { _sab = value; }
        }

        public int Dom
        {
            get { return _dom; }
            set { _dom = value; }
        }

        public int OrdenLun
        {
            get { return _ordenLun; }
            set { _ordenLun = value; }
        }

        public int OrdenMar
        {
            get { return _ordenMar; }
            set { _ordenMar = value; }
        }

        public int OrdenMie
        {
            get { return _ordenMie; }
            set { _ordenMie = value; }
        }

        public int OrdenJue
        {
            get { return _ordenJue; }
            set { _ordenJue = value; }
        }

        public int OrdenVie
        {
            get { return _ordenVie; }
            set { _ordenVie = value; }
        }

        public int OrdenSab
        {
            get { return _ordenSab; }
            set { _ordenSab = value; }
        }

        public int OrdenDom
        {
            get { return _ordenDom; }
            set { _ordenDom = value; }
        }

        public HorarioMaestros() 
            : this(false)
        {

        }

        public HorarioMaestros(bool fromDataSource) : base(fromDataSource)
            
        {
        }
    }
}