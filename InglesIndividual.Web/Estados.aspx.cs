﻿using System;
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
    public partial class Puestos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static string GetData()
        {
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string nomPuesto = HttpContext.Current.Request.QueryString.Get("nomEstado");
            JQXGridSettings settings = JsonGridData.GetGridSettings();

            Business.Estados bo = new Business.Estados();
            List<Entities.Estado> list = bo.ListarEstados(settings,0,"");
            
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
        public static string Eliminar(string[] ids)
        {
            Business.Estados bo = new Business.Estados();
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
            Business.Estados bo = new Business.Estados();
            Entities.Estado entity = new Entities.Estado();
            entity.ID = Utils.IsNull(id, 0);
            entity.SetFromDataSource(true);
            bo.PrepareEntityForEdition(entity);

            return js.Serialize(entity);
        }
        
        [WebMethod]
        public static void Guardar(string action, string id, string nombre)
        {
            Entities.Estado item;

            if (action.ToLower() == "add")
            {
                item = new Estado();
            }
            else
            {
                item = new Estado(true);
            }

            item.ID = Utils.IsNull(id, 0);
            item.Nombre = nombre;

            Business.Estados bo = new Business.Estados();
            bo.Save(item);

        }


        //Trae la información con la que se llenará el combo Puestos
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static string EstadosDataBind()
        {
            List<Entities.Estado> list = new List<Estado>();
            Business.Estados bo = new Business.Estados();
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