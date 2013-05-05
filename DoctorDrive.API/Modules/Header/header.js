HeaderViewModel = function () {
    var self = this;
    self.UI = {};
    self.UI.Actions = {};
    self.UI.Actions.changePage = function (data, evt) {
        var id = $(evt.currentTarget).data('name');
        $(document).trigger('page-change', [id]);
    };
};
HeaderViewModel.id = "header/html/header";
