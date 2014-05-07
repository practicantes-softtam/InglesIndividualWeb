using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Encuestas : InglesIndividualDataObject
    {
        public List<Entities.Encuestas> ListarEncuestas(InglesIndividual.Entities.JQXGridSettings settings, string nomEncuesta)
        {
            List<Entities.Encuestas> list = new List<Entities.Encuestas>();
            DataEntities.SpEncuestasGrd sp = new DataEntities.SpEncuestasGrd();
            sp.NomEncuesta = nomEncuesta;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Encuestas item = new Entities.Encuestas(true);

                item.ID = Utils.GetDataRowValue(dr, "ClaEncuesta", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomEncuesta", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Encuestas item = entity as Entities.Encuestas;
            DataEntities.SpEncuestasIns
                sp = new DataEntities.SpEncuestasIns();
            sp.ClaEncuesta = item.ID;
            sp.NomEncuesta = item.Nombre;

          //  if (tran != null)
          //  {
          //      return sp.ExecuteNonQuery(tran);

          //  }
          //  else
          //  {
                return sp.ExecuteNonQuery(this.ConnectionString);
           // }
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Encuestas item = entity as Entities.Encuestas;
            DataEntities.SpEncuestasDel
                sp = new DataEntities.SpEncuestasDel();
            sp.ClaEncuesta = item.ID;

            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }

        }

        public override int Update(Entity entity)
        {
            Entities.Encuestas item = entity as Entities.Encuestas;
            DataEntities.SpEncuestasUpd sp = new DataEntities.SpEncuestasUpd();
            sp.ClaEncuesta = item.ID;
            sp.NomEncuesta = item.Nombre;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Encuestas item = entity as Entities.Encuestas;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpEncuestasSel sp = new DataEntities.SpEncuestasSel();
                sp.ClaEncuesta = item.ID;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {

                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaEncuesta", 0);
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomEncuesta", "");
                }
            }
        }

    }
}
