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
                item.FwkUsuario = new Entities.FwkUsuarios();
                item.FwkUsuario.IdUsuario = Utils.GetDataRowValue(dr, "IdUsuario", "");
                item.FwkAplicacion = new Entities.FwkAplicaciones();
                item.FwkAplicacion.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.FwkPerfil = new Entities.FwkPerfiles();
                item.FwkPerfil.ClaPerfil = Utils.GetDataRowValue(dr, "ClaPerfil", 0);


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

            sp.IdUsuario = item.FwkUsuario.IdUsuario;
            sp.ClaAplicaion = item.FwkAplicacion.ClaAplicacion;
            sp.ClaPerfil = item.FwkPerfil.ClaPerfil;


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

            sp.IdUsuario = item.FwkUsuario.IdUsuario;
            sp.ClaAplicaion = item.FwkAplicacion.ClaAplicacion;
            sp.ClaPerfil = item.FwkPerfil.ClaPerfil;


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
