<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="InglesIndividual.Web.Paises" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/grid.js" type="text/javascript"></script>
     <script src="js/jqxcombobox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
      
        var grid = new Grid("PaisGrid",GetTheme());
        var settings = {
            source: {
                datafields: [{ name: 'ID' }, { name: 'Nombre'}],
                url: getFormName() + '.aspx/GetData'
            },
            gridOptions: {
                columns: [
                        { text: 'Pais', dataField: 'Nombre', width: 300 },
                        { text: 'Eliminar', dataField: "Eliminar", width: 70, sortable: false, cellsrenderer: renderDelete },
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
                    var p1 = $("#uiPais").val();

                    $.extend(data, {
                        nomPais: p1
                    });
                    return data;
                   }
                
            },
            deleteOptions: {
                checkID: "Paises",
                fieldID: "ID"
            }
        };




        function getPaisSettings() {
            var settings = {
                id: "uiPais", //Id del Div que funcionará como combo
                form: getFormName(), //Nombre de la pantalla actual
                functionDataBind: "PaisesDataBind", //Nombre del web method de C# que nos traerá la info para llenar el combo
                theme: GetTheme()//Establece el tema del combo
            };
            return settings;
        }
  

        $(document).ready(function () {

            $("#jqxwindow").jqxWindow({ width: 300, height: 120, autoOpen: false, theme: GetTheme() });
            
            $("#uiPais").jqxInput({ placeHolder: " Proporcione el Pais a buscar", height: 30, width: 300 });
            
            $("#uiID").jqxInput({ placeHolder: " ID del Pais", height: 30, width: 150, disabled: true });
            $("#uiNombre").jqxInput({ placeHolder: " Nombre del Pais", height: 30, width: 200 });
            $("#mainForm").jqxValidator({
                theme: GetTheme( ),
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
                        // alert(msg);
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
        return "Paises";
    }

    function editClick(row) {
        
        editrow = row;
        var dataRecord = $("#" + grid.id).jqxGrid('getrowdata', editrow);
        edit(dataRecord.ID); /*Aqui en ves de pasar solo un parámetro se pasarian todos los que componen la llave compuesta*/
    }

    function edit(id) {
        alert(id);
        SetEntityForEdition(id);
    }

    function SetControlValues(entity) {
        $("#uiAction").attr("value", "edit");
        $('#jqxwindow').jqxWindow('open');
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
            <td>Pais</td><td><input type="text" id="uiPais" onclick="return uiPais_onclick()" /></td>
        </tr>
    </table>




 
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
