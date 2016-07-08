'use strict';

(function () {
    var app = angular.module('defaultApp', ['ngRoute']);

    app.controller('PaxController', function ($scope, $http) {
        //initialize
        this.title = 'Información personal';
        $scope.registrationSuccess = false;
        $scope.pax = new Pax();
        $scope.ciudades = [new Item(0, 'Otro'),
            new Item(1, 'Buenos Aires'),
            new Item(2, 'La Plata')];
        $scope.universidades = [new Item(0, 'Otro'),
            new Item(1, 'UBA'),
            new Item(2, 'UTN')];
        
        $scope.registrar = function () {
            $scope.registrationSuccess = true;
        }
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
