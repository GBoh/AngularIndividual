(function () {
    angular
        .module('MFTWeb')
        .service('authService', function ($q, $http, $resource, $location, currentUser) {
            var self = this;

            self.login = function (username, password) {
                self.loginMessage = '';
                var data = 'grant_type=password&username=' + username + '&password=' + password;
                var defered = $q.defer();

                $http.post('/token', data, {
                    headers: {
                        'Content-Type': 'application/x-www-form-urlencoded'
                    }
                })
                .success(function (result) {
                    self.login = null;
                    self.accessToken = result.access_token;
                    currentUser.setUser(username, self.accessToken);

                    $http.defaults.headers.common.Authorization = 'Bearer ' + self.accessToken;

                    defered.resolve();
                })
                .error(function () {
                    self.loginMessage = 'Invalid username/password';
                    defered.reject();
                });
                return defered.promise;
            };
        });
})();