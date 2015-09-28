(function () {
    "use strict";
    var bookService = angular.module('bookService', ['ngResource']);
    bookService.factory('BookService', ['$resource', 'appSettings',
      function ($resource, appSettings) {
          return $resource(appSettings.server + "api/Books/:id");
      }]);
}());