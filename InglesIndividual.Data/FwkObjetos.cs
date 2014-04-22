using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class FwkObjetos : InglesIndividualDataObject
    {
        public List<Entities.FwkObjetos> ListarFwkObjetos(InglesIndividual.Entities.JQXGridSettings settings,int claAplicacion,int claModulo,int claObjeto, string ClaObjeto, string nomObjetos ,string url)
        {
            List<Entities.FwkObjetos> list = new List<Entities.FwkObjetos>();
            DataEntities.SpFwkObjetosGrd sp = new DataEntities.SpFwkObjetosGrd();
            sp.ClaAplicaion = claAplicacion;
            sp.ClaModulo = claModulo;
            sp.ClaObjeto = claObjeto;
            sp.ClaveObjeto = ClaObjeto;
            sp.NomObjeto = nomObjetos;
            sp.Url = url;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.FwkObjetos item = new Entities.FwkObjetos(true);
                item.FwkAplicacion = new Entities.FwkAplicaciones();
                item.FwkAplicacion.ClaAplicacion = Utils.GetDataRowValue(dr, "ClaAplicacion", 0);
                item.FwkModulo = new Entities.FwkModulos();
                item.FwkModulo.ClaModulo= Utils.GetDataRowValue(dr, "ClaModulo", 0);
                item.ClaObjeto = Utils.GetDataRowValue(dr, "ClaObjeto", 0);
                item.ClaveObjeto=Utils.GetDataRowValue(dr,"ClaveObjeto","");
                item.NomObjeto = Utils.GetDataRowValue(dr, "NomObjetos", "");
                item.Url = Utils.GetDataRowValue(dr, "Url", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.FwkObjetos item = entity as Entities.FwkObjetos;
            DataEntities.SpFwkObjetosIns
               sp = new DataEntities.SpFwkObjetosIns();
            
            sp.ClaAplicaion = item.FwkAplicacion.ClaAplicacion;
            sp.ClaModulo = item.FwkAplicacion.ClaAplicacion;
            sp.ClaObjeto = item.ClaObjeto;
            sp.ClaveObjeto = item.ClaveObjeto;
            sp.NomObjeto = item.NomObjeto;
            sp.Url = item.Url;


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
            Entities.FwkObjetos item = entity as Entities.FwkObjetos;
            DataEntities.SpFwkObjetoDel
               sp = new DataEntities.SpFwkObjetoDel();
            sp.ClaAplicaion = item.FwkAplicacion.ClaAplicacion;
            sp.ClaModulo = item.FwkModulo.ClaModulo;
            sp.ClaObjeto = item.ClaObjeto;
            
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

