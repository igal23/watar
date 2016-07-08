'use strict';

(function () {
    var app = angular.module('defaultApp', ['ngRoute']);

    app.controller('PaxController', function ($scope, $http) {
        //initialize
        this.title = 'Información personal';

        $scope.url = '/api/Pax';
        $scope.registrationSuccess = false;
        $scope.pax = new Pax();
        $scope.ciudades = [new Item(0, 'Otro'),
            new Item(1, 'Buenos Aires'),
            new Item(2, 'La Plata')];
        $scope.universidades = [new Item(0, 'Otro'),
            new Item(1, 'UBA'),
            new Item(2, 'UTN')];

        $scope.registrar = function () {
            $http.post($scope.url + '/Register', $scope.pax)
		    .success(function (data) {
		        $scope.registrationSuccess = true;
		        $scope.pax = new Pax();
		    });
        }

        $scope.getPaxes = function () {
            $http.get($scope.url + '/GetAll')
		    .success(function (result) {
		        $scope.paxes = result.data;
		    });
        };
    });

    app.config(['$routeProvider', function ($routeProvider) {
        $routeProvider.
            when('/pax', {
                templateUrl: 'partials/pax.html',
                controller: 'PaxController'
            }).
            when('/paxes', {
                templateUrl: 'partials/paxList.html',
                controller: 'PaxController'
            }).
            otherwise({
                redirectTo: '/pax'
            });
    }]);
})();
