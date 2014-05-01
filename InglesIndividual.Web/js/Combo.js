function ComboBoxDataBind(settings) {
    var url = settings.form + ".aspx/" + settings.functionDataBind;
    var w = 200;
    var h = 25;
    var theme = "classic";
    var dm = "Nombre";
    var vm = "ID";

    if (settings.width != undefined) {
        w = settings.width;
    }
    if (settings.height != undefined) {
        h = settings.height;
    }
    if (settings.theme != undefined) {
        theme = settings.theme;
    }
    if (settings.displayMember != undefined) {
        dm = settings.displayMember;
    }
    if (settings.valueMember != undefined) {
        vm = settings.valueMember;
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
            $("#" + settings.id).jqxComboBox({ source: items, displayMember: dm, valueMember: vm, width: w, height: h, theme: theme });
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