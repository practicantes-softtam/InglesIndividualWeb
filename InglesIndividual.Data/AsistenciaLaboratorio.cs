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

                item.ID = Utils.GetDataRowValue(dr, "IdAsistenciaLaboratorio", 0);
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
            sp.IdAsistenciaLaboratorio = item.ID;
            sp.ClaCampus = item.Campus.ID;
            //sp.IdAsistenciaLaboratorio = item.IdAsistenciaLaboratorio;
            //sp.ClaCampus = item.Campus.ID;
            sp.Matricula = item.Matricula;
            sp.Fecha = item.Fecha;
           

          //  if (tran != null)
            {
          //      return sp.ExecuteNonQuery(tran);

          //  }
          //  else
          //  {
                return sp.ExecuteNonQuery(this.ConnectionString);
          //  }
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.AsistenciaLaboratorio item = entity as Entities.AsistenciaLaboratorio;
            DataEntities.SpAsistenciaLaboratorioDel
                sp = new DataEntities.SpAsistenciaLaboratorioDel();
            sp.IdAsistenciaLaboratorio = item.ID;

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
            Entities.AsistenciaLaboratorio item = entity as Entities.AsistenciaLaboratorio;
            DataEntities.SpAsistenciaLaboratorioUpd sp = new DataEntities.SpAsistenciaLaboratorioUpd();
           sp.IdAsistenciaLaboratorio = item.ID;
            sp.ClaCampus = item.Campus.ID;
            sp.Matricula = item.Matricula;
            sp.Fecha = item.Fecha;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.AsistenciaLaboratorio item = entity as Entities.AsistenciaLaboratorio;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpAsistenciaLaboratorioSel sp = new DataEntities.SpAsistenciaLaboratorioSel();
                sp.IdAsistenciaLaboratorio = item.ID;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {

                     item.ID = Utils.GetDataRowValue(dt.Rows[0],"IdAsistenciaLaboratorio", 0);
                item.Campus = new Entities.Campus();
                item.Campus.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaCampus", 0);
                item.Matricula = Utils.GetDataRowValue(dt.Rows[0], "Matricula", "");
                item.Fecha = Utils.GetDataRowValue(dt.Rows[0],"Fecha", 0);
                }
            }
        }

    }
}
