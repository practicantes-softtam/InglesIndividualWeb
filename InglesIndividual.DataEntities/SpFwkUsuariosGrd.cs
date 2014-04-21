using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.DataEntities
{
    public class SpFwkUsuariosGrd : PagedStoredProcedure
    {
        public SpFwkUsuariosGrd() : base("SpFwkUsuariosGrd")
        {
            this.AddParameter("@pIdUsuario", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pNomUsuario", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pPassword", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.AddParameter("@pEmail", System.Data.SqlDbType.VarChar, DBNull.Value);
            this.Command.Parameters["@pIdUsuario"].Direction = System.Data.ParameterDirection.Output;

        }

        
        public string IdUsuario
        {
            get { return Utils.IsNull(this.Command.Parameters["@pIdUsuario"].Value, ""); }
            set
            {
                if (value == null)
                {
                    this.Command.Parameters["@pIdUsuario"].Value = DBNull.Value;
                }
                else
                {
                    this.Command.Parameters["@pIdUsuario"].Value = value;
                }
            }
            
        }
                
        }
    }
