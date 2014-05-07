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
using Framework;

namespace InglesIndividual.Web
{
    public partial class Lecciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]

        public static string GetData()
        {
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string NomLeccion = HttpContext.Current.Request.QueryString.Get("NomLeccion");
            JQXGridSettings settings = JsonGridData.GetGridSettings();
            Business.Lecciones bo = new Business.Lecciones();
            List<Entities.Lecciones> list = bo.ListarLecciones(settings,"",0,0,0);
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
        public static string GetDataAjax(string nombre, string[] arreglo)
        {
            return string.Format("Hola {0} {1}", nombre);
        }

        [WebMethod]
        public static string Eliminar(string[] ids)
        {
            Business.Lecciones bo = new Business.Lecciones();
            List<Exception> list = bo.Eliminar(ids);
            if (list.Count > 0)
            {
                string errores = "";
                foreach (Exception ex in list)
                {
                    errores += ex.Message;
                }
                return "No se pudieron eliminar algunas lecciones " + errores;
            }

            return "";
        }
        [WebMethod]
        public static void Guardar(string action, string id, string nombre)
        {
            Entities.Lecciones item;
            if (action.ToLower() == "add")
            {
                item = new Entities.Lecciones();
            }
            else
            {
                item = new Entities.Lecciones(true);
            }
            item.Clave = Utils.IsNull(id, 0);
            item.Nombre = nombre;
            Business.Lecciones bo = new Business.Lecciones();
            bo.Save(item);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static string PruebaCombo()
        {
            List<Entities.Lecciones> list = new List<Entities.Lecciones>();
            for (int i = 1; i <= 10; i++)
            {
                Entities.Lecciones item = new Entities.Lecciones();
                item.Clave = i;
                item.Nombre = string.Format("Leccion {0}", 0);
                list.Add(item);
            }
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();

            return js.Serialize(list);

        }
    }
}