(function () {
    'use strict';

    function config($routeProvider) {
        var PARTIAL_PREFIX = 'HTML/';

        $routeProvider
            .when('/', {
                templateUrl: PARTIAL_PREFIX + 'home/home.html',
                controller: 'HomeController',
                controllerAs: 'vm'
            })
            .otherwise({ redirectTo: '/' });
    }

    angular.module('CrmApp.services', []);
    angular.module('CrmApp.controllers', ['CrmApp.services']);
    angular.module('CrmApp', ['ngRoute', 'ngCookies', 'CrmApp.controllers']).
        config(['$routeProvider', config])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://localhost:51349/api');
}());
