using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class FwkUsuariosSistemaSeguridad : InglesIndividualDataObject
    {

        public List<Entities.FwkUsuariosSistemaSeguridad> ListarFwkUsuariosSistemaSeguridad(Entities.JQXGridSettings settings, int IdRegistro)
        {
            DataEntities.SpFwkUsuariosSistemaSeguridadGrd sp = new DataEntities.SpFwkUsuariosSistemaSeguridadGrd();
            List<Entities.FwkUsuariosSistemaSeguridad> list = new List<Entities.FwkUsuariosSistemaSeguridad>();
            sp.IdRegistro = IdRegistro;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkUsuariosSistemaSeguridad item = new Entities.FwkUsuariosSistemaSeguridad(true);
                item.IdRegistro = Utils.GetDataRowValue(dr, "IdRegistro", 0);
                item.IdUsuario = Utils.GetDataRowValue(dr, "IdUsuario", "");
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkUsuariosSistemaSeguridad item = entity as Entities.FwkUsuariosSistemaSeguridad;
            DataEntities.SpFwkUsuariosSistemaSeguridadIns sp = new DataEntities.SpFwkUsuariosSistemaSeguridadIns();
            sp.IdRegistro = item.IdRegistro;
            sp.IdUsuario = item.IdUsuario;
            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.FwkUsuariosSistemaSeguridad item = entity as Entities.FwkUsuariosSistemaSeguridad;
            DataEntities.SpFwkUsuariosSistemaSeguridadDel sp = new DataEntities.SpFwkUsuariosSistemaSeguridadDel();
            sp.IdRegistro = item.IdRegistro;

            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }
        }

    }
}
