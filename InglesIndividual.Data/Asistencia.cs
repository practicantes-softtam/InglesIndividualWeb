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

                item.idRegistro = Utils.GetDataRowValue(dr, "idRegistro", 0);
                item.Campus = new Entities.Campus();
                item.Campus.Clave = Utils.GetDataRowValue(dr, "ClaCampus", 0);
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
            sp.IdRegistro = item.idRegistro;
            sp.ClaCampus = item.Campus.Clave;
            sp.Matricula = item.Matricula;
            sp.ClaEmpleado = item.Empleado.ClaEmpleado;
            sp.TipoPersona = item.TipoPersona;
            sp.FechaHora = item.FechaHora;
            sp.Mensaje = item.Mensaje;
            sp.IdCita = item.idCita;
            sp.RegistroValido = item.RegistroValido;

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
            Entities.Asistencia item = entity as Entities.Asistencia;
            DataEntities.SpAsistenciaDel
                sp = new DataEntities.SpAsistenciaDel();
            sp.IdRegistro = item.idRegistro;

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
