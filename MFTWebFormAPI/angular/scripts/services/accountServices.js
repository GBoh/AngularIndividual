'use strict';
(function () {
    angular
          .module('MFTWeb')
          .service('accountService', function ($http, $location) {

              this.register = function (user) {
                  $http.post('/api/Account/Register', user)
                      .then(function () {
                          //redirects to login on success
                          setTimeout(function () {
                              $location.path('login/');
                          }, 1000);
                      })
                      .catch(function (result) {
                          return result;
                      });
              }
          });
})();
