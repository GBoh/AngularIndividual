(function () {
    angular
        .module('MFTWeb')
        .service('termService', function ($http, $resource, routeUrls) {
            var self = this;
            var TermApi = $resource(routeUrls.termApi);

            this.getTerms = function () {
                return TermApi.query();
            };

            this.postTerm = function (term) {
                new TermApi(term).$save().then(function (data) {
                    return data;
                });
            };
        });
})();