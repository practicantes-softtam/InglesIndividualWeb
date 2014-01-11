using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class PagedStoredProcedure : StoredProcedure
    {
        public static string COL_TOTAL_REGISTROS = "TotalRegistros";

        public PagedStoredProcedure(string name)
            : base(name)
        {
            this.AddParameter("@pTamanioPagina", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pNumPagina", System.Data.SqlDbType.Int, 0);
            this.AddParameter("@pOrdenarPor", System.Data.SqlDbType.VarChar, "");
        }

        public int TamanioPagina
        {
            get { return Utils.IsNull(this.Command.Parameters["@pTamanioPagina"].Value, 0); }
            set { this.Command.Parameters["@pTamanioPagina"].Value = value; }
        }

        public int NumPagina
        {
            get { return Utils.IsNull(this.Command.Parameters["@pNumPagina"].Value, 0); }
            set { this.Command.Parameters["@pNumPagina"].Value = value; }
        }

        public string OrdenarPor
        {
            get { return Utils.IsNull(this.Command.Parameters["@pOrdenarPor"].Value, ""); }
            set 
            {
                if (value != null)
                {
                    this.Command.Parameters["@pOrdenarPor"].Value = value;
                }
                else
                {
                    this.Command.Parameters["@pOrdenarPor"].Value = DBNull.Value;
                }
            }
        }
    }
}
