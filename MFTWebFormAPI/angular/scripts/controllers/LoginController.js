(function () {
    angular
        .module('MFTWeb')
        .controller('LoginController', ['$http', '$location', 'authService', function ($http, $location, authService) {
            var self = this;

            function success() {
                $location.path('/terms');
            };

            function fail() {

            };

            self.login = function () {
                try {
                    authService.login(/*self.username*/'new@user.com', /*self.password*/'123456')
                        .then(success, fail);


                } catch (err) {
                    console.log(err);
                }
            };
        }]);
})();