<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Ciudades.aspx.cs" Inherits="InglesIndividual.Web.Ciudades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/grid.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var grid = new Grid("uiGrid");
        var settings = {
            source: {
                datafields: [{ name: 'Clave' }, { name: 'Nombre'}],
                url: 'Ciudades.aspx/GetData'
            },
            gridOptions: {
                columns: [
                        { text: 'ID', dataField: 'Clave', width: 100, cellsrenderer: renderEdit },
                        { text: 'Ciudad', dataField: 'Nombre', width: 300 },
                        { text: 'Eliminar', dataField: "Eliminar", sortable: false, cellsrenderer: renderDelete }
                    ]
            },
            adapter: {
                formatData: function (data) {
                    if (data.sortdatafield != undefined && data.sortdatafield != null) {
                        switch (data.sortdatafield) {
                            case "Clave": data.sortdatafield = "ClaCiudad"; break;
                            case "Nombre": data.sortdatafield = "NomCiudad"; break;
                        }
                    }
                    var p1 = $("#uiCiudad").val();
                    $.extend(data, {
                        nomCiudad: p1
                    });
                    return data;
                }
            },
            deleteOptions: {
                checkID: "Ciudades",
                fieldID: "Clave"
            }
        };

        $(document).ready(function () {

            $("#jqxwindow").jqxWindow({ width: 300, height: 120, autoOpen: false, theme: GetTheme() });

            $("#uiCiudad").jqxInput({ placeHolder: " Proporcione la Ciudad a buscar", height: 30, width: 300 });
            $("#uiID").jqxInput({ placeHolder: " Clave de la Ciudad", height: 30, width: 150, disabled: true });
            $("#uiNombre").jqxInput({ placeHolder: " Nombre de la Ciudad", height: 30, width: 200 });

            $("#mainForm").jqxValidator({
                theme: GetTheme(),
                rules: [
                { input: "#uiNombre", message: "El nombre de la Ciudad es requerido", rule: "required" }
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

            configurarCombo();

            grid.load(settings, 500);
        });

        function configurarCombo() {
            var url = "puestos.aspx/PruebaCombo";
            // prepare the data
            var src =
            {
                datatype: "json",
                datafields: [
                    { name: 'Clave' },
                    { name: 'Nombre' }
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
            $("#combo").jqxComboBox({ theme: GetTheme(), selectedIndex: 0, source: adp, displayMember: "Nombre", valueMember: "ID", width: 200, height: 25 });
        }

        function renderDelete(row, columnfield, value, defaulthtml, columnproperties) {
            return grid.renderDeleteCheckBox(row);
        }

        function getFormName() {
            return "Ciudad";
        }

        function edit(id) {

            $("#uiAction").attr("value", "edit");
            $("#uiID").attr("value", id);
            $('#jqxwindow').jqxWindow('open');
        }

        //    function GetControlValues() {
        //        var url = document.URL;
        //        var params = "{clave:'" + document.URL.split('=')[1] + "'}";
        //        var entity;
        //        entity = SetEntityForEdition(params, 'AcidosEdit');
        //    }

        
    </script>
   <table>
        <tr>
            <td>Ciudad</td><td><input type="text" id="uiCiudad" /></td>
        </tr>
    </table>
    <div id="uiGrid">
    </div>

    <div id="combo"></div>
    <div id="jqxwindow">
        <div>Ciudades</div>
        <div>
            <input type="hidden" id="uiAction" />
            <table>
                <tr>
                    <td>ID</td><td><input type="text" id="uiID" disabled="disabled" /></td>
                </tr>
                <tr>
                    <td>Ciudad</td><td><input type="text" id="uiNombre" /></td>
                </tr>
            </table>
        </div>
    </div>
    <br />
</asp:Content>
