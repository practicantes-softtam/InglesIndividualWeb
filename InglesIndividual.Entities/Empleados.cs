using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Empleados : WebEntity
    {
        private int _claEmpleado;

        public int ClaEmpleado
        {
            get { return _claEmpleado; }
            set { _claEmpleado = value; }
        }
        private string _apPaterno;

        public string ApPaterno
        {
            get { return _apPaterno; }
            set { _apPaterno = value; }
        }
        private string _apMaterno;

        public string ApMaterno
        {
            get { return _apMaterno; }
            set { _apMaterno = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _sexo;

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        private Campus _campus;

        public Campus Campus
        {
            get { return _campus; }
            set { _campus = value; }
        }
        private Departamentos _departamento;

        public Departamentos Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        private Puesto _puesto;

        public Puesto Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }
        private string _calle;

        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }
        private string _colonia;

        public string Colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }
        private int _cp;

        public int CP
        {
            get { return _cp; }
            set { _cp = value; }
        }
        private Pais _pais;

        public Pais Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        private Estado _estado;

        public Estado Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private Ciudad _ciudad;

        public Ciudad Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }

        private string _telefono1;

        public string Telefono1
        {
            get { return _telefono1; }
            set { _telefono1 = value; }
        }
        private string _telefono2;

        public string Telefono2
        {
            get { return _telefono2; }
            set { _telefono2 = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private int _esDocente;

        public int EsDocente
        {
            get { return _esDocente; }
            set { _esDocente = value; }
        }
        private string _nombreCorto;

        public string NombreCorto
        {
            get { return _nombreCorto; }
            set { _nombreCorto = value; }
        }

        private int _baja;

        public int Baja
        {
            get { return _baja; }
            set { _baja = value; }
        }
        private string _foto;

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        
                public Empleados() : this(false)
        {
        }

        public Empleados(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
