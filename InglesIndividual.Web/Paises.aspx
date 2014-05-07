<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="InglesIndividual.Web.Paises" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/grid.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
    var grid = new Grid("PaisGrid");
    var settings = {
        source: {
            datafields: [{ name: 'ID' }, { name: 'Nombre'}],
            url: getFormName() + '.aspx/GetData'
        },
        gridOptions: {
            columns: [
                        //{ text: 'ID', dataField: 'Clave', width: 100, cellsrenderer: renderEdit },
                        { text: 'Pais', dataField: 'Nombre', width: 300 },
                        { text: 'Eliminar', dataField: "Eliminar", sortable: false, cellsrenderer: renderDelete },
                        { text: 'Editar', dataField: 'Editar', width: 50, cellsrenderer: renderEdit, columntype: 'button', buttonclick: editClick }

                    ]
        },
        adapter: {
            formatData: function (data) {
                if (data.sortdatafield != undefined && data.sortdatafield != null) {
                    switch (data.sortdatafield) {
                        case "ID": data.sortdatafield = "ClaPais"; break;
                        case "Nombre": data.sortdatafield = "NomPais"; break;
                    }
                }
                return data;
            }
        },
        deleteOptions: {
            checkID: "Paises",
            fieldID: "ID"
        }
    };

    $(document).ready(function () {
        grid.load(settings)
        $("#jqxwindow").jqxWindow({ width: 300, height: 120, autoOpen: false, theme: GetTheme() });
       
        $("#uiID").jqxInput({ placeHolder: " ID del Pais", height: 30, width: 150, disabled: true });
        $("#uiNombre").jqxInput({ placeHolder: " Nombre del Pais", height: 30, width: 200 });


        $("#mainForm").jqxValidator({
            theme: GetTheme(),
            rules: [
                { input: "#uiNombre", message: "El nombre del pais es requerido", rule: "required" }
            ]
        });
        $("#mainForm").on('validationSuccess', function (event) {
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

        grid.load(settings,500);
    });

   
    function renderDelete(row, columnfield, value, defaulthtml, columnproperties) {
        return grid.renderDeleteCheckBox(row);
    }

    function getFormName() {
        return "Paises";
    }

    function edit(id) {
        SetEntityForEdition(id);
    }

    function SetControlValues(entity) {
        $("#uiAction").attr("value", "edit");
        $('#uiID').val(entity.ID);
        $('#uiNombre').val(entity.Nombre);
        $('#jqxwindow').jqxWindow('open');
    }

    function CleanControls(entity) {
        $('#uiID').val("");
        $('#uiNombre').val("");
    }






</script>
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
              
            </table>
        </div>
    </div>


</asp:Content>
