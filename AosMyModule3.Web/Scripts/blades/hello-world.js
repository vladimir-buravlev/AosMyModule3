angular.module('aosMyModule3')
    .controller('aosMyModule3.helloWorldController', ['$scope', 'aosMyModule3.webApi', function ($scope, api) {
        var blade = $scope.blade;
        blade.title = 'AosMyModule3';

        blade.refresh = function () {
            api.get(function (data) {
                blade.title = 'aosMyModule3.blades.hello-world.title';
                blade.data = data.result;
                blade.isLoading = false;
            });
        };

        blade.refresh();
    }]);
