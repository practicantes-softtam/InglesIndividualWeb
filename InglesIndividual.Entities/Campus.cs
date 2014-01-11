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
            get;
            set;
        }

        public string Nombre
        {
            get; set;
        }
        
        public string Calle
        {
            get; set;
        }
        
        public string Colonia
        {
            get; set;
        }
        
        public int CodigoPostal
        {
            get; set;
        }

        public string Telefono
        {
            get; set;
        }

        public string DirectorGeneral
        {
            get; set;
        }

        public string DirectorAdministrativo
        {
            get; set;
        }

        public Ciudad Ciudad
        {
            get;
            set;
        }

        public Campus() : this(false)
        {
        }

        public Campus(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
