﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpCiudadesGrd : PagedStoredProcedure
     {
    
        public SpCiudadesGrd(): base ("SpCiudadesGrd")
     {
            this.AddParameter("@pNomCiudad", System.Data.SqlDbType.VarChar, DBNull.Value);
            //this.AddParameter("@pClaCiudad", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaEstado", System.Data.SqlDbType.Int, DBNull.Value);
            this.AddParameter("@pClaPais", System.Data.SqlDbType.Int, DBNull.Value);
            
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
    }
    }

