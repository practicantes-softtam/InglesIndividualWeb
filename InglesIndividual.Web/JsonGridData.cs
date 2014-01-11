using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using InglesIndividual.Entities;
using Framework;

namespace InglesIndividual.Web
{
    public class JsonGridData
    {
        private IList _data;
        private int _totalRecords;

        public IList Data
        {
            get { return this._data; }
        }

        public int TotalRecords
        {
            get { return this._totalRecords; }
        }

        public JsonGridData(IList data, int totalRecords)
        {
            this._data = data;
            this._totalRecords = totalRecords;
        }

        public static JQXGridSettings GetGridSettings()
        {
            JQXGridSettings settings = new JQXGridSettings();
            string sort = HttpContext.Current.Request.QueryString.Get("sortdatafield");
            string sortOrder = HttpContext.Current.Request.QueryString.Get("sortorder");
            string pageNum = HttpContext.Current.Request.QueryString.Get("pagenum");
            string pageSize = HttpContext.Current.Request.QueryString.Get("pagesize");

            settings.PageNumber = Utils.IsNull(pageNum, 0);
            settings.PageSize = Utils.IsNull(pageSize, 0);

            if (sort != null && sortOrder != null && sort.Trim() != "" && sortOrder.Trim() != "")
            {
                settings.OrderBy = string.Format("{0} {1}", sort, sortOrder);
            }

            return settings;
        }
    }
}