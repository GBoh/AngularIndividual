(function () {
    angular
        .module('MFTWeb')
        .service('mftFormService', function ($http, $resource, routeUrls) {
            var MFTFormApi = $resource(routeUrls.mftFormApi);
            var self = this;
            var dropdowns;

            this.getDropDowns = function () {
                return MFTFormApi.query();
                //dropdowns = data;
                //return dropdowns
            };

            this.newEntry = function (form) {
                new MFTFormApi(form).$save()
                    .then(function (data) {
                        return data;
                    })
            }
        });
})();