using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Configuracion : WebEntity
    {

        private int _claCategoria;

        public int ClaCategoria
        {
            get { return _claCategoria; }
            set { _claCategoria = value; }
        }

        private int _claConfig;

        public int ClaConfig
        {
            get { return _claConfig; }
            set { _claConfig = value; }
        }

        private string _nomConfiguracion;

        public string NomConfiguracion
        {
            get { return _nomConfiguracion; }
            set { _nomConfiguracion = value; }
        }
        private int _valorEntero;

        public int ValorEntero
        {
            get { return _valorEntero; }
            set { _valorEntero = value; }
        }

        private string _valorCadena;

        public string ValorCadena
        {
            get { return _valorCadena; }
            set { _valorCadena = value; }
        }

        private int _editable;

        public int Editable
        {
            get { return _editable; }
            set { _editable = value; }
        }
        
                public Configuracion() : this(false)
        {
        }

        public Configuracion(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
