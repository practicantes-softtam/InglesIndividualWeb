using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using InglesIndividual.DataEntities;
using InglesIndividual.Entities;
using System.Data;

namespace InglesIndividual.Data
{
    public class InglesIndividualDataObject : BaseDataObject
    {
        public InglesIndividualDataObject()
        {
        }

        public void ConfigurePagedStoredProcedure(PagedStoredProcedure sp, JQXGridSettings settings)
        {
            sp.NumPagina = settings.PageNumber;
            sp.OrdenarPor = settings.OrderBy;
            sp.TamanioPagina = settings.PageSize;
        }

        public void SetWebEntityGridValues(WebEntity item, DataRow dr)
        {
            item.TotalRecords = Utils.GetDataRowValue(dr, PagedStoredProcedure.COL_TOTAL_REGISTROS, 0);
        }
    }
}
