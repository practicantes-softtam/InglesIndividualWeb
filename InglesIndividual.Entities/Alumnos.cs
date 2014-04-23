using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Alumnos : WebEntity
    {

        private string _matricula;

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
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
        private Ciudades _ciudad;

        public Ciudades ClaCiudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }

        private string _empresa;

        public string Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
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
        private int _ingreso;

        public int Ingreso
        {
            get { return _ingreso; }
            set { _ingreso = value; }
        }

        private int _vigencia;

        public int Vigencia
        {
            get { return _vigencia; }
            set { _vigencia = value; }
        }

        private int _estatus;

        public int Estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        private int _claCampus;

        public int ClaCampus
        {
            get { return _claCampus; }
            set { _claCampus = value; }
        }
        private int _claNivel;

        public int ClaNivel
        {
            get { return _claNivel; }
            set { _claNivel = value; }
        }
        private int _claLeccion;

        public int ClaLeccion
        {
            get { return _claLeccion; }
            set { _claLeccion = value; }
        }

        private string _suscriptor;

        public string Suscriptor
        {
            get { return _suscriptor; }
            set { _suscriptor = value; }
        }

        private int _claAtendio;

        public int ClaAtendio
        {
            get { return _claAtendio; }
            set { _claAtendio = value; }
        }
        
        private string _contrato;

        public string Contrato
        {
            get { return _contrato; }
            set { _contrato = value; }
        }

        private int _especial;

        public int Especial
        {
            get { return _especial; }
            set { _especial = value; }
        }

        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        private string _foto;

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        private int _fechaNacimeinto;

        public int FechaNacimiento
        {
            get { return _fechaNacimeinto; }
            set { _fechaNacimeinto = value; }
        }

        private string _telefono3;

        public string Telefono3
        {
            get { return _telefono3; }
            set { _telefono3 = value; }
        }
        

                public Alumnos() : this(false)
        {
        }

        public Alumnos(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
