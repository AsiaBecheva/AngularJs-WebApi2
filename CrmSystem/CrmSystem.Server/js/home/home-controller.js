(function () {
    'use strict';

    function HomeControllers(products) {
        var vm = this;

        products.getProducts()
            .then(function (products) {
                vm.products = products;
            });
    }


    angular.module('CrmApp.controllers')
        .controller('HomeController', ['products', HomeControllers]);
}());