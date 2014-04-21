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

                item.ClaEncuesta = Utils.GetDataRowValue(dr, "ClaEncuesta", 0);
                item.NomEncuesta = Utils.GetDataRowValue(dr, "NomEncuesta", "");

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
            sp.ClaEncuesta = item.ClaEncuesta;
            sp.NomEncuesta = item.NomEncuesta;

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
            Entities.Encuestas item = entity as Entities.Encuestas;
            DataEntities.SpEncuestasDel
                sp = new DataEntities.SpEncuestasDel();
            sp.ClaEncuesta = item.ClaEncuesta;

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

