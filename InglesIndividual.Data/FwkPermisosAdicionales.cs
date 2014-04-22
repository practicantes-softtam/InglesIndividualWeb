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
        public List<Entities.FwkPermisosAdicionales> ListarPermisosAdicionales(InglesIndividual.Entities.JQXGridSettings settings, string idUsuario, int claAplicacion, int claModulo, int claObjeto, string claAccion, int permitir)
        {
            List<Entities.FwkPermisosAdicionales> list = new List<Entities.FwkPermisosAdicionales>();
            DataEntities.SpFwkPermisosAdicionalesGrd sp = new DataEntities.SpFwkPermisosAdicionalesGrd();
            sp.IdUsuario = idUsuario;
            sp.ClaAplicaion= claAplicacion;
            sp.ClaModulo = claModulo;
            sp.ClaObjeto = claObjeto;
            sp.ClaAccion = claAccion;
            sp.Permitir = permitir;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkPermisosAdicionales item = new Entities.FwkPermisosAdicionales(true);
                item.IdUsuario = new Entities.FwkUsuarios();
                item.IdUsuario.IdUsuario = Utils.GetDataRowValue(dr, "IdUsuario", " ");
                item.ClaAccion = new Entities.FwkAcciones();
                item.ClaAplicacion.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.ClaModulo = new Entities.FwkModulos();
                item.ClaModulo.ClaModulo = Utils.GetDataRowValue(dr, "ClaModulo", 0);
                item.ClaObjeto = new Entities.FwkObjetos();
                item.ClaObjeto.ClaObjeto = Utils.GetDataRowValue(dr, "ClaObjeto", 0);
                item.ClaAccion = new Entities.FwkAcciones();
                item.ClaAccion.ClaAccion = Utils.GetDataRowValue(dr, "ClaAccion", "");
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

            sp.IdUsuario = item.IdUsuario.IdUsuario;
            sp.ClaAplicaion = item.ClaAplicacion.ClaAplicacion;
            sp.ClaModulo = item.ClaModulo.ClaModulo;
            sp.ClaObjeto = item.ClaObjeto.ClaObjeto;
            sp.ClaAccion = item.ClaAccion.ClaAccion;
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

        public override int Update(Entity entity, DataTransaction tran)
        {
            Entities.FwkPermisosAdicionales item = entity as Entities.FwkPermisosAdicionales;
            DataEntities.SpFwkPermisosAdicionalesUpd
               sp = new DataEntities.SpFwkPermisosAdicionalesUpd();
            sp.IdUsuario = item.IdUsuario.IdUsuario;
            sp.ClaAplicaion = item.ClaAplicacion.ClaAplicacion;
            sp.ClaModulo = item.ClaModulo.ClaModulo;
            sp.ClaObjeto = item.ClaObjeto.ClaObjeto;
            sp.ClaAccion = item.ClaAccion.ClaAccion;
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
            sp.IdUsuario = item.IdUsuario.IdUsuario;
            sp.ClaAplicaion = item.ClaAplicacion.ClaAplicacion;
            sp.ClaModulo = item.ClaModulo.ClaModulo;
            sp.ClaObjeto = item.ClaObjeto.ClaObjeto;
            sp.ClaAccion = item.ClaAccion.ClaAccion;
            
           

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

