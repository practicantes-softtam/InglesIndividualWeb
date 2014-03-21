using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class FwkUsusarioPerfil : InglesIndividualDataObject
    {
        public List<Entities.FwkUsuarioPerfil> ListarPaises(InglesIndividual.Entities.JQXGridSettings settings, string idUsuario,int claAplicacion,int claPerfil)

        {
            List<Entities.FwkUsuarioPerfil> list = new List<Entities.FwkUsuarioPerfil>();
            DataEntities.SpFwkUsuariosPerfilGrd sp = new DataEntities.SpFwkUsuariosPerfilGrd();
            sp.ClaAplicacion = claAplicacion;
            sp.IdUsuario = idUsuario;
            sp.ClaPerfil = claPerfil;
            sp.ClaAplicacion = claAplicacion;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkUsuarioPerfil item = new Entities.FwkUsuarioPerfil(true);
                item.IsUsuario = Utils.GetDataRowValue(dr, "IdUsuario", "");
                item.ClaPerfil = Utils.GetDataRowValue(dr, "ClaPermil", 0);
                item.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkUsuarioPerfil item = entity as Entities.FwkUsuarioPerfil;
            DataEntities.SpFwkUsuarioPerfilIns
               sp = new DataEntities.SpFwkUsuarioPerfilIns();
           
            sp.IdUsuario = item.IsUsuario;
            sp.ClaAplicaion = item.ClaAplicacion;
            sp.ClaPerfil = item.ClaPerfil;


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
            Entities.FwkUsuarioPerfil item = entity as Entities.FwkUsuarioPerfil;
            DataEntities.SpFwkUsuarioPerfilDel
               sp = new DataEntities.SpFwkUsuarioPerfilDel();

            sp.IdUsuario = item.IsUsuario;
            sp.ClaAplicaion = item.ClaAplicacion;
            sp.ClaPerfil = item.ClaPerfil;


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
