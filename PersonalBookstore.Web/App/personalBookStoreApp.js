(function () {
    "use strict";
    var app = angular.module('personalBookStoreApp', ['ngRoute', 'bookService']);
    app.constant("appSettings",
        {
            server: "http://localhost:37961/"
        }
    );
    app.config(['$routeProvider',
        function ($routeProvider) {
            $routeProvider.
              when('/Books', {
                  templateUrl: '/App/Partials/book-list.html',
                  controller: 'bookController as books'
              }).
              when('/Books/:bookId', {
                templateUrl: '/App/Partials/book-detail.html',
                controller: 'bookController as books'
              }).
              //when('/phones/:phoneId', {
              //    templateUrl: 'partials/phone-detail.html',
              //    controller: 'PhoneDetailCtrl'
              //}).
              otherwise({
                  redirectTo: '/Books'
              });
        }]);
}());