'use strict';

(function () {
    var app = angular.module('defaultApp', ['ngRoute']);

    app.controller('PaxController', function ($scope, $http) {
        this.title = 'Registration';
        $http.get('/GetProducts');
    });

    app.config(['$routeProvider', function ($routeProvider) {
        $routeProvider.
            when('/pax', {
                templateUrl: 'partials/pax.html',
                controller: 'PaxController'
            }).
            otherwise({
                redirectTo: '/pax'
            });
    }]);
})();
