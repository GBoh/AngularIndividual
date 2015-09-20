(function () {
    angular
        .module('MFTWeb')
        .service('termService', ['$http', function ($http) {
            var termsList;
            var self = this;
            self.getTerms = function () {
                $http.get('/api/mft/terms')
                    .then(function (response) {
                        console.log(response.data);
                        //termsList = response.data;
                        return response.data;
                    }
                );

            };
        }]);
})();