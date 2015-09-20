(function () {
    angular
        .module('MFTWeb')
        .service('authService', function ($http, $resource, $location) {
            var self = this;

            self.login = function (username, password) {
                self.loginMessage = '';
                var data = 'grant_type=password&username=' + username + '&password=' + password;

                $http.post('/token', data, {
                    headers: {
                        'Content-Type': 'application/x-www-form-urlencoded'
                    }
                })
                .success(function (result) {
                    self.login = null;
                    self.accessToken = result.access_token;

                    $http.defaults.headers.common.Authorization = 'Bearer ' + self.accessToken;
                    $location.path('/terms');

                    //console.log(currentUser.setUser(username, self.accessToken));
                    //console.log(self.accessToken);
                    //console.log(result);
                    //$location.path('term/');
                    //keith's session login
                    //$window.sessionStorage.setItem("token", result.access_token);
                    //var t = $window.sessionStorage.getItem("token");
                })
                .error(function () {
                    self.loginMessage = 'Invalid username/password';
                });
            };
        });
})();