using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InglesIndividual.Entities
{
    public class Campus : WebEntity
    {
        private int _clave;
        private string _nombre;
        private string _calle;
        private string _colonia;
        private int _codigoPostal;
        private Pais _pais;
        private Ciudad _ciudad;
        private string _telefono;
        private string _directorGeneral;
        private string _directorAdministrativo;

        public int Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }
        
        public string Colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }
        
        public int CodigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }

        public Pais Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
             
        

        public Ciudad Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string DirectorGeneral
        {
            get { return _directorGeneral; }
            set { _directorGeneral = value; }
        }

        public string DirectorAdministrativo
        {
            get { return _directorAdministrativo; }
            set { _directorAdministrativo = value; }
        }

        public Campus() : this(false)
        {

        }

              
        public Campus(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
