var ProductDemoApp = angular.module('ProductDemoApp', ['ngRoute', 'infinite-scroll']);

ProductDemoApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider
        .when('/', {
            controller: 'ProductsController',
            templateUrl: 'Products'
        })
        .when('/Products/Products', {
            templageUrl: 'Products'
        })
        .otherwise({ redirectTo: '/' })

    $locationProvider.html5Mode(true);
}])
