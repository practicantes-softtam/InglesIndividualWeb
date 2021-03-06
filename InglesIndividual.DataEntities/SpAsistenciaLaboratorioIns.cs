﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpAsistenciaLaboratorioIns: StoredProcedure
    {
         public SpAsistenciaLaboratorioIns()
            : base("SpAsistenciaLaboratorioIns")
        {
            this.AddParameter("@pClaCampus", System.Data.SqlDbType.Int, DBNull.Value);
        this.AddParameter("@pMatricula", System.Data.SqlDbType.VarChar, DBNull.Value);
        this.AddParameter("@pFecha", System.Data.SqlDbType.DateTime, DBNull.Value);
        this.AddParameter("@pIdAsistenciaLaboratorio", System.Data.SqlDbType.Int, DBNull.Value);
        this.Command.Parameters["@pIdAsistenciaLaboratorio"].Direction = System.Data.ParameterDirection.Output;
    }
         public int ClaCampus
         {
             get { return Utils.IsNull(this.Command.Parameters["@pClaCampus"].Value, 0); }
             set { this.Command.Parameters["@pClaCampus"].Value = value; }
         }

         public string Matricula
         {
             get { return Utils.IsNull(this.Command.Parameters["@pMatricula"].Value, ""); }
             set { this.Command.Parameters["@pMatricula"].Value = value; }
         }

         public int Fecha
         {
             get { return Utils.IsNull(this.Command.Parameters["@pFecha"].Value, 0); }
             set { this.Command.Parameters["@pFecha"].Value = value; }
         }

         public int IdAsistenciaLaboratorio
         {
             get { return Utils.IsNull(this.Command.Parameters["@pIdAsistenciaLaboratorio"].Value, 0); }
             set { this.Command.Parameters["@pIdAsistenciaLaboratorio"].Value = value; }
         }
    }
}
