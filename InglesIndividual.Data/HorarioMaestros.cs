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
        public List<Entities.HorarioMaestros> ListarHorarioMaestros(Entities.JQXGridSettings settings, int ClaEmpleado)
        {
            DataEntities.SpFwkHorarioMaestrosGrd sp = new DataEntities.SpFwkHorarioMaestrosGrd();
            List<Entities.HorarioMaestros> list = new List<Entities.HorarioMaestros>();
            sp.ClaEmpleado = ClaEmpleado;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.HorarioMaestros item = new Entities.HorarioMaestros(true);
                item.ClaEmpleado = Utils.GetDataRowValue(dr, "ClaEmpleado", 0);
                item.ClaCampus = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.ClaHorario = Utils.GetDataRowValue(dr, "ClaHorario", 0);
                item.Lun = Utils.GetDataRowValue(dr, "Lun", 0);
                item.Mar = Utils.GetDataRowValue(dr, "Mar", 0);
                item.Mie = Utils.GetDataRowValue(dr, "Mie", 0);
                item.Jue = Utils.GetDataRowValue(dr, "Jue", 0);
                item.Vie = Utils.GetDataRowValue(dr, "Vie", 0);
                item.Sab = Utils.GetDataRowValue(dr, "Sab", 0);
                item.Dom = Utils.GetDataRowValue(dr, "Dom", 0);
                item.OrdenLun = Utils.GetDataRowValue(dr, "OrdenLun", 0);
                item.OrdenMar = Utils.GetDataRowValue(dr, "OrdenMar", 0);
                item.OrdenMie = Utils.GetDataRowValue(dr, "OrdenMie", 0);
                item.OrdenJue = Utils.GetDataRowValue(dr, "OrdenJue", 0);
                item.OrdenVie = Utils.GetDataRowValue(dr, "OrdenVie", 0);
                item.OrdenSab = Utils.GetDataRowValue(dr, "OrdenSab", 0);
                item.OrdenDom = Utils.GetDataRowValue(dr, "OrdenDom", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }
            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.HorarioMaestros item = entity as Entities.HorarioMaestros;
            DataEntities.SpFwkHorarioMaestrosIns sp = new DataEntities.SpFwkHorarioMaestrosIns();
            sp.ClaEmpleado = item.ClaEmpleado;
            sp.ClaCampus = item.ClaCampus;
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
            Entities.FwkUsuarios item = entity as Entities.FwkUsuarios;
            DataEntities.SpFwkUsuariosDel sp = new DataEntities.SpFwkUsuariosDel();
            sp.IdUsuario = item.IdUsuario;
            
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

