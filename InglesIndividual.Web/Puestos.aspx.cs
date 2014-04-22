using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.Script.Services;
using InglesIndividual.Entities;

namespace InglesIndividual.Web
{
    public partial class Puestos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            List<Entities.Puesto> list = new List<Entities.Puesto>();
            for (int i = 1; i <= 10; i++)
            {
                Entities.Puesto item = new Entities.Puesto();
                item.ID = i;
                item.Nombre = "Puesto " + i.ToString();

                list.Add(item);
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            string x = js.Serialize(list);*/
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static string GetData()
        {
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string nomPuesto = HttpContext.Current.Request.QueryString.Get("nomPuesto");
            JQXGridSettings settings = JsonGridData.GetGridSettings();

            Business.Puestos bo = new Business.Puestos();
            List<Entities.Puestos> list = bo.ListarPuestos(settings, nomPuesto);
            
            int registros = 0;
            
            if (list.Count > 0)
            {
                registros = list[0].TotalRecords;
            }
            
            JsonGridData data = new JsonGridData(list, registros);

            string json = js.Serialize(data);

            return json;
        }

        [WebMethod]
        public static string GetDataAjax(string nombre, string apellido, string []arreglo)
        {
            return string.Format("Hola {0} {1}", nombre, apellido);
        }

        [WebMethod]
        public static string Eliminar(int [] ids)
        {
            Business.Puestos bo = new Business.Puestos();
            List<Exception> list = bo.Eliminar(ids);
            if (list.Count > 0)
            {
                string errores = "";
                foreach (Exception ex in list)
                {
                    errores += ex.Message;
                }
                return "No se pudieron eliminar algunos registros " + errores;
            }

            return "";
        }
    }
}