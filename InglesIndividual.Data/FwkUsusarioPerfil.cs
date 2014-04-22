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
        public List<Entities.FwkUsuarioPerfil> ListarFwkUsuarioPerfil(InglesIndividual.Entities.JQXGridSettings settings, string idUsuario, int claAplicacion, int claPerfil)
        {
            List<Entities.FwkUsuarioPerfil> list = new List<Entities.FwkUsuarioPerfil>();
            DataEntities.SpFwkUsuariosPerfilGrd sp = new DataEntities.SpFwkUsuariosPerfilGrd();
            sp.ClaAplicacion = claAplicacion;
            sp.IdUsuario = idUsuario;
            sp.ClaAplicacion = claAplicacion;
            sp.ClaPerfil = claPerfil;
            
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkUsuarioPerfil item = new Entities.FwkUsuarioPerfil(true);
                item.IdUsuario = new Entities.FwkUsuarios();
                item.IdUsuario.IdUsuario = Utils.GetDataRowValue(dr, "IdUsuario", "");
                item.ClaAplicacion = new Entities.FwkAplicaciones();
                item.ClaAplicacion.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.ClaPerfil = new Entities.FwkPerfiles();
                item.ClaPerfil.ClaPerfil = Utils.GetDataRowValue(dr, "ClaPerfil", 0);


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

            sp.IdUsuario = item.IdUsuario.IdUsuario;
            sp.ClaAplicaion = item.ClaAplicacion.ClaAplicacion;
            sp.ClaPerfil = item.ClaPerfil.ClaPerfil;


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

            sp.IdUsuario = item.IdUsuario.IdUsuario;
            sp.ClaAplicaion = item.ClaAplicacion.ClaAplicacion;
            sp.ClaPerfil = item.ClaPerfil.ClaPerfil;


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
