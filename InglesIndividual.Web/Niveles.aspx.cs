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
    public partial class Niveles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static string GetData()
        {
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string nomNivel = HttpContext.Current.Request.QueryString.Get("nomNivel");
            JQXGridSettings settings = JsonGridData.GetGridSettings();

            Business.Niveles bo = new Business.Niveles();
            List<Entities.Nivel> list = bo.ListarNiveles(settings, nomNivel);

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
        public static string GetDataAjax(string nombre, string apellido, string[] arreglo)
        {
            return string.Format("Hola {0} {1}", nombre, apellido);
        }

        [WebMethod]
        public static string Eliminar(string[] ids)
        {
            Business.Niveles bo = new Business.Niveles();
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

        [WebMethod]
        public static string GetEntityForEdition(string id)
        {
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            Business.Niveles bo = new Business.Niveles();
            Entities.Nivel entity = new Entities.Nivel();
            entity.ID = Utils.IsNull(id, 0);
            entity.SetFromDataSource(true);
            bo.PrepareEntityForEdition(entity);

            return js.Serialize(entity);
        }

        [WebMethod]
        public static void Guardar(string action, string id, string nombre)
        {
            Entities.Nivel item;

            if (action.ToLower() == "add")
            {
                item = new Nivel();
            }
            else
            {
                item = new Nivel(true);
            }

            item.ID = Utils.IsNull(id, 0);
            item.Nombre = nombre;

            Business.Niveles bo = new Business.Niveles();
            bo.Save(item);

        }


        //Trae la información con la que se llenará el combo Puestos
            [WebMethod]
            [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
            public static string NivelesDataBind()
            {
                List<Entities.Nivel> list = new List<Nivel>();
                Business.Niveles bo = new Business.Niveles();
                list = bo.Combo(0);
                System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
                return js.Serialize(list);
            }
            //Trae la información con la que se llenará el combo Paises
            [WebMethod]
            [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
            public static string PaisesDataBind()
            {
                List<Entities.Pais> list = new List<Pais>();
                Business.Paises bo = new Business.Paises();
                list = bo.Combo();
                System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
                return js.Serialize(list);
            }
            //Trae la información con la que se llenará el combo Estados
            [WebMethod]
            [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
            public static string EstadosDataBind(string claPais)
            {
                List<Entities.Estado> list = new List<Estado>();
                Business.Estados bo = new Business.Estados();
                list = bo.Combo(Utils.IsNull(claPais, -1));
                System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
                return js.Serialize(list);
            }
        }
    }


