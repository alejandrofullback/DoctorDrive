(function (window, document, undefined) {
    MainViewModel = function () {
        var self = this;
        self.selectedScreen = ko.observable(null);
        self.selectedScreenId = ko.observable(null);
        
    };
}(this, document));

ko.applyBindings(MainViewModel());
