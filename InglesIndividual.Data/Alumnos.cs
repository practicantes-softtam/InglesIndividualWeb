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
                item.Ciudad.Nombre = Utils.GetDataRowValue(dr, "NomCiudad", "");
                item.Ciudad.ID = Utils.GetDataRowValue(dr, "ClaCiudad", 0);
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
            sp.ClaPais = item.Pais.ID;
            sp.ClaEstado = item.Estado.ID;
            sp.ClaCiudad = item.Ciudad.ID;
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
            Entities.Alumnos item = entity as Entities.Alumnos;
            DataEntities.SpAlumnosDel sp = new DataEntities.SpAlumnosDel();
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


        public override int Update(Entity entity)
        {
            Entities.Alumnos item = entity as Entities.Alumnos;
            DataEntities.SpAlumnosUpd sp = new DataEntities.SpAlumnosUpd();
            sp.Matricula = item.Matricula;
            sp.ApPaterno = item.ApPaterno;
            sp.ApMaterno = item.ApMaterno;
            sp.Nombre = item.Nombre;
            sp.Sexo = item.Sexo;
            sp.Calle = item.Calle;
            sp.Colonia = item.Colonia;
            sp.CP = item.CP;
            sp.ClaPais = item.Pais.ID;
            sp.ClaEstado = item.Estado.ID;
            sp.ClaCiudad = item.Ciudad.ID;
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

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Alumnos item = entity as Entities.Alumnos;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpAlumnosSel sp = new DataEntities.SpAlumnosSel();
                sp.Matricula = item.Matricula;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                    item.Matricula = Utils.GetDataRowValue(dt.Rows[0], "Matricula", "");
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomPuesto", "");
                    item.ApPaterno = Utils.GetDataRowValue(dt.Rows[0], "ApPaterno", "");
                    item.ApMaterno = Utils.GetDataRowValue(dt.Rows[0], "ApMaterno", "");
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "Nombre", "");
                    item.Sexo = Utils.GetDataRowValue(dt.Rows[0], "Sexo", "");
                    item.Calle = Utils.GetDataRowValue(dt.Rows[0], "Calle", "");
                    item.Colonia = Utils.GetDataRowValue(dt.Rows[0], "Colonia", "");
                    item.CP = Utils.GetDataRowValue(dt.Rows[0], "CP", 0);
                    item.Pais = new Entities.Pais();
                    item.Pais.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomPais", "");
                    item.Estado = new Entities.Estado();
                    item.Estado.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomEstado", "");
                    item.Ciudad = new Entities.Ciudad();
                    item.Ciudad.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomCiudad", "");
                    item.Empresa = Utils.GetDataRowValue(dt.Rows[0], "Empresa", "");
                    item.Telefono1 = Utils.GetDataRowValue(dt.Rows[0], "Telefono1", "");
                    item.Telefono2 = Utils.GetDataRowValue(dt.Rows[0], "Telefono2", "");
                    item.Email = Utils.GetDataRowValue(dt.Rows[0], "Email", "");
                    item.Ingreso = Utils.GetDataRowValue(dt.Rows[0], "Ingreso", 0);
                    item.Vigencia = Utils.GetDataRowValue(dt.Rows[0], "Vigencia", 0);
                    item.Estatus = Utils.GetDataRowValue(dt.Rows[0], "Estatus", 0);
                    item.ClaCampus = Utils.GetDataRowValue(dt.Rows[0], "ClaCampus", 0);
                    item.ClaNivel = Utils.GetDataRowValue(dt.Rows[0], "ClaNivel", 0);
                    item.ClaLeccion = Utils.GetDataRowValue(dt.Rows[0], "ClaLeccion", 0);
                    item.Suscriptor = Utils.GetDataRowValue(dt.Rows[0], "Suscriptor", "");
                    item.ClaAtendio = Utils.GetDataRowValue(dt.Rows[0], "ClaAtendio", 0);
                    item.Contrato = Utils.GetDataRowValue(dt.Rows[0], "Contrato", "");
                    item.Especial = Utils.GetDataRowValue(dt.Rows[0], "Especial", 0);
                    item.Observaciones = Utils.GetDataRowValue(dt.Rows[0], "Observaciones", "");
                    item.Foto = Utils.GetDataRowValue(dt.Rows[0], "Foto", "");
                    item.FechaNacimiento = Utils.GetDataRowValue(dt.Rows[0], "FechaNacimiento", 0);
                    item.Telefono3 = Utils.GetDataRowValue(dt.Rows[0], "Telefono3", "");

                }
            }
        }


    }




    }

