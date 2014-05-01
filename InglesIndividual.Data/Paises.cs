using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

   public  class Paises : InglesIndividualDataObject
    {
       public List<Entities.Pais> ListarPaises(InglesIndividual.Entities.JQXGridSettings settings, string nomPaises)
       {
           List<Entities.Pais> list = new List<Entities.Pais>();
           DataEntities.SpPaisesGrd sp = new DataEntities.SpPaisesGrd();
           sp.NomPais = nomPaises;
           this.ConfigurePagedStoredProcedure(sp, settings);

           DataTable dt = sp.GetDataTable(this.ConnectionString);
           foreach (DataRow dr in dt.Rows)
           {
               Entities.Pais item = new Entities.Pais(true);

               item.ID = Utils.GetDataRowValue(dr, "ClaPais", 0 );
               item.Nombre= Utils.GetDataRowValue(dr, "NomPais", "");

               this.SetWebEntityGridValues(item, dr);

               list.Add(item);
           }

           return list;
       }

       public override int Insert(Entity entity, DataTransaction tran)
       {
           Entities.Pais item = entity as Entities.Pais;
           DataEntities.SpPaisesIns
              sp = new DataEntities.SpPaisesIns();
           sp.ClaPais = item.ID;
           sp.NomPais = item.Nombre;

           if (tran != null)
           {
               return sp.ExecuteNonQuery(tran);
             }
           else
           {
              return  sp.ExecuteNonQuery(this.ConnectionString);
           }

          }

       public override int Delete(Entity entity, DataTransaction tran)
       {
           Entities.Pais item = entity as Entities.Pais;
           DataEntities.spPaisesDel
           sp = new DataEntities.spPaisesDel();
           sp.ClaPais = item.ID;
           

           if (tran != null)
           {
               return sp.ExecuteNonQuery(tran);
           }
           else
           {
               return sp.ExecuteNonQuery(this.ConnectionString);
           }

       }

       public List<Entities.Pais> Combo()
       {
           List<Entities.Pais> list = new List<Entities.Pais>();
           DataEntities.SpPaisesSel sp = new DataEntities.SpPaisesSel();
           DataTable dt = sp.GetDataTable(this.ConnectionString);

           foreach (DataRow dr in dt.Rows)
           {
               Entities.Pais item = new Entities.Pais(true);
               item.ID = Utils.GetDataRowValue(dr, "ClaPais", 0);
               item.Nombre = Utils.GetDataRowValue(dr, "NomPais", "");

               this.SetWebEntityGridValues(item, dr);

               list.Add(item);
           }

           return list;
       }
    }
}
