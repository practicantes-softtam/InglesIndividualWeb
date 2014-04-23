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
        public List<Entities.Campus> ListarCampus(InglesIndividual.Entities.JQXGridSettings settings, string nomCampus)
        {
            List<Entities.Campus> list = new List<Entities.Campus>();
            DataEntities.SpCampusGrd sp = new DataEntities.SpCampusGrd();
            sp.NomCampus = nomCampus;
            this.ConfigurePagedStoredProcedure(sp, settings);
            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Campus item = new Entities.Campus(true);
                item.NomCampus= Utils.GetDataRowValue(dr, "NomCampus", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Campus item = entity as Entities.Campus;
            DataEntities.SpCampusIns
            sp = new DataEntities.SpCampusIns();
            sp.ClaCampus = item.ClaCampus;
            sp.NomCampus = item.NomCampus;
            sp.Calle = item.Calle;
            sp.Colonia = item.Colonia;
            sp.CodigoPostal = item.CodigoPostal;
            sp.ClaPais = item.ClaPais.Clave;
            sp.ClaEstado = item.Ciudad.Estado.Clave;
            sp.ClaCiudad = item.Ciudad.Clave;
            sp.Telefono = item.Telefono;
            sp.DirectorGeneral = item.DirectorGeneral;
            sp.DirectorAdministrativo = item.DirectorAdministrativo;

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
            Entities.Campus item = entity as Entities.Campus;
            DataEntities.SpCampusDel
                sp = new DataEntities.SpCampusDel();
            sp.NomCampus = item.NomCampus;

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


