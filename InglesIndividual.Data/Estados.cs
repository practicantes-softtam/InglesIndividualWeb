using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
   public class Estados : InglesIndividualDataObject
    {
        public List<Entities.Estado> ListarEstados(InglesIndividual.Entities.JQXGridSettings settings, int claPais, string nomEstado)
        {
            List<Entities.Estado> list = new List<Entities.Estado>();
            DataEntities.SpEstadosGrd sp = new DataEntities.SpEstadosGrd();
            sp.ClaPais = claPais;
            sp.NomEstado = nomEstado;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Estado item = new Entities.Estado(true);
                item.ID = Utils.GetDataRowValue(dr, "ClaEstado", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomEstado", "");
                item.Pais = new Entities.Pais();
                item.Pais.ID = Utils.GetDataRowValue(dr, "ClaPais", 0);

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }


        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Estado item = entity as Entities.Estado;
            DataEntities.SpEstadosIns
                sp = new DataEntities.SpEstadosIns();
            
 //Aqui batallé D:
            sp.ClaEstado = item.ID;
            sp.ClaPais = item.Pais.ID;
 
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
            Entities.Estado item = entity as Entities.Estado;
            DataEntities.SpEstadosDel
                sp = new DataEntities.SpEstadosDel();
            sp.ClaEstado = item.ID;


            if (tran != null)
            {
                return sp.ExecuteNonQuery(tran);
            }
            else
            {
                return sp.ExecuteNonQuery(this.ConnectionString);
            }

        }

        public List<Entities.Estado> Combo(int claPais)
        {
            List<Entities.Estado> list = new List<Entities.Estado>();
            DataEntities.SpEstadosSel sp = new DataEntities.SpEstadosSel();
            sp.ClaPais = claPais;
            sp.ClaEstado = -1;
            DataTable dt = sp.GetDataTable(this.ConnectionString);

            foreach (DataRow dr in dt.Rows)
            {
                Entities.Estado item = new Entities.Estado(true);
                item.ID = Utils.GetDataRowValue(dr, "ClaEstado", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomEstado", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }
    }
}
