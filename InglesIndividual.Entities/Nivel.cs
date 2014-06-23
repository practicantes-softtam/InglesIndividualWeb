using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Nivel : WebEntity
    {
        private int _clave;
        private string _nombre;
        private int _clubConversacion;

        public int ID
        {
            get { return _clave; }
            set { _clave = value; }
        }
        
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
            
        public int ClubConversacion
        {
            get { return this._clubConversacion; }
            set { this._clubConversacion = value; }
        }

        public Nivel() : this(false)
        { 

        }
        
        public Nivel (bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}
