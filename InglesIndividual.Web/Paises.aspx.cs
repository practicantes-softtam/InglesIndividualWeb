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
    public partial class Paises : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static string GetData()
        {
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();

            JQXGridSettings settings = JsonGridData.GetGridSettings();

            Business.Paises bo = new Business.Paises();
            List<Entities.Pais> list = bo.ListarPaises(settings, "");

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
     
        public static void Guardar(string action, string id, string nombre)
        {
            Entities.Pais item;

            if (action.ToLower() == "add")
            {
                item = new Pais();
            }
            else
            {
                item = new Pais(true);
            }
            item.Clave = Utils.IsNull(id, 0);
            item.Nombre = nombre;
            Business.Paises bo = new Business.Paises();
            bo.Save(item);



        }

        [WebMethod]
        public static string Eliminar(string[] ids)
        {
            Business.Paises bo = new Business.Paises();
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

    