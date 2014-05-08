using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Asistencia : InglesIndividualDataObject
    {
        public List<Entities.Asistencia> ListarAsistencia(InglesIndividual.Entities.JQXGridSettings settings, DateTime fechaHora)
        {
            List<Entities.Asistencia> list = new List<Entities.Asistencia>();
            DataEntities.SpAsistenciaGrd sp = new DataEntities.SpAsistenciaGrd();
            sp.FechaHora = fechaHora;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Asistencia item = new Entities.Asistencia(true);

                item.ID = Utils.GetDataRowValue(dr, "idRegistro", 0);
                item.Campus = new Entities.Campus();
                item.Campus.ID = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.Matricula = Utils.GetDataRowValue(dr, "Matricula", "");
                item.Empleado = new Entities.Empleados();
                item.Empleado.Nombre = Utils.GetDataRowValue(dr, "Nombre", "");
                item.TipoPersona = Utils.GetDataRowValue(dr, "TipoPersona", 0);
                item.FechaHora = Utils.GetDataRowValue(dr, "FechaHora", DateTime.Now);
                item.Mensaje = Utils.GetDataRowValue(dr, "Mensaje", "");
                item.idCita = Utils.GetDataRowValue(dr, "idCita", 0);
                item.RegistroValido = Utils.GetDataRowValue(dr, "RegistroValido", 0);

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Asistencia item = entity as Entities.Asistencia;
            DataEntities.SpAsistenciaIns
                sp = new DataEntities.SpAsistenciaIns();
            sp.IdRegistro = item.ID;
            sp.ClaCampus = item.Campus.ID;
           // sp.IdRegistro = item.ID;
            //sp.ClaCampus = item.Campus.ID;
            sp.Matricula = item.Matricula;
            sp.ClaEmpleado = item.Empleado.ID;
            sp.TipoPersona = item.TipoPersona;
            sp.FechaHora = item.FechaHora;
            sp.Mensaje = item.Mensaje;
            sp.IdCita = item.idCita;
            sp.RegistroValido = item.RegistroValido;

          //  if (tran != null)
          //  {
          //      return sp.ExecuteNonQuery(tran);

          //  }
          //  else
          //  {
                return sp.ExecuteNonQuery(this.ConnectionString);
          //  }
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Asistencia item = entity as Entities.Asistencia;
            DataEntities.SpAsistenciaDel
                sp = new DataEntities.SpAsistenciaDel();
            sp.IdRegistro = item.ID;

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
            Entities.Asistencia item = entity as Entities.Asistencia;
            DataEntities.SpAsistenciaUpd sp = new DataEntities.SpAsistenciaUpd();
            sp.IdRegistro = item.ID;
            sp.ClaCampus = item.Campus.ID;
            sp.Matricula = item.Matricula;
            sp.ClaEmpleado = item.Empleado.ID;
            sp.TipoPersona = item.TipoPersona;
            sp.FechaHora = item.FechaHora;
            sp.Mensaje = item.Mensaje;
            sp.IdCita = item.idCita;
            sp.RegistroValido = item.RegistroValido;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Asistencia item = entity as Entities.Asistencia;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpAsistenciaSel sp = new DataEntities.SpAsistenciaSel();
                sp.IdRegistro = item.ID;
                sp.ClaCampus = item.Campus.ID;
                sp.ClaEmpleado = item.Empleado.ID;
                sp.IdCita = item.idCita;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                  
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "idRegistro", 0);
                    item.Campus = new Entities.Campus();
                    item.Campus.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaCampus", 0);
                    item.Matricula = Utils.GetDataRowValue(dt.Rows[0], "Matricula", "");
                    item.Empleado = new Entities.Empleados();
                    item.Empleado.Nombre = Utils.GetDataRowValue(dt.Rows[0], "Nombre", "");
                    item.TipoPersona = Utils.GetDataRowValue(dt.Rows[0], "TipoPersona", 0);
                    item.FechaHora = Utils.GetDataRowValue(dt.Rows[0], "FechaHora", DateTime.Now);
                    item.Mensaje = Utils.GetDataRowValue(dt.Rows[0], "Mensaje", "");
                    item.idCita = Utils.GetDataRowValue(dt.Rows[0], "idCita", 0);
                    item.RegistroValido = Utils.GetDataRowValue(dt.Rows[0], "RegistroValido", 0);
                }
            }
        }

    }
}
