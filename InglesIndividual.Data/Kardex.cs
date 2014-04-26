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

        public List<Entities.Kardex> ListarKardex(Entities.JQXGridSettings settings, string Matricula)
        {
            DataEntities.SpKardexGrd sp = new DataEntities.SpKardexGrd();
            List<Entities.Kardex> list = new List<Entities.Kardex>();
            sp.Matricula = Matricula;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Kardex item = new Entities.Kardex(true);
                item.Matricula = Utils.GetDataRowValue(dr, "Matricula", "");                
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
            sp.ClaCampus = item.ClaCampus.Clave;
            sp.ClaNivel = item.ClaNivel.ClaNivel;
            sp.ClaLeccion = item.ClaLeccion.Clave;
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
            sp.Matricula = item.Matricula;

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

