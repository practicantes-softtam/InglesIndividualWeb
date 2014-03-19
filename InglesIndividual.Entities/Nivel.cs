using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Entities
{
    public class Nivel : Entity
    {
        private int _claNivel;
        private string _nomNivel;
        private int _clubConversacion;

        public int ClaNivel
        {
            get { return this._claNivel; }
            set { this._claNivel = value; }
        }
        
        public string NomNivel
        {
            get { return this._nomNivel; }
            set { this._nomNivel = value; }
        }
            
        public int ClubConversacion
        {
            get { return this._clubConversacion; }
            set { this._clubConversacion = value; }
        }
        
     public Nivel (bool fromDataSource)
     {
        }
    }


    }
