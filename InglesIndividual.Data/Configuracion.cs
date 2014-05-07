using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Configuracion : InglesIndividualDataObject
    {

        public List<Entities.Configuracion> ListarConfiguracion(InglesIndividual.Entities.JQXGridSettings settings, string nomConfiguracion)
        {
            List<Entities.Configuracion> list = new List<Entities.Configuracion>();
            DataEntities.SpConfiguracionGrd sp = new DataEntities.SpConfiguracionGrd();
            sp.NomConfiguracion = nomConfiguracion;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Configuracion item = new Entities.Configuracion(true);

                item.ClaCategoria = Utils.GetDataRowValue(dr, "ClaCategoria", 0);
                item.ClaConfig = Utils.GetDataRowValue(dr, "ClaConfig", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomCinfiguracion", "");
                item.ValorEntero = Utils.GetDataRowValue(dr, "ValorEntero", 0);
                item.ValorCadena = Utils.GetDataRowValue(dr, "ValorCadena", "");
                item.Editable = Utils.GetDataRowValue(dr, "Editable", 0);

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Configuracion item = entity as Entities.Configuracion;
            DataEntities.SpConfiguracionIns
                sp = new DataEntities.SpConfiguracionIns();
            sp.ClaCategoria = item.ClaCategoria;
            sp.ClaConfig = item.ClaConfig;
            sp.NomConfiguracion = item.Nombre;
            sp.ValorEntero = item.ValorEntero;
            sp.ValorCadena = item.ValorCadena;
            sp.Editable = item.Editable;
            


         //   if (tran != null)
         //   {
         //       return sp.ExecuteNonQuery(tran);

         //   }
         //   else
         //   {
                return sp.ExecuteNonQuery(this.ConnectionString);
         //   }
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Configuracion item = entity as Entities.Configuracion;
            DataEntities.SpConfiguracionDel
                sp = new DataEntities.SpConfiguracionDel();
            sp.ClaCategoria = item.ClaCategoria;
            sp.ClaConfig = sp.ClaConfig;

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
            Entities.Configuracion item = entity as Entities.Configuracion;
            DataEntities.SpConfiguracionUpd sp = new DataEntities.SpConfiguracionUpd();
            sp.ClaCategoria = item.ClaCategoria;
            sp.ClaConfig = item.ClaConfig;
            sp.NomConfiguracion = item.Nombre;
            sp.ValorEntero = item.ValorEntero;
            sp.ValorCadena = item.ValorCadena;
            sp.Editable = item.Editable;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Configuracion item = entity as Entities.Configuracion;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpConfiguracionSel sp = new DataEntities.SpConfiguracionSel();
                sp.ClaCategoria = item.ClaCategoria;
                sp.ClaConfig = sp.ClaConfig;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                    
                    item.ClaCategoria = Utils.GetDataRowValue(dt.Rows[0], "ClaCategoria", 0);
                    item.ClaConfig = Utils.GetDataRowValue(dt.Rows[0], "ClaConfig", 0);
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomCinfiguracion", "");
                    item.ValorEntero = Utils.GetDataRowValue(dt.Rows[0], "ValorEntero", 0);
                    item.ValorCadena = Utils.GetDataRowValue(dt.Rows[0], "ValorCadena", "");
                    item.Editable = Utils.GetDataRowValue(dt.Rows[0], "Editable", 0);
                }
            }
        }

    }
}
