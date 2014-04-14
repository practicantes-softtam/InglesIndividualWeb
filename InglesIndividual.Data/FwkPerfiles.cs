using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class FwkPerfil : InglesIndividualDataObject
    {
        public List<Entities.FwkPerfiles> ListarFwkPerfiles(InglesIndividual.Entities.JQXGridSettings settings,int claAplicacion, string nomPerfil)
        {
            List<Entities.FwkPerfiles> list = new List<Entities.FwkPerfiles>();
            DataEntities.SpFwkPerfilGrd sp = new DataEntities.SpFwkPerfilGrd();
            sp.ClaAplicaion = claAplicacion;
            sp.NomPerfil = nomPerfil;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkPerfiles item = new Entities.FwkPerfiles(true);
                item.ClaAplicacion = new Entities.FwkAplicaciones();
                item.ClaAplicacion.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.ClaPerfil = Utils.GetDataRowValue(dr, "ClaPerfil", 0);
                item.NomPerfil = Utils.GetDataRowValue(dr, "NomPerfil", "");
                

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkPerfiles item = entity as Entities.FwkPerfiles;
            DataEntities.SpFwkPerfilesIns
               sp = new DataEntities.SpFwkPerfilesIns();
            sp.ClaAplicaion = item.ClaAplicacion.ClaAplicacion;
            sp.ClaPerfil = item.ClaPerfil;
            sp.NomPerfil = item.NomPerfil;


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
            Entities.FwkPerfiles item = entity as Entities.FwkPerfiles;
            DataEntities.SpFwkPerfilesDel
               sp = new DataEntities.SpFwkPerfilesDel();
            sp.ClaAplicaion = item.ClaAplicacion.ClaAplicacion;
            sp.ClaPerfil = item.ClaPerfil;
            

            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }

        }





        public List<Entities.FwkObjetos> ListarFwkPerfiles(Entities.JQXGridSettings settings, int claAplicacion, int claPerfil, string nomPerfil)
        {
            throw new NotImplementedException();
        }
    }
}

