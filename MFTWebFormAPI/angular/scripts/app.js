'use strict';

(function () {
    angular
        .module('MFTWeb', ['ngRoute', 'ngResource'])
        .config(function ($routeProvider) {
            $routeProvider
            .when('/', {
                templateUrl: '/angular/views/home.html',
                controller: 'HomeController',
                controllerAs: 'main'
            })
            .when('/home', {
                templateUrl: '/angular/views/home.html',
                controller: 'HomeController',
                controllerAs: 'main'
            })
            .when('/login', {
                templateUrl: '/angular/views/login.html',
                controller: 'LoginController',
                controllerAs: 'main'
            })
             .when('/register', {
                 templateUrl: '/angular/views/register.html',
                 controller: 'RegisterController',
                 controllerAs: 'main'
             })
            .when('/terms', {
                templateUrl: '/angular/views/terms.html',
                controller: 'TermController',
                controllerAs: 'main'
            })
            .when('/newMft', {
                templateUrl: '/angular/views/mftForm.html',
                controller: 'MFTFormController',
                controllerAs: 'main'
            })
            .otherwise({
                templateUrl: '/angular/views/notFound.html'
            });
        });
})();