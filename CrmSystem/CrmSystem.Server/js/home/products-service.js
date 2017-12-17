(function () {
    'use strict';

    function products(data) {
        function getProducts() {
            return data.get('home');
        };

        return {
            getProducts: getProducts
        };
    };

    angular.module('CrmApp.services')
        .factory('products', ['data', products]);
}());