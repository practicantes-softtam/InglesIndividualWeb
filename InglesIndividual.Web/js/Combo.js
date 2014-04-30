function ComboBoxDataBind(ObjectId, form, functionDataBind, theme, params) {

    var DisplayMember, KeyValue;
    DisplayMember = "Nombre";
    KeyValue = "ID";
    var theme = theme;
    // prepare the data
    //var datafields = "{ name: KeyValue },{ name: DisplayMember }";
    var data = LoadSourceCombo(form, functionDataBind, KeyValue, DisplayMember, params);
    alert(data);
    var source =
        {
            datatype: "json",
            datafields: [
                { name: KeyValue },
                { name: DisplayMember }
            ],

            localdata: data

        };
            
    var dataAdapter = new $.jqx.dataAdapter(source);
    //alert("dataAdapter:" + dataAdapter);
    // Create a jqxComboBox
    $(ObjectId).jqxComboBox({ selectedIndex: 0, source: dataAdapter, displayMember: DisplayMember, valueMember: KeyValue, width: 200, height: 25, theme: theme });
    // trigger the select event.
    $(ObjectId).on('select', function (event) {
        if (event.args) {
            var item = event.args.item;
            if (item) {
                var valueelement = $("<div></div>");
                valueelement.text("Value: " + item.value);
                var labelelement = $("<div></div>");
                labelelement.text("Label: " + item.label);
            }
        }
    });
}


function LoadSourceCombo(form, functionDataBind, KeyValue, DisplayMember, params) {
    var url, data1, data;
    url = form + ".aspx/" + functionDataBind;
    
    if (params == "") {
        data = "[{ name: " + KeyValue + " }, { name: " + DisplayMember + "}]";
        alert("data: " + data);
        var result;
        $.ajax
        (
            {
                async: false,
                type: "GET",
                url: url, //from+".aspx/"+functionDataBind,
                data: data, //[{ name: KeyValue }, { name: DisplayMember}],
//                datafields: [
//                                { name: 'ID' },
//                                { name: 'Nombre' }
//                            ],
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (response) {
                    result = response.d;
                },
                error: function (err) {
                    //alert('Error' + err.text);
                    return "";
                }
            }
        );
    }
        else {
            data = JSON.Parse("[{ name: " + KeyValue + " }, { name: " + DisplayMember + "},{name:claPais, value:-1}]");
            alert("data: " + data);
            var result;
            $.ajax
        (
            {
                async: false,
                type: "GET",
                url: url, //from+".aspx/"+functionDataBind,
                data: data, //[{ name: KeyValue }, { name: DisplayMember}],
                //                datafields: [
                //                                { name: 'ID' },
                //                                { name: 'Nombre' }
                //                            ],
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (response) {
                    result = response.d;
                },
                error: function (err) {
                    //alert('Error' + err.text);
                    return "";
                }
            }
        );
    }
    return result;
}

function ComboBoxDataBind(settings) {
    var url = settings.form + ".aspx/" + settings.functionDataBind;
    var w = 200;
    var h = 25;
    var theme = "classic";

    if (settings.width != undefined) {
        w = settings.width;
    }
    if (settings.height != undefined) {
        h = settings.height;
    }
    if (settings.theme != undefined) {
        theme = settings.theme;
    }

    var src =
    {
        datatype: "json",
        datafields: [
            { name: settings.displayMember },
            { name: settings.valueMember }
        ],
        url: url
    };

    var adp = new $.jqx.dataAdapter(src, {
        contentType: 'application/json; charset=utf-8',
        downloadComplete: function (data, textStatus, jqXHR) {
            var items = JSON.parse(data.d);
            $("#" + settings.id).jqxComboBox({ source: items, displayMember: settings.displayMember, valueMember: settings.valueMember, width: w, height: h, theme: theme });
            return data.d;
        },
        formatData: function (data) {
            if (settings.filters != undefined) {
                $.extend(data, settings.filters);
            }
            return data;
        }
    });
    adp.dataBind();
}