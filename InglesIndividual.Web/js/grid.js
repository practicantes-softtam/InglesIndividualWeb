function Grid(id, GetTheme) {
    this.id = id;
    //this.settings = settings;

    this.load = function (settings, gridWidth) {
        this.settings = settings;
        var gridID = this.id;
        var source = {
            datafields: [{ name: 'Eliminar'}],
            type: "GET",
            datatype: "json",
            cache: false,
            sort: function () {
                $("#" + gridID).jqxGrid('updatebounddata', 'sort');
            }
        };
        var adapterSettings = {
            contentType: 'application/json; charset=utf-8',
            downloadComplete: function (data, textStatus, jqXHR) {
                var json = JSON.parse(data.d);
                source.totalrecords = json.TotalRecords;
                return json.Data;
            }
        };

        if (this.settings.source != undefined) {
            source = $.extend({}, source, this.settings.source);
        }

        if (this.settings.adapter != undefined) {
            adapterSettings = $.extend({}, adapterSettings, this.settings.adapter);
        }

        var dataAdapter = new $.jqx.dataAdapter(source, adapterSettings);

        var gridSettings = {
            theme: GetTheme,
            source: dataAdapter,
            editable: false,
            pageable: true,
            altrows: true,
            sortable: true,
            //autoheight: true,
            pagesize: 25,
            pagesizeoptions: ['5', '10', '15', '20', '25', '50'],
            virtualmode: true,
            rendergridrows: function (args) {
                return args.data;
            },
            enabletooltips: true,
            width: gridWidth
        }

        if (this.settings.gridOptions != undefined) {
            gridSettings = $.extend({}, gridSettings, this.settings.gridOptions);
        }

        __grid = $("#" + this.id);
        if (__grid.length > 0) {
            __grid.jqxGrid(gridSettings);
        }
    }

    this.refresh = function(){
        var __grid = $("#" + this.id);
        if (__grid.length > 0) {
            __grid.jqxGrid("clear");
            __grid.jqxGrid("updatebounddata");
        }
    }

    this.renderDeleteCheckBox = function(row) {
        var __grid = $("#" + this.id);
        if (__grid.length > 0) {
            var celValue = __grid.jqxGrid('getcellvalue', row, this.settings.deleteOptions.fieldID);
            return "<input type=\"checkbox\" value=\"" + celValue + "\" data-id=\"" + this.settings.deleteOptions.checkID + "\" />";
        }

        return "";
    }

    this.getCheckedValues = function() {
        var chks = $("[data-id='" + this.settings.deleteOptions.checkID + "']");
        var checkedValues = [];
        if (chks.length > 0) {
            for (var x = 0; x < chks.length; x++) {
                if (chks[x].checked) {
                    checkedValues.push(chks[x].value);
                }
            }
        }

        return checkedValues;
    }

    this.getRecordsForDelete = function () {
        var arr = grid.getCheckedValues();
        if (arr.length > 0) {
            if (confirm("¿Desea eliminar los registros seleccionados?")) {
                return arr;
            }
        }
        return [];
    }
}

function renderEdit(row, columnfield, value, defaulthtml, columnproperties) {
    return "Editar"; /*"<span style=\"padding-left: 5px\"><a href=\"javascript:edit('" + value + "');\">" + value + "</a></span>";*/
}

function editClick(row) {
    editrow = row;
    var dataRecord = $("#" + grid.id).jqxGrid('getrowdata', editrow);
    edit(dataRecord.ID);
}
                        


function executeAjax(ajaxSettings) {
    var settings = {
        dataType: "json",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        error: function (result) {
            alert("ERROR " + result.status + ' ' + result.statusText);
        }
    };

    settings = $.extend({}, settings, ajaxSettings);

    $.ajax(settings);
}