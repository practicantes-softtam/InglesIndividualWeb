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
        
        public List<Entities.FwkUsuarios> ListarFwkUsuarios(Entities.JQXGridSettings settings, string IdUsuario)
        {
            DataEntities.SpFwkUsuariosGrd sp = new DataEntities.SpFwkUsuariosGrd();
            List<Entities.FwkUsuarios> list = new List<Entities.FwkUsuarios>();
            sp.IdUsuario = IdUsuario;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkUsuarios item = new Entities.FwkUsuarios(true);
                item.ID = Utils.GetDataRowValue(dr, "IdUsuario", "");
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkUsuarios item = entity as Entities.FwkUsuarios;
            DataEntities.SpFwkUsuariosIns sp = new DataEntities.SpFwkUsuariosIns();
            sp.IdUsuario = item.ID;
            sp.NomUsuario = item.Nombre;
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
            sp.IdUsuario = item.ID;

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

