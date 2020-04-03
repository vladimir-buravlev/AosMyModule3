angular.module('aosMyModule3')
    .factory('aosMyModule3.webApi', ['$resource', function ($resource) {
        return $resource('api/AosMyModule3');
}]);
