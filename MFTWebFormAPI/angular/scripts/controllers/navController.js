(function () {
    angular
        .module('MFTWeb')
        .controller('NavController', function (authService) {
            var self = this;
            self.logout = function () {
                console.log('nav logout controller fired');
            }
        });
})();