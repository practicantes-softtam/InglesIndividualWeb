using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class HorarioClubConversacion: InglesIndividualDataObject
    {
        public List<Entities.HorarioClubConversacion> ListarHorarioClubConversacion(InglesIndividual.Entities.JQXGridSettings settings, int ClaCampus, int ClaEmpleado, int ClaHorario, int ClaDia, int horas)
        {
            DataEntities.SpHorarioClubConversacionGrd sp = new DataEntities.SpHorarioClubConversacionGrd();
            List<Entities.HorarioClubConversacion> list = new List<Entities.HorarioClubConversacion>();
            sp.ClaCampus = ClaCampus;
            sp.ClaEmpleado = ClaEmpleado;
            sp.ClaHorario = ClaHorario;
            sp.ClaDia = ClaDia;
            sp.Horas = horas;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.HorarioClubConversacion item = new Entities.HorarioClubConversacion(true);
                item.Campus = new Entities.Campus();
                item.Campus.ID = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.Empleado = new Entities.Empleados();
                item.Empleado.ClaEmpleado = Utils.GetDataRowValue(dr, "ClaEmpleado", 0);
                item.ClaHorario = Utils.GetDataRowValue(dr, "ClaHorario", 0);
                item.ClaDia = Utils.GetDataRowValue(dr, "ClaDia", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.HorarioClubConversacion item = entity as Entities.HorarioClubConversacion;
            DataEntities.SpHorarioClubConversacionIns sp = new DataEntities.SpHorarioClubConversacionIns();
            sp.ClaCampus = item.Campus.ID;
            sp.ClaEmpleado = item.Empleado.ClaEmpleado;
            sp.ClaHorario = item.ClaHorario;
            sp.ClaDia = item.ClaDia;
            sp.Horas = item.Horas;
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
            Entities.HorarioClubConversacion item = entity as Entities.HorarioClubConversacion;
            DataEntities.SpHorarioClubConversacionDel sp = new DataEntities.SpHorarioClubConversacionDel();
            sp.ClaCampus = item.Campus.ID;
            sp.ClaEmpleado = item.Empleado.ClaEmpleado;
            sp.ClaHorario = item.ClaHorario;
            sp.Horas = item.Horas;
            sp.ClaDia = item.ClaDia;

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
