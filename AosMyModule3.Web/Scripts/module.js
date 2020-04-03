// Call this to register your module to main application
var moduleName = "aosMyModule3";

if (AppDependencies !== undefined) {
    AppDependencies.push(moduleName);
}

angular.module(moduleName, [])
    .config(['$stateProvider', '$urlRouterProvider',
        function ($stateProvider, $urlRouterProvider) {
            $stateProvider
                .state('workspace.aosMyModule3State', {
                    url: '/aosMyModule3',
                    templateUrl: '$(Platform)/Scripts/common/templates/home.tpl.html',
                    controller: [
                        '$scope', 'platformWebApp.bladeNavigationService', function ($scope, bladeNavigationService) {
                            var newBlade = {
                                id: 'blade1',
                                controller: 'aosMyModule3.helloWorldController',
                                template: 'Modules/$(aosMyModule3)/Scripts/blades/hello-world.html',
                                isClosingDisabled: true
                            };
                            bladeNavigationService.showBlade(newBlade);
                        }
                    ]
                });
        }
    ])
    .run(['$rootScope', 'platformWebApp.mainMenuService', 'platformWebApp.widgetService', '$state',
        function ($rootScope, mainMenuService, widgetService, $state) {
            //Register module in main menu
            var menuItem = {
                path: 'browse/aosMyModule3',
                icon: 'fa fa-cube',
                title: 'AosMyModule3',
                priority: 100,
                action: function () { $state.go('workspace.aosMyModule3State'); },
                permission: 'aosMyModule3:read'
            };
            mainMenuService.addMenuItem(menuItem);
        }
    ]);
