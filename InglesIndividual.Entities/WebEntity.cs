using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Entities
{
    public class WebEntity : Entity
    {
        private bool _eliminar;

        public bool Eliminar
        {
            get { return this._eliminar; }
            set { this._eliminar = value; }
        }

        public int TotalRecords { get; set; }

        public WebEntity() : this(false)
        {
        }

        public WebEntity(bool fromDataSource) : base(fromDataSource)
        {
        }
    }
}
