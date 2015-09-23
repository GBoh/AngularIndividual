(function () {
    angular
        .module('MFTWeb')
        .controller('NavController', function ($scope, authService, currentUser) {
            var self = this;
            

            this.loggedIn = function () {
                return currentUser.profile.isLoggedIn();
            };

            self.logout = function () {
                console.log('nav logout controller fired');
            }
        });
})();