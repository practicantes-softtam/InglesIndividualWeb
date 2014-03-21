<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="InglesIndividual.Web.Paises" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/grid.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
    var grid = new Grid("PaisGrid");
    var settings = {
        source: {
            datafields: [{ name: 'Clave' }, { name: 'Nombre'}],
            url: 'Paises.aspx/GetData'
        },
        gridOptions: {
            columns: [
                        { text: 'ID', dataField: 'Clave', width: 100, cellsrenderer: renderEdit },
                        { text: 'Pais', dataField: 'Nombre', width: 300 },
                        { text: 'Eliminar', dataField: "Eliminar", sortable: false, cellsrenderer: renderDelete }
                    ]
        },
        adapter: {
            formatData: function (data) {
                if (data.sortdatafield != undefined && data.sortdatafield != null) {
                    switch (data.sortdatafield) {
                        case "Clave": data.sortdatafield = "ClaPais"; break;
                        case "Nombre": data.sortdatafield = "NomPais"; break;
                    }
                }
                return data;
            }
        },
        deleteOptions: {
            checkID: "Paises",
            fieldID: "Clave"
        }
    };

    $(document).ready(function () {
        grid.load(settings)
        $("#jqxwindow").jqxWindow({ width: 300, height: 300, autoOpen: false });
        $("#uiGuardar").jqxButton();
        $("#uiCancelar").jqxButton();

        $("#uiCancelar").click(function () {
            $("#jqxwindow").jqxWindow("close");
        });
        $("#form1").jqxValidator({
            rules: [
                { input: "#uiNombre", message: "El nombre del puesto es requerido", rule: "required" }
            ]
        });
        $("#form1").on('validationSuccess', function (event) {
            var actionData = {
                action: $("#uiAction").val(),
                id: $("#uiID").val(),
                nombre: $("#uiNombre").val()
            };
            var settings = {
                url: "paises.aspx/Guardar",
                data: JSON.stringify(actionData),
                success: function (msg) {
                    
                    grid.refresh();
                }
            };

            executeAjax(settings);
        });

        $("#uiGuardar").click(function () {
            $("#form1").jqxValidator("validate");
            
        });
        $("#uiNuevo").click(function () {
            $("#uiAction").attr("value", "add");
            $("#jqxwindow").jqxWindow("open");
        });

        $("#uiEliminar").click(function () {
            eliminar();
        });

        $("#uiBuscar").click(function () {
            grid.refresh();
        });

        grid.load(settings);
    });

    function eliminar() {
        var arr = grid.getRecordsForDelete();
        if (arr.length > 0) {
            var actionData = { ids: arr };
            var settings = {
                url: "paises.aspx/Eliminar",
                data: JSON.stringify(actionData),
                success: function (msg) {
                    if (msg.d != "") {
                        alert(msg.d);
                    }
                    grid.refresh();
                }
            };

            executeAjax(settings);
        }
    }


    
    function renderDelete(row, columnfield, value, defaulthtml, columnproperties) {
        return grid.renderDeleteCheckBox(row);
    }

</script>
 <input type="button" value ="Nuevo" id ="uiNuevo" />
 <input type="button" value="Eliminar" id="uiEliminar" />


<div id="PaisGrid"></div>

 <div id="jqxwindow">
        <div>Paises</div>
        <div>
            <input type="hidden" id="uiAction" />
            <table>
                <tr>
                    <td>ID</td><td><input type="text" id="uiID" disabled="disabled" /></td>
                </tr>
                <tr>
                    <td>Paises</td><td><input type="text" id="uiNombre" /></td>
                </tr>
                <tr>
                    <td colspan="2">

                        <input type="button" value="Guardar" id="uiGuardar" />&nbsp;
                        <input type="button" value="Cancelar" id="uiCancelar" /></td>
                </tr>
            </table>
        </div>
    </div>


</asp:Content>
