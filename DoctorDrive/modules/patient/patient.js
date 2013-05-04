PatientViewModel = function () {
    var self = this;
    self.template = "patient/html/patient";
    self.patient = {};
    self.patient.bed = ko.observable();
    self.patient.name = ko.observable();
    self.patient.prontuary = ko.observable();
    self.patient.birthday = ko.observable();
    self.patient.weight = ko.observable();
    self.patient.isfemale = ko.observable();
    self.patient.arrivaldate = ko.observable();
    self.patient.initialdiagnostic = ko.observable();
    //self.patient.comorbities = [];
    //self.patient.alergies = ko.observable();
    //self.patient.recentlyinterned = ko.observable();
    self.patient.contactname = ko.observable();
    self.patient.doctor = {};
    self.patient.doctor.name = ko.observable();
    self.patient.doctor.phone = ko.observable();

    self.Actions = {};
    self.UI = {};
    self.UI.Actions = {};

    self.Actions.startModule = function () {
        var patientId = doctor_drive_globals.currentItemId;
        if (patientId)
            self.Actions.tryLoadPatientDetails();
    };

    self.Actions.tryLoadPatientDetails = function (patientId) {
        self.Actions.onPatientDetailsLoaded();
    };

    self.Actions.onPatientDetailsLoaded = function (data) {

    };

    self.Actions.tryUpdatePatientDetails = function (patientId) {
        self.Actions.onPatientDetailsLoaded();
    };

    self.Actions.onPatientDetailsUpdated = function (data) {

    };

    self.Actions.trySavePatientDetails = function (data) {
        var patientData = ko.toJSON(self.patient);
        $.ajax({
            type: "POST",
            url: "http://doctor.eptecno.com/api/patients",
            data: patientData,
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        });
    };
};

PatientViewModel.id = "patient";
