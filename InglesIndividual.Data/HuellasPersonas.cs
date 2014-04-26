using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class HuellasPersonas : InglesIndividualDataObject
    {
        public List<Entities.HuellasPersonas> ListarHuellasPersonas(Entities.JQXGridSettings settings, int IdRegistro, string matricula, int claEmpleado)
        {
            DataEntities.SpHuellasPersonasGrd sp = new DataEntities.SpHuellasPersonasGrd();
            List<Entities.HuellasPersonas> list = new List<Entities.HuellasPersonas>();
            sp.IdRegistro = IdRegistro;
            sp.Matricula = matricula;
            sp.ClaEmpleado = claEmpleado;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.HuellasPersonas item = new Entities.HuellasPersonas(true);
                item.IdRegistro = Utils.GetDataRowValue(dr, "IdRegistro", 0);
                item.Matricula = Utils.GetDataRowValue(dr, "Matricula", "");
                item.ClaEmpleado = new Entities.Empleados();
                item.ClaEmpleado.ClaEmpleado = Utils.GetDataRowValue(dr, "ClaEmpleado", 0);
                this.SetWebEntityGridValues(item, dr);
                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.HuellasPersonas item = entity as Entities.HuellasPersonas;
            DataEntities.SpHuellasPersonasIns sp = new DataEntities.SpHuellasPersonasIns();
            sp.IdRegistro = item.IdRegistro;
            sp.ClaCampus = item.ClaCampus.Clave;
            sp.Matricula = item.Matricula;
            sp.ClaEmpleado = item.ClaEmpleado.ClaEmpleado;
            sp.TipoPersona = item.TipoPersona;
            sp.Huella = item.Huella;
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
            Entities.HuellasPersonas item = entity as Entities.HuellasPersonas;
            DataEntities.SpHuellasPersonasDel sp = new DataEntities.SpHuellasPersonasDel();
            sp.IdRegistro = item.IdRegistro;
            sp.Matricula = item.Matricula;
            sp.ClaEmpleado = item.ClaEmpleado.ClaEmpleado;
            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery (this.ConnectionString);
            }
        }
    }
}

