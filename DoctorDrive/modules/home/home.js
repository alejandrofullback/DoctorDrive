HomeViewModel = function () {
    var self = this;
    self.template = "home/html/home";
    self.Actions = {};
    self.UI = {};
    self.UI.Actions = {};
    self.List = {};
    self.List.Items = ko.observableArray([]);
    self.Actions.startModule = function () {
        self.Actions.tryLoadRuleList();
    };
    self.Actions.tryLoadRuleList = function () {
        self.List.Items([]);
        self.List.Items.push({ id: "1", leito: "L1", nome: "Paciente L1", diagnostico: "D1", conducta: "C1" });
        self.List.Items.push({ id: "2", leito: "L2", nome: "Paciente L2", diagnostico: "D2", conducta: "C2" });
        self.List.Items.push({ id: "3", leito: "L3", nome: "Paciente L3", diagnostico: "D3", conducta: "C3" });
    };
    
    self.UI.Actions.changePage = function (data, evt) {

        var currentId = $(evt.currentTarget).data('id');
        var targetName = $(evt.currentTarget).data('name');
        console.log(currentId + " " + targetName);
        doctor_drive_globals.currentItemId = currentId;
        $(document).trigger('page-change', [targetName]);
    };
};

HomeViewModel.id = "home";