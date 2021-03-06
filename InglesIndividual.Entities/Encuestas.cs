﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
  public class Encuestas : WebEntity
    {

        private int _claEncuesta;
        private string _nomEncuesta;

        public string Nombre
        {
            get { return _nomEncuesta; }
            set { _nomEncuesta = value; }
        }


        public int ID
        {
            get { return _claEncuesta; }
            set { _claEncuesta = value; }
        }

              public Encuestas() : this(false)
        {
        }

        public Encuestas(bool fromDataSource) : base(fromDataSource)
        {
        }
        
    }
}
