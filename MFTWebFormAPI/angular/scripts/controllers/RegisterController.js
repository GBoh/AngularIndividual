
(function () {
    angular
        .module('MFTWeb')
        .controller('RegisterController', ['$location', 'accountService', function ($location, accountService) {
            var self = this;
            try {
                self.register = function () {
                    accountService.register(self.newUser);
                    $location.path('login/');

                };
            } catch (err) {
                console.log(err);
            }
        }]);
})();