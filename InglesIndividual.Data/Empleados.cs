using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Empleados : InglesIndividualDataObject
    {
        public List<Entities.Empleados> ListarEmpleados(InglesIndividual.Entities.JQXGridSettings settings, string nombre)
        {
            List<Entities.Empleados> list = new List<Entities.Empleados>();
            DataEntities.SpEmpleadosGrd sp = new DataEntities.SpEmpleadosGrd();
            sp.Nombre = nombre;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Empleados item = new Entities.Empleados(true);

                item.ClaEmpleado = Utils.GetDataRowValue(dr, "ClaEmpleado", 0);
                item.ApPaterno = Utils.GetDataRowValue(dr, "ApPaterno", "");
                item.ApMaterno = Utils.GetDataRowValue(dr, "ApMAterno", "");
                item.Nombre = Utils.GetDataRowValue(dr, "NOmbre", "");
                item.Sexo = Utils.GetDataRowValue(dr, "Sexo", "");
                item.Campus = new Entities.Campus();
                item.Campus = new Entities.Campus();
                item.Campus.ID = Utils.GetDataRowValue(dr, "Clave", 0);
                item.Departamento = new Entities.Departamentos();
                item.Departamento.ID = Utils.GetDataRowValue(dr, "ClaDepartamento", 0);
                item.Puesto = new Entities.Puesto();
                item.Puesto.ID= Utils.GetDataRowValue(dr, "ClaPuesto", 0);
                item.Calle = Utils.GetDataRowValue(dr, "Calle", "");
                item.Colonia = Utils.GetDataRowValue(dr, "Colonia", "");
                item.CP = Utils.GetDataRowValue(dr, "CP", 0);
                item.Pais = new Entities.Pais();
                item.Pais.ID = Utils.GetDataRowValue(dr, "ClaPais", 0);
                item.Estado = new Entities.Estado();
                item.Estado.ID = Utils.GetDataRowValue(dr, "ClaEstado", 0);
                item.Ciudad = new Entities.Ciudad();
                item.Ciudad.ID= Utils.GetDataRowValue(dr, "Clave", 0);
                item.Telefono1 = Utils.GetDataRowValue(dr, "Telefono1", "");
                item.Telefono2 = Utils.GetDataRowValue(dr, "Telefono2", "");
                item.Email = Utils.GetDataRowValue(dr, "Email", "");
                item.EsDocente = Utils.GetDataRowValue(dr, "EsDocente", 0);
                item.NombreCorto = Utils.GetDataRowValue(dr, "NombreCorto", "");
                item.Baja = Utils.GetDataRowValue(dr, "Baja", 0);
                item.Foto = Utils.GetDataRowValue(dr, "Foto", "");
                item.Observaciones = Utils.GetDataRowValue(dr, "Observaciones", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Empleados item = entity as Entities.Empleados;
            DataEntities.SpEmpleadosIns
                sp = new DataEntities.SpEmpleadosIns();
            sp.ClaEmpleado = item.ClaEmpleado;
            sp.ApPaterno = item.ApPaterno;
            sp.ApMaterno = item.ApMaterno;
            sp.Nombre = item.Nombre;
            sp.Sexo = item.Sexo;
            sp.ClaCampus = item.Campus.ID;
            sp.ClaDepartamento = item.Departamento.ID;
            sp.ClaPuesto = item.Puesto.ID;
            sp.Calle = item.Calle;
            sp.Colonia = item.Colonia;
            sp.CP = item.CP;
            sp.ClaPais = item.Pais.ID;
            sp.ClaEstado = item.Estado.ID;
            sp.ClaCiudad = item.Ciudad.ID;
            sp.Telefono1 = item.Telefono1;
            sp.Telefono2 = item.Telefono2;
            sp.Email = item.Email;
            sp.EsDocente = item.EsDocente;
            sp.NombreCorto = item.NombreCorto;
            sp.Baja = item.Baja;
            sp.Foto = item.Foto;
            sp.Observaciones = item.Observaciones;

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
            Entities.Empleados item = entity as Entities.Empleados;
            DataEntities.SpEmpleadosDel
                sp = new DataEntities.SpEmpleadosDel();
            sp.ClaEmpleado = item.ClaEmpleado;

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
