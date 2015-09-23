(function () {
    angular
        .module('MFTWeb')
        .controller('MFTFormController', function ($scope, $http, $location, currentUser, mftFormService) {
            var self = this;
            self.dropDowns = mftFormService.getDropDowns();
            //$scope.menuSelects = {};
            

            self.form = function () {
                self.dropDowns.forEach(function (dropDown) {
                    self.mftForm[dropDown.model] = self.mftForm[dropDown.model].name;
                });
                console.log(self.mftForm);
                return self.mftForm;
            };

            //this.AddFormEntry = mftFormService.newEntry(self.form());
        });
})();