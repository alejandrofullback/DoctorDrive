MenuViewModel = function () {
    var self = this;
    self.showMenu = ko.observable();
    self.UI = {};
    self.UI.Actions = {};
    self.UI.Actions.changePage = function (data, evt) {
        var id = $(evt.currentTarget).data('name');
        $(document).trigger('page-change', [id]);
    };

    self.UI.Actions.showMenu = function (data) {
        self.showMenu(data);
    };
};
MenuViewModel.id = "menu/html/menu";
