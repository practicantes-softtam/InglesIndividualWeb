using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{

    public class Departamentos : InglesIndividualDataObject
    {
        public List<Entities.Departamentos> ListarPaises(InglesIndividual.Entities.JQXGridSettings settings, string nomDepartamento)
        {
            List<Entities.Departamentos> list = new List<Entities.Departamentos>();
            DataEntities.SpDepartamentosGrd sp = new DataEntities.SpDepartamentosGrd();
            sp.NomDepartamento = nomDepartamento;
            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Departamentos item = new Entities.Departamentos(true);

                item.ClaDepartamento = Utils.GetDataRowValue(dr, "ClaDepartamento", 0);
                item._claCampus = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.NomDepartamento = Utils.GetDataRowValue(dr, "NomDepartamento", "");

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.Departamentos item = entity as Entities.Departamentos;
            DataEntities.SpDepartamentosIns
               sp = new DataEntities.SpDepartamentosIns();
            sp.ClaAplicaion = item.ClaDepartamento;
            sp.ClaAplicaion = item._claCampus;
            sp.NomAplicacion = item.NomDepartamento;

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
            Entities.Departamentos item = entity as Entities.Departamentos;
            DataEntities.SpDepartamentosDel
               sp = new DataEntities.SpDepartamentosDel();
            sp.ClaDepartamento = item.ClaDepartamento;

            
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
