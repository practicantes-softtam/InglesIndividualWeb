﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Puestos.aspx.cs" Inherits="InglesIndividual.Web.Puestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script type="text/javascript">
    var grid = new Grid("uiGrid",GetTheme());

    var settings = {
        source: {
            datafields: [{ name: 'ID' }, { name: 'Nombre'}],
            url: getFormName()+'.aspx/GetData'
        },
        gridOptions: {
            columns: [
                        { text: 'Puesto',   dataField: 'Nombre',    width: 380 },
                        { text: 'Eliminar', dataField: "Eliminar",  width: 70, sortable: false, cellsrenderer: renderDelete },
                        { text: 'Editar',   dataField: 'Editar',    width: 50, cellsrenderer: renderEdit, columntype: 'button', buttonclick: editClick }
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
                var p1 = $("#uiPuesto").val();
                $.extend(data, {
                    nomPuesto: p1
                });
                return data;
            }
        },
        deleteOptions: {
            checkID: "Puestos",
            fieldID: "ID"
        }
    };

    $(document).ready(function () {

        $("#jqxwindow").jqxWindow({ width: 300, height: 120, autoOpen: false, theme: GetTheme() });

        ComboBoxDataBind("#uiCmbPuesto", getFormName(), "PuestosDataBind", GetTheme());
        $("#uiPuesto").jqxInput({ placeHolder: " Proporcione el Puesto a buscar", height: 30, width: 300 });
        $("#uiID").jqxInput({ placeHolder: " ID del Puesto", height: 30, width: 150, disabled: true });
        $("#uiNombre").jqxInput({ placeHolder: " Nombre del Puesto", height: 30, width: 200 });

        $("#mainForm").jqxValidator({
            theme: GetTheme(),
            rules: [
                { input: "#uiNombre", message: "El nombre del puesto es requerido", rule: "required" }
            ]
        });

        $("#mainForm").on('validationSuccess', function (event) {
            var actionData = {
                action: $("#uiAction").val(),
                id: $("#uiID").val(),
                nombre: $("#uiNombre").val()
            };
            var settings = {
                url: "puestos.aspx/Guardar",
                data: JSON.stringify(actionData),
                success: function (msg) {
                    $("#jqxwindow").jqxWindow("close");
                    grid.refresh();

                    //                    if (msg.d != "") {
                    //                        alert(msg.d);
                    //                    }

                }
            };

            executeAjax(settings);
        });

        //configurarCombo();

        grid.load(settings, 500);
    });

//    function configurarCombo() {
//        var url = "Puestos.aspx/PruebaCombo";
//        // prepare the data
//        var src =
//            {
//                datatype: "json",
//                datafields: [
//                    { name: 'ID' },
//                    { name: 'Nombre' }
//                ],
//                url: url
//            };
//            var adp = new $.jqx.dataAdapter(src, {
//                contentType: 'application/json; charset=utf-8',
//                downloadComplete: function (data, textStatus, jqXHR) {
//                    //alert(data.d);
//                    return data.d;
//                }
//            });
//            //adp.dataBind();
//            $("#combo").jqxComboBox({ theme: GetTheme(), selectedIndex: 0, source: adp, displayMember: "Nombre", valueMember: "ID", width: 200, height: 25 });
//        }

    function renderDelete(row, columnfield, value, defaulthtml, columnproperties) {
        return grid.renderDeleteCheckBox(row);
    }

    function getFormName() {
        return "Puestos";
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
	<table>
        <tr>
            <td>Puesto</td><td><input type="text" id="uiPuesto" /></td>
        </tr>
    </table>
    <div id="uiGrid">
    </div>

    <div id="uiCmbPuesto"></div>
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
            </table>
        </div>
    </div>
    <br />
</asp:Content>
