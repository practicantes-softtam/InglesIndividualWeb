using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Data;

namespace InglesIndividual.Data
{
    public class ExtensionesCurso : InglesIndividualDataObject
    {
        public List<Entities.ExtensionesCurso> ListarExtensionesCurso(InglesIndividual.Entities.JQXGridSettings settings, string matricula)
        {
            List<Entities.ExtensionesCurso> list = new List<Entities.ExtensionesCurso>();
            DataEntities.SpExtensionesCursoGrd sp = new DataEntities.SpExtensionesCursoGrd();
            sp.Matricula = matricula;

            this.ConfigurePagedStoredProcedure(sp, settings);

            DataTable dt = sp.GetDataTable(this.ConnectionString);
            foreach (DataRow dr in dt.Rows)
            {
                Entities.ExtensionesCurso item = new Entities.ExtensionesCurso(true);

                item.IdRegistro = Utils.GetDataRowValue(dr, "IdRegistro", 0);
                item.Campus = new Entities.Campus();
                item.Campus.ID = Utils.GetDataRowValue(dr, "Clave", 0);
                item.Matricula = Utils.GetDataRowValue(dr, "Matricula", "");
                item.FechaIni = Utils.GetDataRowValue(dr, "FechaIni", 0);
                item.FechaFin = Utils.GetDataRowValue(dr, "FechaFin", 0);
                item.Comentarios = Utils.GetDataRowValue(dr, "Comentarios", "");
                item.Estatus = Utils.GetDataRowValue(dr, "Estatus", 0);
                item.ClaNivel = Utils.GetDataRowValue(dr, "ClaNivel", 0);
                item.ClaLeccion = Utils.GetDataRowValue(dr, "ClaLeccion", 0);
                item.TipoRegistro = Utils.GetDataRowValue(dr, "FechaHoraOriginal", 0);

                this.SetWebEntityGridValues(item, dr);

                list.Add(item);
            }

            return list;
        }

        public override int Insert(Entity entity, DataTransaction tran)
        {
            Entities.ExtensionesCurso item = entity as Entities.ExtensionesCurso;
            DataEntities.SpExtensionesCursoIns
                sp = new DataEntities.SpExtensionesCursoIns();
            sp.IdRegistro = item.IdRegistro;
            sp.ClaCampus = item.Campus.ID;
            sp.Matricula = item.Matricula;
            sp.FechaIni = item.FechaIni;
            sp.FechaFin = item.FechaFin;
            sp.Comentarios = item.Comentarios;
            sp.Estatus = item.Estatus;
            sp.ClaNivel = item.ClaNivel;
            sp.ClaLeccion = item.ClaLeccion;
            sp.TipoRegistro = item.TipoRegistro;
           

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
            Entities.ExtensionesCurso item = entity as Entities.ExtensionesCurso;
            DataEntities.SpExtensionesCursoDel
                sp = new DataEntities.SpExtensionesCursoDel();
            sp.IdRegistro = item.IdRegistro;

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
