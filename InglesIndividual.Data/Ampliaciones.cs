using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Ampliaciones : InglesIndividualDataObject
    {

        public List<Entities.Ampliaciones> ListarAmpliaciones(InglesIndividual.Entities.JQXGridSettings settings, string matricula)
        {
            List<Entities.Ampliaciones> list = new List<Entities.Ampliaciones>();
            DataEntities.SpAmpliacionesGrd sp = new DataEntities.SpAmpliacionesGrd();
            sp.Matricula = matricula;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Ampliaciones item = new Entities.Ampliaciones(true);

                item.idAmpliacion = Utils.GetDataRowValue(dr, "IdAmpliacion", 0);
                item.Matricula = Utils.GetDataRowValue(dr, "Matricula", "");
                item.Vigencia = Utils.GetDataRowValue(dr, "Vigencia", 0);
                item.Comentarios = Utils.GetDataRowValue(dr, "Comentarios", "");
                item.Estatus = Utils.GetDataRowValue(dr, "Estatus", 0);
                item.ClaNivel = Utils.GetDataRowValue(dr, "ClaNivel", 0);
                item.ClaLeccion = Utils.GetDataRowValue(dr, "ClaLeccion", 0);

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Ampliaciones item = entity as Entities.Ampliaciones;
            DataEntities.SpAmpliacionesIns
                sp = new DataEntities.SpAmpliacionesIns();
            sp.IdAmpliacion = item.idAmpliacion;
            sp.Matricula = item.Matricula;
            sp.Vigencia = item.Vigencia;
            sp.Comentarios = item.Comentarios;
            sp.Estatus = item.Estatus;
            sp.ClaNivel = item.ClaNivel;
            sp.ClaLeccion = item.ClaLeccion;

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
            Entities.Ampliaciones item = entity as Entities.Ampliaciones;
            DataEntities.SpAmpliacionesDel
                sp = new DataEntities.SpAmpliacionesDel();
            sp.IdAmpliacion = item.idAmpliacion;


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
