﻿var ProductDemoApp = angular.module('ProductDemoApp', ['ngRoute', 'ui.bootstrap', 'bootstrapLightbox', 'infinite-scroll']);

ProductDemoApp.config(['$routeProvider', '$locationProvider', 'LightboxProvider', function ($routeProvider, $locationProvider, LightboxProvider) {
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

    LightboxProvider.getImageUrl = function (product) {
        return product.Image;
    }

    LightboxProvider.getImageCaption = function (product) {
        return product.Name;
    }

    LightboxProvider.fullScreenMode = true;

}])
