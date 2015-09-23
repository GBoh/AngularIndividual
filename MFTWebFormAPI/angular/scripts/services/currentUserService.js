(function () {
    angular
        .module('MFTWeb')
        .factory('currentUser', function () {
            var self = this;
            var user = {
                username: '',
                token: '',
                isLoggedIn: function () {
                    return this.token;
                }
            };
            return {
                setUser: function(username, token) {
                    user.username = username;
                    user.token = token;
                },
                profile: user
            };
        });
})();