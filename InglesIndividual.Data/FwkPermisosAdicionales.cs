using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class FwkPermisosAdicionales : InglesIndividualDataObject
    {
        public List<Entities.FwkPermisosAdicionales> ListarPaises(InglesIndividual.Entities.JQXGridSettings settings, int permitir)
        {
            List<Entities.FwkPermisosAdicionales> list = new List<Entities.FwkPermisosAdicionales>();
            DataEntities.SpFwkPermisosAdicionalesGrd sp = new DataEntities.SpFwkPermisosAdicionalesGrd();
            sp.Permitir = permitir;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkPermisosAdicionales item = new Entities.FwkPermisosAdicionales(true);
                item.IdUsuario = Utils.GetDataRowValue(dr, "IdUsuario", " ");
                item.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.ClaModulo = Utils.GetDataRowValue(dr, "ClaModulo", 0);
                item.ClaObjeto = Utils.GetDataRowValue(dr, "ClaObjeto", 0);
                item.ClaAccion = Utils.GetDataRowValue(dr, "ClaAccion", "");
                item.Permitir = Utils.GetDataRowValue(dr, "Permitir", 0);
                

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkPermisosAdicionales item = entity as Entities.FwkPermisosAdicionales;
            DataEntities.SpFwkPermisosAdicionalesIns
               sp = new DataEntities.SpFwkPermisosAdicionalesIns();
            sp.IdUsuario = item.IdUsuario;
            sp.ClaAplicaion = item.ClaAplicacion;
            sp.ClaModulo = item.ClaModulo;
            sp.ClaObjeto = item.ClaObjeto;
            sp.ClaAccion = item.ClaAccion;
            sp.Permitir = item.Permitir;
            


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
            Entities.FwkPermisosAdicionales item = entity as Entities.FwkPermisosAdicionales;
            DataEntities.SpFwkPermisosAdicionalesDel
               sp = new DataEntities.SpFwkPermisosAdicionalesDel();
            sp.IdUsuario = item.IdUsuario;
            sp.ClaAplicaion = item.ClaAplicacion;
            sp.ClaModulo = item.ClaModulo;
            sp.ClaObjeto = item.ClaObjeto;
            sp.ClaAccion = item.ClaAccion;
           

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

