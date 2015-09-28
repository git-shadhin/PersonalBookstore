(function () {
    "use strict";
    var contributorService = angular.module('contributorService', ['ngResource']);
    contributorService.factory('ContributorService', ['$resource', 'appSettings',
      function ($resource, appSettings) {
          return $resource(appSettings.server + "api/Contributors/:id");
      }]);
}());