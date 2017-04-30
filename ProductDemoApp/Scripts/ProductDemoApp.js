var ProductDemoApp = angular.module('ProductDemoApp', ['ngRoute']);

ProductDemoApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/', {
            controller: 'ProductsController',
            templateUrl: 'Products'
        })
        .otherwise({ redirectTo: '/' })
}])
