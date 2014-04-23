using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Alumnos : InglesIndividualDataObject
    {

        public List<Entities.Alumnos> ListarAlumnos(InglesIndividual.Entities.JQXGridSettings settings, string nombre)
        {
            List<Entities.Alumnos> list = new List<Entities.Alumnos>();
            DataEntities.SpAlumnosGrd sp = new DataEntities.SpAlumnosGrd();
            sp.NomAlumno = nombre;
            
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Alumnos item = new Entities.Alumnos(true);
                item.Matricula = Utils.GetDataRowValue(dr, "Matricula", "");
                item.ApPaterno = Utils.GetDataRowValue(dr, "ApPaterno", "");
                item.ApMaterno = Utils.GetDataRowValue(dr, "ApMaterno", "");
                item.Nombre = Utils.GetDataRowValue(dr, "Nombre", "");
                item.Sexo = Utils.GetDataRowValue(dr, "Sexo", "");
                item.Calle = Utils.GetDataRowValue(dr, "Calle", "");
                item.Colonia = Utils.GetDataRowValue(dr, "Colonia", "");
                item.CP = Utils.GetDataRowValue(dr, "CP", 0);
                item.Pais = new Entities.Pais();
                item.Pais.Nombre = Utils.GetDataRowValue(dr, "NomPais", "");
                item.Estado = new Entities.Estado();
                item.Estado.Nombre = Utils.GetDataRowValue(dr, "NomEstado", "");
                item.Ciudad = new Entities.Ciudad();
                item.Ciudad.Clave = Utils.GetDataRowValue(dr, "ClaCiudad", 0);
                item.Empresa = Utils.GetDataRowValue(dr, "Empresa", "");
                item.Telefono1 = Utils.GetDataRowValue(dr, "Telefono1", "");
                item.Telefono2 = Utils.GetDataRowValue(dr, "Telefono2", "");
                item.Email = Utils.GetDataRowValue(dr, "Email", "");
                item.Ingreso = Utils.GetDataRowValue(dr, "Ingreso", 0);
                item.Vigencia = Utils.GetDataRowValue(dr, "Vigencia", 0);
                item.Estatus = Utils.GetDataRowValue(dr, "Estatus", 0);
                item.ClaCampus = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.ClaNivel = Utils.GetDataRowValue(dr, "ClaNivel", 0);
                item.ClaLeccion = Utils.GetDataRowValue(dr, "ClaLeccion", 0);
                item.Suscriptor = Utils.GetDataRowValue(dr, "Suscriptor", "");
                item.ClaAtendio = Utils.GetDataRowValue(dr, "ClaAtendio", 0);
                item.Contrato = Utils.GetDataRowValue(dr, "Contrato", "");
                item.Especial = Utils.GetDataRowValue(dr, "Especial", 0);
                item.Observaciones = Utils.GetDataRowValue(dr, "Observaciones", "");
                item.Foto = Utils.GetDataRowValue(dr, "Foto", "");
                item.FechaNacimiento = Utils.GetDataRowValue(dr, "FechaNacimiento", 0);
                item.Telefono3 = Utils.GetDataRowValue(dr, "Telefono3", "");
                list.Add(item);
            }

            return list;
        }


        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Alumnos item = entity as Entities.Alumnos;
            DataEntities.SpAlumnosIns
                sp = new DataEntities.SpAlumnosIns();
            sp.Matricula = item.Matricula;
            sp.ApPaterno = item.ApPaterno;
            sp.ApMaterno = item.ApMaterno;
            sp.Nombre = item.Nombre;
            sp.Sexo = item.Sexo;
            sp.Calle = item.Calle;
            sp.Colonia = item.Colonia;
            sp.CP = item.CP;
            sp.ClaPais = item.Pais.Clave;
            sp.ClaEstado = item.Estado.Clave;
            sp.ClaCiudad = item.Ciudad.Clave;
            sp.Empresa = item.Empresa;
            sp.Telefono1 = item.Telefono1;
            sp.Telefono2 = item.Telefono2;
            sp.Email = item.Email;
            sp.Ingreso = item.Ingreso;
            sp.Vigencia = item.Vigencia;
            sp.Estatus = item.Estatus;
            sp.ClaCampus = item.ClaCampus;
            sp.ClaNivel = item.ClaNivel;
            sp.ClaLeccion = item.ClaLeccion;
            sp.Suscriptor = item.Suscriptor;
            sp.ClaAtendio = item.ClaAtendio;
            sp.Contrato = item.Contrato;
            sp.Especial = item.Especial;
            sp.Observaciones = item.Observaciones;
            sp.Foto = item.Foto;
            sp.FechaNacimiento = item.FechaNacimiento;
            sp.Telefono3 = item.Telefono3;
 
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
            Entities.Alumnos item = entity as Entities.Alumnos;
            DataEntities.SpAlumnosDel
                sp = new DataEntities.SpAlumnosDel();
            sp.Matricula = item.Matricula;


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

