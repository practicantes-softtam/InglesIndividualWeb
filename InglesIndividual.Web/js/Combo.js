function ComboBoxDataBind(ObjectId, form, functionDataBind, theme) {

    var DisplayMember, KeyValue;
    DisplayMember = "Nombre";
    KeyValue = "ID";
    var theme = theme;
    // prepare the data

    var data = LoadSourceCombo(form, functionDataBind, KeyValue, DisplayMember);
    //alert(data);
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


function LoadSourceCombo(form, functionDataBind, KeyValue, DisplayMember) {
    var url;
    url = form + ".aspx/" + functionDataBind;
    
    var result;
    $.ajax
    (
        {
            async: false,
            type: "GET",
            url: url, //from+".aspx/"+functionDataBind,
            data: [{ name: KeyValue }, { name: DisplayMember}],
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
    return result;
}
