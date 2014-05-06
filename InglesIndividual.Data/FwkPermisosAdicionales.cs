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
                item.FwkUsuario = new Entities.FwkUsuarios();
                item.FwkUsuario.ID = Utils.GetDataRowValue(dr, "IdUsuario", " ");
                item.FwkAcciones = new Entities.FwkAcciones();
                item.FwkAplicaciones.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.FwkModulos = new Entities.FwkModulos();
                item.FwkModulos.ClaModulo = Utils.GetDataRowValue(dr, "ClaModulo", 0);
                item.FwkObjetos = new Entities.FwkObjetos();
                item.FwkObjetos.ClaObjeto = Utils.GetDataRowValue(dr, "ClaObjeto", 0);
                item.FwkAcciones = new Entities.FwkAcciones();
                item.FwkAcciones.ClaAccion = Utils.GetDataRowValue(dr, "ClaAccion", "");
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

            sp.IdUsuario = item.FwkUsuario.ID;
            sp.ClaAplicaion = item.FwkAplicaciones.ClaAplicacion;
            sp.ClaModulo = item.FwkModulos.ClaModulo;
            sp.ClaObjeto = item.FwkObjetos.ClaObjeto;
            sp.ClaAccion = item.FwkAcciones.ClaAccion;
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
            sp.IdUsuario = item.FwkUsuario.ID;
            sp.ClaAplicaion = item.FwkAplicaciones.ClaAplicacion;
            sp.ClaModulo = item.FwkModulos.ClaModulo;
            sp.ClaObjeto = item.FwkObjetos.ClaObjeto;
            sp.ClaAccion = item.FwkAcciones.ClaAccion;
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
            sp.IdUsuario = item.FwkUsuario.ID;
            sp.ClaAplicaion = item.FwkAplicaciones.ClaAplicacion;
            sp.ClaModulo = item.FwkModulos.ClaModulo;
            sp.ClaObjeto = item.FwkObjetos.ClaObjeto;
            sp.ClaAccion = item.FwkAcciones.ClaAccion;
            
           

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

