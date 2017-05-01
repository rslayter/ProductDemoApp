angular.module('ProductDemoApp').controller('ProductsPageController', ['$scope', 'ProductsService', function ($scope, ProductsService) {
    $scope.busy = false;
    $scope.index = 0;
    $scope.products = [];

    getNextProducts();

    function getNextProducts() {
        var products = $scope.products;
        var newProducts = [];
        if ($scope.busy) {
            return;
        }

        $scope.busy = true;
        ProductsService.getProducts($scope.index)
            .then(function (response) {
                newProducts = response.data;
                $scope.products = products.concat(newProducts);

                //$scope.products.concat(response.data);
                $scope.index = $scope.index + 12;
                $scope.busy = false;
            }, function (error) {
                console.log("Something went wrong while fetching the product data." + error)
                $scope.busy = false;
            });
    }

    $scope.loadProducts = function () {
        getNextProducts();
    };
}]);

