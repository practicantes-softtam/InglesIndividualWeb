using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Data
{
    public class Campus : InglesIndividualDataObject
    {
        public List<Entities.Campus> ListarCampus(InglesIndividual.Entities.JQXGridSettings settings, string nomCampus, string calle, string colonia, string telefono, int claPais, int claEstado, int claCiudad)
        {
            List<Entities.Campus> list = new List<Entities.Campus>();
            DataEntities.SpCampusGrd sp = new DataEntities.SpCampusGrd();
            sp.NomCampus = nomCampus;
            sp.Calle = calle;
            sp.Colonia = colonia;
            sp.Telefono = telefono;
            sp.ClaCiudad = claCiudad;
            sp.ClaEstado = claEstado;
            sp.ClaPais = claPais;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Campus item = new Entities.Campus(true);
                item.ID = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomCampus", "");
                item.Calle = Utils.GetDataRowValue(dr, "Calle", "");
                item.Colonia = Utils.GetDataRowValue(dr, "Colonia", "");
                item.Telefono = Utils.GetDataRowValue(dr, "Telefono", "");
                item.Pais = new Entities.Pais();
                item.Pais.ID = Utils.GetDataRowValue(dr, "ClaPais", 0);
                item.Estado = new Entities.Estado();
                item.ID = Utils.GetDataRowValue(dr, "ClaEstado", 0);
                item.Ciudad = new Entities.Ciudad();
                item.ID = Utils.GetDataRowValue(dr, "ClaCiudad", 0);
               
                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity)
        {
            Entities.Campus item = entity as Entities.Campus;
            DataEntities.SpCampusIns sp = new DataEntities.SpCampusIns();
         
            sp.ClaCampus = item.ID;
            sp.NomCampus = item.Nombre;
            sp.Calle = item.Calle;
            sp.Colonia = item.Colonia;
            sp.CodigoPostal = item.CodigoPostal;
            sp.ClaPais = item.Pais.ID;
            sp.ClaEstado = item.Ciudad.Estado.ID;
            sp.ClaCiudad = item.Ciudad.ID;
            sp.Telefono = item.Telefono;
            sp.DirectorGeneral = item.DirectorGeneral;
            sp.DirectorAdministrativo = item.DirectorAdministrativo;

                return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Campus item = entity as Entities.Campus;
            DataEntities.SpCampusDel sp = new DataEntities.SpCampusDel();
            sp.ClaCampus = item.ID;

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
            Entities.Campus item = entity as Entities.Campus;
            DataEntities.SpCampusUpd sp = new DataEntities.SpCampusUpd();
            sp.ClaCampus = item.ID;
            sp.NomCampus = item.Nombre;
            sp.Calle = item.Calle;
            sp.Colonia = item.Colonia;
            sp.CodigoPostal = item.CodigoPostal;
            sp.ClaPais = item.Pais.ID;
            sp.ClaEstado = item.Estado.ID;
            sp.ClaCiudad = item.Ciudad.ID;
            sp.Telefono = item.Telefono;
            sp.DirectorGeneral = item.DirectorGeneral;
            sp.DirectorAdministrativo = item.DirectorAdministrativo;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Campus item = entity as Entities.Campus;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpCampusSel sp = new DataEntities.SpCampusSel();
                sp.ClaCiudad = item.ID;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaCampus", 0);
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomCampus", "");
                }

            }
        }

        public List<Entities.Campus> Combo()
        {
            List<Entities.Campus> list = new List<Entities.Campus>();
            DataEntities.SpCiudadesSel sp = new DataEntities.SpCiudadesSel();
            sp.ClaPais = -1;
            sp.ClaEstado = -1;
            sp.ClaCiudad = -1;
            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.Campus item = new Entities.Campus(true);
                item.ID = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomCampus", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public List<Entities.Campus> ListarCampus(Entities.JQXGridSettings settings, string nomCampus, string calle, string colonia, string telefono)
        {
            throw new NotImplementedException();
        }
    }
}
