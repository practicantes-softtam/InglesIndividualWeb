using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class Nivel : InglesIndividualDataObject
    {
        public List<Entities.Nivel> ListarNivel(Entities.JQXGridSettings settings, int ClaNivel)
        {
            DataEntities.SpNivelesGrd sp = new DataEntities.SpNivelesGrd();
            List<Entities.Nivel> list = new List<Entities.Nivel>();
            sp.ClaNivel = ClaNivel;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Nivel item = new Entities.Nivel(true);
                item.ClaNivel = Utils.GetDataRowValue(dr, "ClaNivel", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }
            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Nivel item = entity as Entities.Nivel;
            DataEntities.SpNivelesIns sp = new DataEntities.SpNivelesIns();
            sp.ClaNivel = item.ClaNivel;
            sp.NomNivel = item.NomNivel;
            sp.ClubConversacion = item.ClubConversacion;
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
            Entities.Nivel item = entity as Entities.Nivel;
            DataEntities.SpNivelesDel sp = new DataEntities.SpNivelesDel();
            sp.ClaNivel = item.ClaNivel;
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

