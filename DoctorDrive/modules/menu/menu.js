MenuViewModel = function () {
    var self = this;
    self.showMenu = ko.observable();
    self.UI = {};
    self.UI.Actions = {};
    self.UI.Actions.changePage = function (data, evt) {
        var id = $(evt.currentTarget).data('name');
        if (id.indexOf("list") != -1) {
            doctor_drive_globals.currentPage = 1;
        }
        $(document).trigger('page-change', [id]);
    };

    self.UI.Actions.showMenu = function (data) {
        self.showMenu(data);
    };
};
MenuViewModel.id = "menu/html/menu";
