using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Campus : WebEntity
    {
        public int Clave
        {
            get { return Clave; }
            set { Clave = value; }
        }

        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        
        public string Calle
        {
            get { return Calle; }
            set { Calle = value; }
        }
        
        public string Colonia
        {
            get { return Colonia; }
            set { Colonia = value; }
        }
        
        public int CodigoPostal
        {
            get { return CodigoPostal; }
            set { CodigoPostal = value; }
        }

        public string Telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        public string DirectorGeneral
        {
            get { return DirectorGeneral; }
            set { DirectorGeneral = value; }
        }

        public string DirectorAdministrativo
        {
            get { return DirectorAdministrativo; }
            set { DirectorAdministrativo = value; }
        }

        public Ciudad Ciudad
        {
            get { return Ciudad; }
            set { Ciudad = value; }
        }

        public Campus() : this(false)
        {
        }

        public Campus(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
