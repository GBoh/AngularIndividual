(function () {
    angular
        .module('MFTWeb')
        .controller('LoginController', ['$http', '$location', 'authService', function ($http, $location, authService) {
            var self = this;
            self.login = function () {
                try {
                    authService.login(self.username, self.password);
                } catch (err) {
                    console.log(err);
                }
            };
        }]);
})();