<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Niveles.aspx.cs" Inherits="InglesIndividual.Web.Niveles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var grid = new Grid("uiGrid", GetTheme());

        var settings = {
            source: {
                datafields: [{ name: 'ID' }, { name: 'Nombre'}],
                url: getFormName() + '.aspx/GetData'
            },
            gridOptions: {
                columns: [
                        { text: 'Nivel', dataField: 'Nombre', width: 380 },
                        { text: 'Eliminar', dataField: "Eliminar", width: 70, sortable: false, cellsrenderer: renderDelete },
                        { text: 'Editar', dataField: 'Editar', width: 50, cellsrenderer: renderEdit, columntype: 'button', buttonclick: editClick }
                    ]
            },
            adapter: {
                formatData: function (data) {
                    if (data.sortdatafield != undefined && data.sortdatafield != null) {
                        switch (data.sortdatafield) {
                            case "ID": data.sortdatafield = "ClaNivel"; break;
                            case "Nombre": data.sortdatafield = "NomNivel"; break;
                        }
                    }
                    var p1 = $("#uiNivel").val();
                    $.extend(data, {
                        nomNivel: p1
                    });
                    return data;
                }
            },
            deleteOptions: {
                checkID: "Niveles",
                fieldID: "ID"
            }
        };

        //Recarga el Combo de Estados al detectar un cambio en el de paises
        function uiPaisChange() {
            $("#uiPais").on('change', function (event) {
                var pais = $("#uiPais").jqxComboBox('getSelectedItem')
                if (pais.value > 0) {
                    ComboBoxDataBind(getEstadoSettings(pais.value));
                }
            });
        }
        //Establece los settings para cargar el combo Paises
        function getPaisSettings() {
            var settings = {
                id: "uiPais", //Id del Div que funcionará como combo
                form: getFormName(), //Nombre de la pantalla actual
                functionDataBind: "PaisesDataBind", //Nombre del web method de C# que nos traerá la info para llenar el combo
                theme: GetTheme()//Establece el tema del combo
            };
            return settings;
        }
        //Establece los settings para cargar el combo Estados
        function getEstadoSettings(claPais) {
            var settings = {
                id: "uiEstado",
                form: getFormName(),
                functionDataBind: "EstadosDataBind",
                theme: GetTheme(),
                filters: { 'claPais': claPais }
            };
            return settings;
        }
        //Establece los settings para cargar el combo Niveles
        function getNivelSettings() {
            var settings = {
                id: "uiCmbNivel",
                form: getFormName(),
                functionDataBind: "NivelesDataBind",
                theme: GetTheme()
            };
            return settings;
        }

        $(document).ready(function () {

            $("#jqxwindow").jqxWindow({ width: 300, height: 120, autoOpen: false, theme: GetTheme() });
            ComboBoxDataBind(getPaisSettings()); //Carga el Combo Paises
            ComboBoxDataBind(getEstadoSettings(-1)); //Carga el Combo Estados con TODOS los estados
            ComboBoxDataBind(getNivelSettings()); //Carga el Combo Puestos
            uiPaisChange(); //Inicializa la función que detecta cuando haya cambios en el combo Paises para recargar el combo Estados
            $("#uiNivel").jqxInput({ placeHolder: " Proporcione el Nivel a buscar", height: 30, width: 300 });
            $("#uiID").jqxInput({ placeHolder: " ID del Nivel", height: 30, width: 150, disabled: true });
            $("#uiNombre").jqxInput({ placeHolder: " Nombre del Nivel", height: 30, width: 200 });

            $("#mainForm").jqxValidator({
                theme: GetTheme(),
                rules: [
                { input: "#uiNombre", message: "El nombre del nivel es requerido", rule: "required" }
            ]
            });

            $("#mainForm").on('validationSuccess', function (event) {
                var actionData = {
                    action: $("#uiAction").val(),
                    id: $("#uiID").val(),
                    nombre: $("#uiNombre").val()
                };
                var settings = {
                    url: "niveles.aspx/Guardar",
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

        function renderDelete(row, columnfield, value, defaulthtml, columnproperties) {
            return grid.renderDeleteCheckBox(row);
        }

        function getFormName() {
            return "Niveles";
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
                Nivel
            </td>
            <td>
                <input type="text" id="uiNivel" />
            </td>
        </tr>
    </table>
    <div id="uiPais">
    </div>
    <div id="uiEstado">
    </div>
    <div id="uiCmbNivel">
    </div>
    <div id="uiGrid">
    </div>
    <div id="jqxwindow">
        <div>
            Niveles</div>
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
                        Nivel
                    </td>
                    <td>
                        <input type="text" id="uiNombre" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <br />
</asp:Content>
