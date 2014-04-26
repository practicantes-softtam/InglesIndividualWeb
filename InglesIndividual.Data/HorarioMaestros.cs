using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class HorarioMaestros : InglesIndividualDataObject
    {
        public List<Entities.HorarioMaestros> ListarHorarioMaestros(Entities.JQXGridSettings settings, int ClaEmpleado, int ClaCampus, int ClaHorario)
        {
            DataEntities.SpFwkHorarioMaestrosGrd sp = new DataEntities.SpFwkHorarioMaestrosGrd();
            List<Entities.HorarioMaestros> list = new List<Entities.HorarioMaestros>();
            sp.ClaEmpleado = ClaEmpleado;
            sp.ClaCampus = ClaCampus;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.HorarioMaestros item = new Entities.HorarioMaestros(true);
                item.Empleado = new Entities.Empleados();
                item.Empleado.ClaEmpleado = Utils.GetDataRowValue(dr, "ClaEmpleado", 0);
                item.ClaCampus = new Entities.Campus();
                item.ClaCampus.Clave = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.ClaHorario = Utils.GetDataRowValue(dr, "ClaHorario", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }
            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.HorarioMaestros item = entity as Entities.HorarioMaestros;
            DataEntities.SpFwkHorarioMaestrosIns sp = new DataEntities.SpFwkHorarioMaestrosIns();
            sp.ClaEmpleado = item.Empleado.ClaEmpleado;
            sp.ClaCampus = item.ClaCampus.Clave;
            sp.ClaHorario = item.ClaHorario;
            sp.Lun = item.Lun;
            sp.Mar = item.Mar;
            sp.Mie = item.Mie;
            sp.Jue = item.Jue;
            sp.Vie = item.Vie;
            sp.Sab = item.Sab;
            sp.Dom = item.Dom;
            sp.OrdenLun = item.OrdenLun;
            sp.OrdenMar = item.OrdenMar;
            sp.OrdenMie = item.OrdenMie;
            sp.OrdenJue = item.OrdenJue;
            sp.OrdenVie = item.OrdenVie;
            sp.OrdenSab = item.OrdenSab;
            sp.OrdenDom = item.OrdenDom;
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
            Entities.HorarioMaestros item = entity as Entities.HorarioMaestros;
            DataEntities.SpHorarioMaestrosDel sp = new DataEntities.SpHorarioMaestrosDel();
            sp.ClaEmpleado = item.Empleado.ClaEmpleado;
            sp.ClaCampus = item.ClaCampus.Clave;
            sp.ClaHorario = item.ClaHorario;
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

