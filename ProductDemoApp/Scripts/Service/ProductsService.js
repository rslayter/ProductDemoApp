angular.module('ProductDemoApp').service("ProductsService", function ($http) {
    var urlBase = '/api/products';

    this.getProducts = function (i) {
        return $http.get(urlBase, {
            params: { index: i },
            headers: { 'Accept': "Application/Json" }
        });
    }

    this.getProduct = function (id) {
        return $http.get(urlBase + "/" + id);
    }
});