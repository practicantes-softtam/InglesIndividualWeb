using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Departamentos : WebEntity
    {
        private int _claDepartamento;       

        public int ClaDepartamento
        {
            get { return _claDepartamento; }
            set { _claDepartamento = value; }
        }

        private Campus _campus;

        public Campus Campus
        {
            get { return _campus; }
            set { _campus = value; }
        }

        private string _nomDepartamento;

        public string NomDepartamento
        {
            get { return _nomDepartamento; }
            set { _nomDepartamento = value; }
        }
        

                public Departamentos() : this(false)
        {
        }

        public Departamentos(bool fromDataSource) : base(fromDataSource)
        {
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Entities
{
    public class Departamentos : WebEntity
    {
        private int _claDepartamento;
        private Campus _campus;
        private string _nomDepartamento;

        public int ClaDepartamento
        {
            get { return _claDepartamento; }
            set { _claDepartamento = value; }
        }

        public Campus Campus
        {
            get { return _campus; }
            set { _campus = value;}
        }

       
        public string NomDepartamento
        {
            get { return _nomDepartamento; }
            set {_nomDepartamento = value; }
        }
   
        public Departamentos() 
            : this(false)
        {

        }
        
        public Departamentos(bool fromDataSource)
            : base(fromDataSource)
        {

        }
    }
}
>>>>>>> .r82
