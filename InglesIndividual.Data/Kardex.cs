using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class Kardex : InglesIndividualDataObject
    {

        public List<Entities.Kardex> ListarKardex(Entities.JQXGridSettings settings, int IdCalificacion)
        {
            DataEntities.SpKardexGrd sp = new DataEntities.SpKardexGrd();
            List<Entities.Kardex> list = new List<Entities.Kardex>();
            sp.IdCalificacion = IdCalificacion;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Kardex item = new Entities.Kardex(true);
                item.IdCalificacion = Utils.GetDataRowValue(dr, "IdCalificacion", 0);
                item.Matricula = Utils.GetDataRowValue(dr, "Matricula", "");
                item.ClaCampus = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.ClaNivel = Utils.GetDataRowValue(dr, "ClaNivel", 0);
                item.ClaLeccion = Utils.GetDataRowValue(dr, "ClaLeccion", 0);
                item.ClaProfesor = Utils.GetDataRowValue(dr, "ClaProfesor", 0);
                item.Calificacion = Utils.GetDataRowValue(dr, "Calificacion", 0);
                item.TipoClase = Utils.GetDataRowValue(dr, "TipoClase", 0);
                item.Fecha = Utils.GetDataRowValue(dr, "Fecha", DateTime.MinValue);
                item.ClaCalificacion = Utils.GetDataRowValue(dr, "ClaCalificacion", 0);
                item.IdCita = Utils.GetDataRowValue(dr, "IdCita", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Kardex item = entity as Entities.Kardex;
            DataEntities.SpKardexIns sp = new DataEntities.SpKardexIns();
            sp.IdCalificacion = item.IdCalificacion;
            sp.Matricula = item.Matricula;
            sp.ClaCampus = item.ClaCampus;
            sp.ClaNivel = item.ClaNivel;
            sp.ClaLeccion = item.ClaLeccion;
            sp.ClaProfesor = item.ClaProfesor;
            sp.Calificacion = item.Calificacion;
            sp.TipoClase = item.TipoClase;
            sp.Fecha = item.Fecha;
            sp.ClaCalificacion = item.ClaCalificacion;
            sp.IdCita = item.IdCita;
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
            Entities.Kardex item = entity as Entities.Kardex;
            DataEntities.SpKardexDel sp = new DataEntities.SpKardexDel();
            sp.IdCalificacion = item.IdCalificacion;

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

