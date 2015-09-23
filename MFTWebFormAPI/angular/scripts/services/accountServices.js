(function () {
    angular
          .module('MFTWeb')
          .service('accountService', function ($http) {

              this.register = function (user) {
                  $http.post('/api/Account/Register', user)
                      .then(function () {
                          
                      })
                      .catch(function (result) {
                          return result;
                      });
              }
          });
})();
