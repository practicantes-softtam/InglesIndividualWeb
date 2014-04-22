using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class FwkUsuarioAplicacion : InglesIndividualDataObject
    {
        public List<Entities.FwkUsuarioAplicacion> ListarFwkUsuarioAplicacion(InglesIndividual.Entities.JQXGridSettings settings, int claAplicacion,string idUsuario)
        {
            List<Entities.FwkUsuarioAplicacion> list = new List<Entities.FwkUsuarioAplicacion>();
            DataEntities.SpFwkUsuariosAplicacionGrd sp = new DataEntities.SpFwkUsuariosAplicacionGrd();
            sp.ClaAplicacion = claAplicacion;
            sp.IdUsuario=idUsuario;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkUsuarioAplicacion item = new Entities.FwkUsuarioAplicacion(true);
                item.FwkAplicacion = new Entities.FwkAplicaciones();
                item.FwkAplicacion.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.FwkUsuario = new Entities.FwkUsuarios();
                item.FwkUsuario.IdUsuario = Utils.GetDataRowValue(dr, "IdUsuario", "");


                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkUsuarioAplicacion item = entity as Entities.FwkUsuarioAplicacion;
            DataEntities.SpFwkUsuarioAplicacionIns
               sp = new DataEntities.SpFwkUsuarioAplicacionIns();
            sp.ClaAplicaion = item.FwkAplicacion.ClaAplicacion;
            sp.IdUsuario = item.FwkUsuario.IdUsuario;



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
            Entities.FwkUsuarioAplicacion item = entity as Entities.FwkUsuarioAplicacion;
            DataEntities.SpFwkUsuarioAplicacionDel
               sp = new DataEntities.SpFwkUsuarioAplicacionDel();
            sp.ClaAplicaion = item.FwkAplicacion.ClaAplicacion;
            sp.IdUsuario = item.FwkUsuario.IdUsuario;


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
