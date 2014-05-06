using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class AsistenciaLaboratorio : InglesIndividualDataObject
    {
        public List<Entities.AsistenciaLaboratorio> ListarAsistenciaLaboratorio(InglesIndividual.Entities.JQXGridSettings settings, DateTime fecha)
        {
            List<Entities.AsistenciaLaboratorio> list = new List<Entities.AsistenciaLaboratorio>();
            DataEntities.SpAsistenciaLaboratorioGrd sp = new DataEntities.SpAsistenciaLaboratorioGrd();
            sp.Fecha = fecha;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.AsistenciaLaboratorio item = new Entities.AsistenciaLaboratorio(true);

                item.IdAsistenciaLaboratorio = Utils.GetDataRowValue(dr, "IdAsistenciaLaboratorio", 0);
                item.Campus = new Entities.Campus();
                item.Campus.ID = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.Matricula = Utils.GetDataRowValue(dr, "Matricula", "");
                item.Fecha = Utils.GetDataRowValue(dr, "Fecha", 0);
                

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.AsistenciaLaboratorio item = entity as Entities.AsistenciaLaboratorio;
            DataEntities.SpAsistenciaLaboratorioIns
                sp = new DataEntities.SpAsistenciaLaboratorioIns();
            sp.IdAsistenciaLaboratorio = item.IdAsistenciaLaboratorio;
            sp.ClaCampus = item.Campus.ID;
            sp.Matricula = item.Matricula;
            sp.Fecha = item.Fecha;
           

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
            Entities.AsistenciaLaboratorio item = entity as Entities.AsistenciaLaboratorio;
            DataEntities.SpAsistenciaLaboratorioDel
                sp = new DataEntities.SpAsistenciaLaboratorioDel();
            sp.IdAsistenciaLaboratorio = item.IdAsistenciaLaboratorio;

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
