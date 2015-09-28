(function () {
    "use strict";
    var publisherService = angular.module('publisherService', ['ngResource']);
    publisherService.factory('PublisherService', ['$resource', 'appSettings',
      function ($resource, appSettings) {
          return $resource(appSettings.server + "api/Publishers/:id");
      }]);
}());