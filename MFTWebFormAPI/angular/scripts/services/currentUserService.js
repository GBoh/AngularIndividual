(function () {
    angular
        .module('MFTWeb')
        .factory('currentUser', function () {
            var self = this;
            return {
                setUser: function (username, token) {
                    var profil
                }
            };
            this.setUser = function (username, token) {

                var profile = {
                    username: '',
                    token: '',
                    get loggedIn() {
                        return this.token;
                    }
                };

                var setProfile = function () {
                    profile.username = username;
                    profile.token = token;
                };

                return {
                    setProfile: setProfile,
                    profile: profile
                };
            };
        });
})();