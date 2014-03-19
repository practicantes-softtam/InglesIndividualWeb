using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class FwkUsuarios
    {
         public List<Entities.FwkUsuarios> ListarFwkUsuarios(InglesIndividual.Entities.JQXGridSettings settings, string IdUsuario, string NomUsuario, string Password, string Email)
        {
            List<Entities.FwkUsuarios> list = new List<Entities.FwkUsuarios>();
            DataEntities.SpFwkUsuariosGrd sp = new DataEntities.SpFwkUsuariosGrd();
            sp.IdUsuario = IdUsuario;
            sp.NomUsuario = NomUsuario;
            sp.Password = Password;
            sp.Email = Email;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
         {
                Entities.FwkUsuarios item = new Entities.FwkUsuarios(true);
                item.IdUsuario = Utils.GetDataRowValue(dr, "IdUsuario", "");
                item.NomUsuario = Utils.GetDataRowValue(dr, "NomUsuario", "");
                item.Password = new Entities.tado();
                item.Estado.Nombre = Utils.GetDataRowValue(dr, "NomEstado", "");
                item.Estado.Pais = new Entities.Pais();
                item.Estado.Pais.Nombre = Utils.GetDataRowValue(dr, "NomPais", "");   
                
                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkUsuarios item = entity as Entities.FwkUsuarios;
            DataEntities.SpFwkUsuariosIns
                sp = new DataEntities.SpFwkUsuariosIns();
            sp.ClaCiudad = item.Clave;
            sp.ClaEstado = item.Estado.Clave;
            sp.ClaPais = item.Estado.Pais.Clave;
            
            if (tran !=null) {
            return sp.ExecuteNonQuery(tran);
                
            }
            else { 
            return sp.ExecuteNonQuery (this.ConnectionString);
            }

            

        }


        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.FwkUsuarios item = entity as Entities.FwkUsuarios;
            DataEntities.SpFwkUsuariosDel
                sp = new DataEntities.SpFwkUsuariosDel();
            sp.ClaCiudad = item.Clave;
            

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

    }
}
