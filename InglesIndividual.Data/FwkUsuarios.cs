using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class FwkUsuarios : InglesIndividualDataObject
    {
        
        public List<Entities.FwkUsuarios> ListarFwkUsuarios(Entities.JQXGridSettings settings, string NomUsuario)
        {
            DataEntities.SpFwkUsuariosGrd sp = new DataEntities.SpFwkUsuariosGrd();
            List<Entities.FwkUsuarios> list = new List<Entities.FwkUsuarios>();
            sp.NomUsuario = NomUsuario;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkUsuarios item = new Entities.FwkUsuarios(true);
                item.Password = Utils.GetDataRowValue(dr, "Password", "");
                item.Email = Utils.GetDataRowValue(dr, "Email", "");
                item.NomUsuario = Utils.GetDataRowValue(dr, "NomUsuario", "");
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkUsuarios item = entity as Entities.FwkUsuarios;
            DataEntities.SpFwkUsuariosIns sp = new DataEntities.SpFwkUsuariosIns();
            sp.IdUsuario = item.IdUsuario;
            sp.NomUsuario = item.NomUsuario;
            sp.Password = item.Password;
            sp.Email = item.Email;
             if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }

        }

        public override int  Delete(Entity entity, DataTransaction tran)
        {
            Entities.FwkUsuarios item = entity as Entities.FwkUsuarios;
            DataEntities.SpFwkUsuariosDel sp = new DataEntities.SpFwkUsuariosDel();
            sp.IdUsuario = item.IdUsuario;

            if (tran != null)
            {
                return sp.ExecuteNonQuery (tran);
            } 
            else
            {
                return sp.ExecuteNonQuery (this.ConnectionString);        
            }
        }

     }
 }

