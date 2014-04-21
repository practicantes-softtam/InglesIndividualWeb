<<<<<<< .mine
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesIndividual.Entities
{
    public class Salones : WebEntity
    {
        private int _idSalon;

        public int IdSalon
        {
            get { return _idSalon; }
            set { _idSalon = value; }
        }
        private Campus _campus;

        public Campus Campus
        {
            get { return _campus; }
            set { _campus = value; }
        }

        private string _nomSalon;

        public string NomSalon
        {
            get { return _nomSalon; }
            set { _nomSalon = value; }
        }
        private int _capacidad;

        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }
        
                public Salones() : this(false)
        {
        }

        public Salones(bool fromDataSource) : base(fromDataSource)
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
    public class Salones : WebEntity
    {
        private int _idSalon;
        private Campus _campus;
        private string _nomSalon;
        private int _capacidad;

        public int IdSalon
        {
            get { return _idSalon; }
            set { _idSalon = value; }
        }

        public Campus Campus
        {
            get { return _campus; }
            set { _campus = value; }
        }

        public string NomSalon
        {
            get { return _nomSalon; }
            set { _nomSalon = value; }
        }

        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }

       
        public Salones()
            : this(false)
        {
        }

        public Salones(bool fromDataSource)
            : base(fromDataSource)
        {
        }
    }
}
>>>>>>> .r82
