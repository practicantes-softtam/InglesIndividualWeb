<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Puestos.aspx.cs" Inherits="InglesIndividual.Web.Puestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/grid.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript">
    var grid = new Grid("uiGrid");

    var settings = {
        source: {
            datafields: [{ name: 'ID' }, { name: 'Nombre'}],
            url: 'Puestos.aspx/GetData'
        },
        gridOptions: {
            columns: [
                        { text: 'ID', dataField: 'ID', width: 100, cellsrenderer: renderEdit },
                        { text: 'Puesto', dataField: 'Nombre', width: 100 },
                        { text: 'Eliminar', dataField: "Eliminar", sortable: false, cellsrenderer: renderDelete }
                    ]
        },
        adapter: {
            formatData: function (data) {
                if (data.sortdatafield != undefined && data.sortdatafield != null) {
                    switch (data.sortdatafield) {
                        case "ID": data.sortdatafield = "ClaPuesto"; break;
                        case "Nombre": data.sortdatafield = "NomPuesto"; break;
                    }
                }
                var p1 = $("#param1").val();
                $.extend(data, {
                    nomPuesto: p1
                });
                return data;
            }
        },
        deleteOptions: {
            checkID: "Puestos",
            fieldID : "ID"
        }
    };

    $(document).ready(function () {

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
                url: "puestos.aspx/Guardar",
                data: JSON.stringify(actionData),
                success: function (msg) {
                    if (msg.d != "") {
                        alert(msg.d);
                    }
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

    function renderDelete(row, columnfield, value, defaulthtml, columnproperties) {
        return grid.renderDeleteCheckBox(row);
    }

    function eliminar() {
        var arr = grid.getRecordsForDelete();
        if(arr.length > 0){
            var actionData = { ids: arr };
            var settings = {
                url: "puestos.aspx/Eliminar",
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

    function edit(id) {
        $("#uiAction").attr("value", "edit");
        $("#uiID").attr("value", id);
        $('#jqxwindow').jqxWindow('open');
    }

    </script>
	<table>
        <tr>
            <td>Parametro 1</td><td><input type="text" id="param1" /></td>
        </tr>
        <tr>
            <td>
                <input type="button" value="Buscar" id="uiBuscar" />
                <input type="button" value="Eliminar" id="uiEliminar" />
                <input type="button" value="Nuevo" id="uiNuevo" />
            </td>
        </tr>
    </table>
    <div id="uiGrid">
    </div>

    <div id="jqxwindow">
        <div>Puestos</div>
        <div>
            <input type="hidden" id="uiAction" />
            <table>
                <tr>
                    <td>ID</td><td><input type="text" id="uiID" disabled="disabled" /></td>
                </tr>
                <tr>
                    <td>Puesto</td><td><input type="text" id="uiNombre" /></td>
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
