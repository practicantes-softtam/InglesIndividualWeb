
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class Departamentos : InglesIndividualDataObject
    {
        public List<Entities.Departamentos> ListarDepartamentos(InglesIndividual.Entities.JQXGridSettings settings, string nomDepartamento)
        {
            List<Entities.Departamentos> list = new List<Entities.Departamentos>();
            DataEntities.SpDepartamentosGrd sp = new DataEntities.SpDepartamentosGrd();
            sp.NomDepartamento = nomDepartamento;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.Departamentos item = new Entities.Departamentos(true);

                item.ID = Utils.GetDataRowValue(dr, "ClaDepartamento", 0);
                item.Campus = new Entities.Campus();
                item.Campus.ID = Utils.GetDataRowValue(dr, "ClaCampus", 0);
                item.Nombre = Utils.GetDataRowValue(dr, "NomDepartamento", "");

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
            sp.ClaDepartamento = item.ID;
            sp.ClaCampus = item.Campus.ID;
            sp.NomDepartamento = item.Nombre;

          //  if (tran != null)
          //  {
          //      return sp.ExecuteNonQuery(tran);

           // }
           // else
           // {
                return sp.ExecuteNonQuery(this.ConnectionString);
           // }
        }

        public override int Delete(Entity entity, DataTransaction tran)
        {
            Entities.Departamentos item = entity as Entities.Departamentos;
            DataEntities.SpDepartamentosDel
                sp = new DataEntities.SpDepartamentosDel();
            //sp.IdDepartamento = item.ID;
            sp.NomDepartamento = item.Nombre;

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
            Entities.Departamentos item = entity as Entities.Departamentos;
            DataEntities.SpDepartamentosUpd sp = new DataEntities.SpDepartamentosUpd();
            sp.ClaDepartamento = item.ID;
            sp.ClaCampus = item.Campus.ID;
            sp.NomDepartamentos = item.Nombre;

            return sp.ExecuteNonQuery(this.ConnectionString);
        }

        public override void PrepareEntityForEdition(Entity entity)
        {
            Entities.Departamentos item = entity as Entities.Departamentos;
            if (item != null && item.FromDataSource)
            {
                DataEntities.SpDepartamentosSel sp = new DataEntities.SpDepartamentosSel();
                sp.ClaDepartamento = item.ID;

                DataTable dt = sp.GetDataTable(this.ConnectionString);
                if (dt != null && dt.Rows.Count == 1)
                {
                   
                    item.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaDepartamento", 0);
                    item.Campus = new Entities.Campus();
                    item.Campus.ID = Utils.GetDataRowValue(dt.Rows[0], "ClaCampus", 0);
                    item.Nombre = Utils.GetDataRowValue(dt.Rows[0], "NomDepartamento", "");

                }
            }
        }
       
    }
}