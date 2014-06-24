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
    public partial class Campus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static string GetData()
        {
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string nomCampus = HttpContext.Current.Request.QueryString.Get("nomCampus");
            string calle = HttpContext.Current.Request.QueryString.Get("calle");
            string colonia = HttpContext.Current.Request.QueryString.Get("colonia");
            string telefono = HttpContext.Current.Request.QueryString.Get("telefono");
            //string Pais = HttpContext.Current.Request.QueryString.Get("claPais");
            //string Estado = HttpContext.Current.Request.QueryString.Get("claEstado");
            //string Ciudad = HttpContext.Current.Request.QueryString.Get("claCiudad");

            JQXGridSettings settings = JsonGridData.GetGridSettings();

            Business.Campus bo = new Business.Campus();
            List<Entities.Campus> list = bo.ListarCampus(settings, nomCampus, calle, colonia, telefono, 0,0,0);
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
        public static string GetDataAjax(string nombre, string calle, string colonia, string telefono, string []arreglo)
        {
            return string.Format("Hola {0} {1}", nombre, calle, colonia, telefono);
        }

        [WebMethod]
        public static string Eliminar(string [] ids)
        {
           Business.Campus bo = new Business.Campus();
            List<Exception> list = bo.Eliminar(ids);
            if (list.Count >0)
            {
                string errores = "";
                foreach (Exception ex in list)
                {
                    errores += ex.Message;
                }
                return "No se pudieron eliminar algunos registros" + errores;
            }
            return "";
        }

        [WebMethod]
        public static string GetEntityForEdition(string id)
        {
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            Business.Campus bo = new Business.Campus();
            Entities.Campus entity = new Entities.Campus();
            entity.ID = Utils.IsNull(id, 0);
            entity.SetFromDataSource(true);
            bo.PrepareEntityForEdition(entity);
            return js.Serialize(entity);
        }


        [WebMethod]
        public static void Guardar(string action, string id, string nombre, string calle, string colonia, string telefono)
        {
            Entities.Campus item;

            if (action.ToLower() == "add")
            {
                item = new Entities.Campus();
            }
            else
            {
                item = new Entities.Campus(true);
            }

            item.ID = Utils.IsNull(id, 0);
            item.Nombre = nombre;
            item.Calle = calle;
            item.Colonia = colonia;
            item.Telefono = telefono;
            Business.Campus bo = new Business.Campus();
            bo.Save(item);

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static string PruebaCombo()
        {
            List<Entities.Campus> list = new List<Entities.Campus>();
            for (int i = 1; i <= 10; i++)
            {
                Entities.Campus item = new Entities.Campus();
                item.ID = i;
                item.Nombre = string.Format("Campus {0}", 0);
                item.Calle = string.Format("Calle {0}", 0);
                item.Colonia = string.Format("Colonia {0}", 0);
                item.Telefono = string.Format("Telefono {0}", 0);
                list.Add(item);
            }
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();

            return js.Serialize(list);

        }

    }
}