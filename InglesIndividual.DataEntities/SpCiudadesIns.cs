﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCiudadesIns : StoredProcedure
    {
        public SpCiudadesIns() : base("SpCiudadesIns")
        {
            this.AddParameter("@pNomCiudad", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, 0);
            this.Command.Parameters["@pClaCiudad"].Direction = System.Data.ParameterDirection.Output;
            
        }

        public string NomCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNomCiudad"].Value, ""); }
            set { this.Command.Parameters["@pNomCiudad"].Value = value; }
        }
       
        public int ClaEstado
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaEstado"].Value, 0); }
            set { this.Command.Parameters["@pClaEstado"].Value = value; }
        }
        
        public int ClaPais
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaPais"].Value, 0); }
            set { this.Command.Parameters["@pClaPais"].Value = value; }
        }

        public int ClaCiudad
        {
            get { return Utils.IsNull(this.Command.Parameters["@pClaCiudad"].Value, 0); }
            set { this.Command.Parameters["@pClaCiudad"].Value = value; }
        }
    }
}
