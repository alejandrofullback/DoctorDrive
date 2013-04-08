(function (window, document, undefined) {
    MainViewModel = function (screenId) {
        var self = this;
        
        self.Availablescreens = ["home", "patient", "patient-evolution", "patient-treatment", "patient-image", , "patient-image-editor"];
        self.screens = {};
        self.selectedScreen = ko.observable(null);
        self.selectedScreenId = ko.observable(null);
        self.moduleId = null;

        self.menu = new MenuViewModel();
        self.header = new HeaderViewModel();

        // CONTROLE DE TROCA DE PAGINAS
        self.selectedScreenId.subscribe(function (newValue) {

            // SE A SCREEN EXISTE NO MEU ARRAY DE SCREENS
            if ($.inArray(newValue, self.Availablescreens) != -1) {
                // TESTA SE A SCREEN NAO ESTA INSTANCIADA
                if (self.screens[newValue] == void (0)) {
                    if (newValue == "home") {
                        self.screens[newValue] = new HomeViewModel();
                    }
                    if (newValue == "patient") {
                        self.screens[newValue] = new PatientViewModel();
                    }
                    if (newValue == "patient-treatment") {
                        self.screens[newValue] = new PatientTreatmentViewModel();
                    }
                    if (newValue == "patient-image") {
                        self.screens[newValue] = new PatientImageViewModel();
                    }
                    if (newValue == "patient-image-editor") {
                        self.screens[newValue] = new PatientImageEditorViewModel();
                    }
                    if (newValue == "patient-laboratory") {
                        self.screens[newValue] = new PatientLaboratoryViewModel();
                    }
                    if (newValue == "patient-evolution") {
                        self.screens[newValue] = new PatientEvolutionViewModel();
                    }
                }
            }
            else {
                // SE A SCREEN NAO EXISTE LEVA PARA A HOME
                self.selectedScreenId("home");
                newValue = "home";

                if (self.screens[newValue] == void (0)) {
                    self.screens["home"] = new HomeViewModel();
                }
            }

            // INICIA A SCREEN
            self.moduleId = newValue;
            if (newValue === "home") {
                self.menu.UI.Actions.showMenu(false);
            }
            else
            {
                self.menu.UI.Actions.showMenu(true);
            }
            self.startModule(self.moduleId);

            self.selectedScreen(self.screens[newValue]);
        });

        self.startModule = function (moduleId) {
            self.screens[moduleId].Actions.startModule();
        };

        // INICIALIZACAO DA APP
        self.initApp = function (screenId) {
            // SE TEM SCREEN SELECIONADA
            if (screenId) {
                // CARREGA A SCREEN A PARTIR DA URL
                self.selectedScreenId(screenId);
            } else {
                // SE NAO TEM SCREEN ID VAMOS PARA A LISTA
                self.selectedScreenId('home');
            }
        };

        // CHAMADA PARA A INICIALIZACAO
        self.initApp(screenId);

        //CUSTOM EVENT HANDLERS
        $(document).on('page-change', function (e, data) {
            //console.log("evento de page change detectado");
            self.selectedScreenId(data);
        });
    };
}(this, document));

infuser.defaults.templateUrl = 'modules';
ko.applyBindings(new MainViewModel());
