HomeViewModel = function () {
    var self = this;
    self.template = "home/html/home";
    self.Actions = {};
    self.UI = {};
    self.UI.Actions = {};
    self.List = {};
    self.List.Items = ko.observableArray([]);
    self.leito = ko.observable();
    self.leito.selected = false;
    self.leito.id = "0";
    self.leito.nome = "";
    self.leito.diagnostico = "";
    self.leito.conducta = "";
    self.leito.deleting = false;


    self.Actions.startModule = function () {
        self.Actions.tryLoadList();
    };
    self.Actions.tryLoadList = function () {
        self.List.Items([]);
        self.List.Items.push({ selected: false, id: "1", leito: "L1", nome: "Paciente L1", diagnostico: "D1", conducta: "C1", deleting: ko.observable(false) });
        self.List.Items.push({ selected: false, id: "2", leito: "L2", nome: "Paciente L2", diagnostico: "D2", conducta: "C2", deleting: ko.observable(false) });
        self.List.Items.push({ selected: false, id: "3", leito: "L3", nome: "Paciente L3", diagnostico: "D3", conducta: "C3", deleting: ko.observable(false) });
    };

    self.UI.Actions.changePage = function (data, evt) {

        var currentId = $(evt.currentTarget).data('id');
        var targetName = $(evt.currentTarget).data('name');
        console.log(currentId + " " + targetName);
        doctor_drive_globals.currentItemId = currentId;
        $(document).trigger('page-change', [targetName]);
    };

    self.Actions.tryAddItem = function (data, evt) {
        self.List.Items.push({ selected: false, id: "", leito: "", nome: "", diagnostico: "", conducta: "", deleting: ko.observable(false) });
    };

    self.Actions.initDeleteItem = function (data, evt) {
        data.deleting(data.selected);
        return true;
    };

    self.Actions.confirmDeleteItem = function (data, evt) {
        self.List.Items.remove(data);
    };
};

HomeViewModel.id = "home";