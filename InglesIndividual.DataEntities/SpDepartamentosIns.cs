
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
   public class SpDepartamentosIns : StoredProcedure
    {
       public SpDepartamentosIns()
            : base("SpDepartamentosIns")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pNomDepartamento", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pClaDepartamento", System.Data.SqlDbType.Int, DBNull.Value);
            this.Command.Parameters["@pClaDepartamento"].Direction = System.Data.ParameterDirection.Output;
   }
       public int ClaCampus
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
           set { this.Command.Parameters["@pClaCampus"].Value = value; }
       }

       public string NomDepartamento
       {
           get { return Utils.IsNull(this.Command.Parameters["@pNomDepartamento"].Value, ""); }
           set { this.Command.Parameters["@pNomDepartamento"].Value = value; }
       }

       public int ClaDepartamento
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaDepartamento"].Value, 0); }
           set { this.Command.Parameters["@pClaDepartamento"].Value = value; }
       }
    }
}