<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Campus.aspx.cs" Inherits="InglesIndividual.Web.Campus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/grid.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var grid = new Grid("uiGrid", GetTheme());

        var settings = {
            source: {
                datafields: [{ name: 'Clave' }, { name: 'Nombre' }, { name: 'Calle' }, { name: 'Colonia' }, {name:'Telefono'}],
                url: 'Campus.aspx/GetData'
            },
            gridOptions: {
                columns: [
                        { text: 'Clave', dataField: 'Clave', width: 100, cellsrenderer: renderEdit },
                        { text: 'Campus', dataField: 'Nombre', width: 300 },
                        { text: 'Calle', dataField: 'Nombre', width: 300 },
                        { text: 'Colonia', dataField: 'Nombre', width: 300 },
                        { text: 'Telefono', dataField: 'Nombre', width: 300 },
                        { text: 'Eliminar', dataField: "Eliminar", sortable: false, cellsrenderer: renderDelete }
                    ]
            },
            adapter: {
                formatData: function (data) {
                    if (data.sortdatafield != undefined && data.sortdatafield != null) {
                        switch (data.sortdatafield) {
                            case "Clave": data.sortdatafield = "ClaCampus"; break;
                            case "Nombre": data.sortdatafield = "NomCampus"; break;
                            case "Calle": data.sortdatafield = "Calle"; break;
                            case "Colonia": data.sortdatafield = "Colonia"; break;
                            case "Telefono": data.sortdatafield = "Telefono"; break;
                        }
                    }
                    var p1 = $("#param1").val();
                    $.extend(data, {
                        nomCampus: p1
//                        calle: p1,
//                        colonia: p1,
//                        telefono: p1
                    });
                    return data;
                }
            },
            deleteOptions: {
                checkID: "Campus",
                fieldID: "ID"
            }
        };

        $(document).ready(function () {

            $("#jqxwindow").jqxWindow({ width: 300, height: 120, autoOpen: false, theme: GetTheme() });

            $("#uiPuesto").jqxInput({ placeHolder: " Proporcione el Campus a buscar", height: 30, width: 300 });
            $("#uiID").jqxInput({ placeHolder: " ID del Campus", height: 30, width: 150, disabled: true });
            $("#uiNombre").jqxInput({ placeHolder: " Nombre del Campus", height: 30, width: 200 });

            $("#mainForm").jqxValidator({
                theme: GetTheme(),
                rules: [
                { input: "#uiNombre", message: "El nombre del campus es requerido", rule: "required" }
            ]
            });

            $("#mainForm").jqxValidator({
                rules: [
                { input: "#uiCalle", message: "La calle del Campus es requerido", rule: "required" }
            ]
            });

            $("#mainForm").jqxValidator({
                rules: [
                { input: "#uiColonia", message: "La colonia  del Campus es requerido", rule: "required" }
            ]
            });

            $("#mainForm").jqxValidator({
                rules: [
                { input: "#uiTelefono", message: "El teléfono del Campus es requerido", rule: "required" }
            ]
            });

            $("#mainForm").on('validationSuccess', function (event) {
                var actionData = {
                    action: $("#uiAction").val(),
                    id: $("#uiID").val(),
                    nombre: $("#uiNombre").val(),
                    calle: $("#iuCalle").val(),
                    colonia: $("iuColonia").val(),
                    telefono: $("iuTelefono").val()
                };
                var settings = {
                    url: "Campus.aspx/Guardar",
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

              });

        configurarCombo();

        grid.load(settings, 500);
    });

           
        function configurarCombo() {
            var url = "Campus.aspx/PruebaCombo";
            // prepare the data
            var src =
            {
                datatype: "json",
                datafields: [
                    { name: 'Clave' },
                    { name: 'Nombre' },
                    { name: 'Calle' },
                    { name: 'Colonia' },
                    { name: 'Telefono'}
                ],
                url: url
            };
            var adp = new $.jqx.dataAdapter(src, {
                contentType: 'application/json; charset=utf-8',
                downloadComplete: function (data, textStatus, jqXHR) {
                    //alert(data.d);
                    return data.d;
                }
            });
            //adp.dataBind();
            $("#combo").jqxComboBox({ selectedIndex: 0, source: adp, displayMember: "Nombre", valueMember: "ID", width: 200, height: 25 });
        }
        function renderDelete(row, columnfield, value, defaulthtml, columnproperties) {
            return grid.renderDeleteCheckBox(row);
        }

        function getFormName() {
        return "Campus";
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
            <td>
                Parametro 1
            </td>
            <td>
                <input type="text" id="param1" />
            </td>
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
    <div id="combo">
    </div>
    <div id="jqxwindow">
        <div>
            Campus</div>
        <div>
            <input type="hidden" id="uiAction" />
            <table>
                <tr>
                    <td>
                        ID
                    </td>
                    <td>
                        <input type="text" id="uiID" disabled="disabled" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Campus
                    </td>
                    <td>
                        <input type="text" id="uiNombre" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Calle
                    </td>
                    <td>
                        <input type="text" id="Text1" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Colonia
                    </td>
                    <td>
                        <input type="text" id="Text2" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Teléfono
                    </td>
                    <td>
                        <input type="text" id="Text3" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="button" value="Guardar" id="uiGuardar" />&nbsp;
                        <input type="button" value="Cancelar" id="uiCancelar" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <br />
</asp:Content>
