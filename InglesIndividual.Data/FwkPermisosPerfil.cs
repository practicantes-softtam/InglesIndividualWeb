using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class FwkPermisosPerfil : InglesIndividualDataObject
    {
        public List<Entities.FwkPermisosPerfil> ListarFwkPerimisosPerfil(InglesIndividual.Entities.JQXGridSettings settings,int claAplicacion, int claPerfil, int ClaModulo, int claObjeto, string claAccion, int permitir)
        {
            List<Entities.FwkPermisosPerfil> list = new List<Entities.FwkPermisosPerfil>();
            DataEntities.SpFwkPermisosPerfilGrd sp = new DataEntities.SpFwkPermisosPerfilGrd();
            sp.ClaAplicacion = claAplicacion;
            sp.ClaPerfil = claPerfil;
            sp.ClaModulo = ClaModulo;
            sp.ClaObjeto = claObjeto;
            sp.ClaAccion = claAccion;
            sp.Permitir = permitir;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkPermisosPerfil item = new Entities.FwkPermisosPerfil(true);
                item.ClaAplicacion = new Entities.FwkAplicaciones();
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
            Entities.FwkPermisosPerfil item = entity as Entities.FwkPermisosPerfil;
            DataEntities.SpFwkPermisosPerfilIns
               sp = new DataEntities.SpFwkPermisosPerfilIns();
            
            sp.ClaAplicacion = item.ClaAplicacion.ClaAplicacion;
            sp.ClaPerfil = item.ClaPerfil.ClaPerfil;
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
            Entities.FwkPermisosPerfil item = entity as Entities.FwkPermisosPerfil;
            DataEntities.SpFwkPermisosPerfilDel
               sp = new DataEntities.SpFwkPermisosPerfilDel();

            sp.ClaAplicacion = item.ClaAplicacion.ClaAplicacion;
            sp.ClaPerfil = item.ClaPerfil.ClaPerfil;
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

