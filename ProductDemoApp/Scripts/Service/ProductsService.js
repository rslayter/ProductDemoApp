angular.module('ProductDemoApp').service("ProductsService", function ($http) {
    var urlBase = '/api/products';

    this.getProducts = function () {
        return $http.get(urlBase);
    }

    this.getProduct = function (id) {
        return $http.get(urlBase + "/" + id);
    }
});