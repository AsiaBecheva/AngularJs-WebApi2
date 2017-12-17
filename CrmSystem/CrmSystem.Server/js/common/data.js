(function () {
    'use strict';

    function data($http, $q, notifier, baseServiceUrl) {

        function get(url, queryParams) {
            var deferred = $q.defer();

            $http.get(baseServiceUrl + '/' + url, { params: queryParams })
                .then(function (responce) {
                    deferred.resolve(responce.data);
                }, function (error) {
                    notifier.error(error);
                    deferred.reject(error);
                });

            return deferred.promise;
        }

        function post(url, postData) {

            var deferred = $q.defer();
            $http.post(baseServiceUrl + '/' + url, postData)
                .then(function (responce) {
                    deferred.resolve(responce.data);
                }, function (error) {
                    notifier.error(error);
                    deferred.reject(error);
                });

            deferred.promise;
        }

        function deleteItem(url, id) {
            var deferred = $q.defer();
            $http.delete(baseServiceUrl + '/' + url, { params: id })
                .then(function (responce) {
                    deferred.resolve(responce.data);
                }, function (error) {
                    notifier.error(error);
                    deferred.reject(error);
                });

            deferred.promise;
        }

        return {
            get: get,
            post: post,
            delete: deleteItem
        };
    }

    angular.module('CrmApp.services')
        .factory('data', ['$http', '$q', 'notifier', 'baseServiceUrl', data]);
}());