
(function () {
    angular
        .module('MFTWeb')
        .controller('RegisterController', ['$location', 'accountService', function ($location, accountService) {
            var self = this;
            try {
                self.register = function () {
                    accountServices.register(self.newUser);
                };
            } catch (err) {
                console.log(err);
            }
        }]);
})();