using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class FwkUsuarios : InglesIndividualDataObject
    {
        
        public List<Entities.FwkUsuarios> ListarFwkUsuarios(Entities.JQXGridSettings settings, string IdUsuario, string NomUsuario)
        {
            DataEntities.SpFwkUsuariosGrd sp = new DataEntities.SpFwkUsuariosGrd();
            List<Entities.FwkUsuarios> list = new List<Entities.FwkUsuarios>();

            sp.IdUsuario = IdUsuario;
            sp.NomUsuario = NomUsuario;
           this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkUsuarios item = new Entities.FwkUsuarios(true);
                item.Password = Utils.GetDataRowValue(dr, "Password", "");
                item.Email = Utils.GetDataRowValue(dr, "Email", "");
                item.NomUsuario = Utils.GetDataRowValue(dr, "NomUsuario", "");
               

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public int pais { get; set; }
    }
}
