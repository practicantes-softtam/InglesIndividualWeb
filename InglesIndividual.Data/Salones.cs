using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class Salones : InglesIndividualDataObject
    {
        private string NomSalon;
        public List<Entities.Salones> ListarSalones(InglesIndividual.Entities.JQXGridSettings settings, string descripcion)
        {
            List<Entities.Salones> list = new List<Entities.Salones>();
            DataEntities.SpSalonesGrd sp = new DataEntities.SpSalonesGrd();
            sp.NomSalon = NomSalon;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Salones item = new Entities.Salones(true);

                item.IdSalon = Utils.GetDataRowValue(dr, "IdSalon", 0);
                item.NomSalon = Utils.GetDataRowValue(dr, "NomSalon", "");
               
                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Salones item = entity as Entities.Salones;
            DataEntities.SpSalonesIns
            sp = new DataEntities.SpSalonesIns();
            sp.IdSalon = item.IdSalon;
            sp.NomSalon = item.NomSalon;
               
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
            Entities.Salones item = entity as Entities.Salones;
            DataEntities.SpSalonesDel
            sp = new DataEntities.SpSalonesDel();
            sp.IdSalon = item.IdSalon;
           

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