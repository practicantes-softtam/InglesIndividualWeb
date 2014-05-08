using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Citas : InglesIndividualDataObject
    {

        public List<Entities.Citas> ListarCitas(InglesIndividual.Entities.JQXGridSettings settings, DateTime fechaHora)
        {
            List<Entities.Citas> list = new List<Entities.Citas>();
            DataEntities.SpCitasGrd sp = new DataEntities.SpCitasGrd();
            sp.FechaHora = fechaHora;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Citas item = new Entities.Citas(true);

                item.ID = Utils.GetDataRowValue(dr, "IdCita", 0);
                item.Campus = new Entities.Campus();
                item.Campus.ID = Utils.GetDataRowValue(dr, "Clave", 0);
                item.Matricula = Utils.GetDataRowValue(dr, "Matricula", "");
                item.ClaProfesor = Utils.GetDataRowValue(dr, "ClaProfesor", 0);
                item.FechaHora = Utils.GetDataRowValue(dr, "FechaHora", 0);
                item.TipoClase = Utils.GetDataRowValue(dr, "TipoClase", 0);
                item.Estatus = Utils.GetDataRowValue(dr, "Estatus", 0);
                item.ClaNivel = Utils.GetDataRowValue(dr, "ClaNivel", 0);
                item.ClaLeccion = Utils.GetDataRowValue(dr, "ClaLeccion", 0);
                item.FechaHoraOriginal = Utils.GetDataRowValue(dr, "FechaHoraOriginal", 0);
                item.Observaciones = Utils.GetDataRowValue(dr, "Observaciones", "");
                item.ModManual = Utils.GetDataRowValue(dr, "ModManual", 0);
                item.FechaHoraAsistencia = Utils.GetDataRowValue(dr, "FechaHoraAsistencia", 0);
                item.Aprobo = Utils.GetDataRowValue(dr, "Aprobo", 0);

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Citas item = entity as Entities.Citas;
            DataEntities.SpCitasIns
                sp = new DataEntities.SpCitasIns();
            sp.IdCita = item.ID;
            sp.ClaCampus = item.Campus.ID;
            //sp.IdCita = item.IdCita;
            //sp.ClaCampus = item.Campus.ID;
            sp.Matricula = item.Matricula;
            sp.ClaProfesor = item.ClaProfesor;
            sp.FechaHora = item.FechaHora;
            sp.TipoClase = item.TipoClase;
            sp.Estatus = item.Estatus;
            sp.ClaNivel = item.ClaNivel;
            sp.ClaLeccion = item.ClaLeccion;
            sp.FechaHoraOriginal = item.FechaHoraOriginal;
            sp.Observaciones = item.Observaciones;
            sp.ModManual = item.ModManual;
            sp.FechaHoraAsistencia = item.FechaHoraAsistencia;
            sp.Aprobo = item.Aprobo;
            

           // if (tran != null)
           // {
           //     return sp.ExecuteNonQuery(tran);

           // }
           // else
           // {
                return sp.ExecuteNonQuery(this.ConnectionString);
           // }
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Citas item = entity as Entities.Citas;
            DataEntities.SpCitasDel
                sp = new DataEntities.SpCitasDel();
            sp.IdCita = item.ID;

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
            Entities.Citas item = entity as Entities.Citas;
            DataEntities.SpCitasUpd sp = new DataEntities.SpCitasUpd();
            sp.IdCita = item.ID;
            sp.ClaCampus = item.Campus.ID;
            sp.Matricula = item.Matricula;
            sp.ClaProfesor = item.ClaProfesor;
            sp.FechaHora = item.FechaHora;
            sp.TipoClase = item.TipoClase;
            sp.Estatus = item.Estatus;
            sp.ClaNivel = item.ClaNivel;
            sp.ClaLeccion = item.ClaLeccion;
            sp.FechaHoraOriginal = item.FechaHoraOriginal;
            sp.Observaciones = item.Observaciones;
            sp.ModManual = item.ModManual;
            sp.FechaHoraAsistencia = item.FechaHoraAsistencia;
            sp.Aprobo = item.Aprobo;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Citas item = entity as Entities.Citas;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpCitasSel sp = new DataEntities.SpCitasSel();
                sp.IdCita = item.ID;
                sp.ClaCampus = item.Campus.ID;
                sp.ClaProfesor = item.ClaProfesor;
                sp.CLaNivel = item.ClaNivel;
                sp.ClaLeccion = item.ClaLeccion;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                    
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "IdCita", 0);
                    item.Campus = new Entities.Campus();
                    item.Campus.ID = Utils.GetDataRowValue(dt.Rows[0], "Clave", 0);
                    item.Matricula = Utils.GetDataRowValue(dt.Rows[0], "Matricula", "");
                    item.ClaProfesor = Utils.GetDataRowValue(dt.Rows[0], "ClaProfesor", 0);
                    item.FechaHora = Utils.GetDataRowValue(dt.Rows[0], "FechaHora", 0);
                    item.TipoClase = Utils.GetDataRowValue(dt.Rows[0], "TipoClase", 0);
                    item.Estatus = Utils.GetDataRowValue(dt.Rows[0], "Estatus", 0);
                    item.ClaNivel = Utils.GetDataRowValue(dt.Rows[0], "ClaNivel", 0);
                    item.ClaLeccion = Utils.GetDataRowValue(dt.Rows[0], "ClaLeccion", 0);
                    item.FechaHoraOriginal = Utils.GetDataRowValue(dt.Rows[0], "FechaHoraOriginal", 0);
                    item.Observaciones = Utils.GetDataRowValue(dt.Rows[0], "Observaciones", "");
                    item.ModManual = Utils.GetDataRowValue(dt.Rows[0], "ModManual", 0);
                    item.FechaHoraAsistencia = Utils.GetDataRowValue(dt.Rows[0], "FechaHoraAsistencia", 0);
                    item.Aprobo = Utils.GetDataRowValue(dt.Rows[0], "Aprobo", 0);
                }
            }
        }
    }
}
