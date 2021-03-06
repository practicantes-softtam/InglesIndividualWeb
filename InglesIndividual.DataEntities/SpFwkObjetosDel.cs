﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
   public  class SpFwkObjetoDel :StoredProcedure
    {

       public SpFwkObjetoDel(): base("spFwkObjetosDel")
       {

           this.AddParameter("@pClaAplicacion", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaModulo", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pClaObjeto", System.Data.SqlDbType.Int, 0);

       }
      
       public int ClaAplicaion
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaAplicaion"].Value, 0); }
           set { this.Command.Parameters["@pClaAplicacion"].Value = value; }
       }

       public int ClaModulo
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaModulo"].Value, 0); }
           set { this.Command.Parameters["@pClaModulo"].Value = value; }
       }

       public int ClaObjeto
       {
           get { return Utils.IsNull(this.Command.Parameters["@pClaObjeto"].Value, 0); }
           set { this.Command.Parameters["@pClaObjeto"].Value = value; }
       }

      
    }
}
