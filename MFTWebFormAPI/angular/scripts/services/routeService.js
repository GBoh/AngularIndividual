'use strict';

(function () {
    angular
        .module('MFTWeb')
        .service('RouteService', ['$resource', 'routeUrls', function ($resource, routeUrls) {
            var MftApi = $resource(routeUrls.mftApi);
        }]);
})();