angular.module('ProductDemoApp').controller('ProductsPageController', ['$scope', 'ProductsService', function ($scope, ProductsService) {

    $scope.products;

    getAllProducts();

    $scope.test = {
        helloAngular: 'I work!'
    };

    function getAllProducts() {
        ProductsService.getProducts()
            .then(function (response) {
                $scope.products = response.data;
            }, function (error) {
                $log.error("Something went wrong while fetching the product data.")
            });
    }
}]);

