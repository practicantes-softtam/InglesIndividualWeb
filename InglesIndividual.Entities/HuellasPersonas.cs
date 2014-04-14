﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class HuellasPersonas : WebEntity
    {
        private int _idRegistro;
        private int _claCampus;
        private string _matricula;
        private int _claEmpleado;
        private int _tipoPersona;
        private string _huella;

       public int IdRegistro
	
        {
            get { return _idRegistro; }
            set { _idRegistro = value; }
        }

        public int ClaCampus
	
        {
            get { return _claCampus; }
            set { _claCampus= value; }
        }

        public int ClaEmpleado
        {
            get { return _claEmpleado; }
            set { _claEmpleado = value; }
        }

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public int TipoPersona
        {
            get { return _tipoPersona; }
            set { _tipoPersona = value; }
        }

        public string Huella
        {
            get { return _huella; }
            set { _huella = value; }
        }

        public HuellasPersonas(bool fromDataSource) : base(fromDataSource)
        {

        }
    }
}