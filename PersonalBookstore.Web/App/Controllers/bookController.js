(function () {
    "use strict";
    angular.module('personalBookStoreApp').controller('bookController', ['BookService', function (BookService) {
        var books = this;
        books.records = BookService.query();        
    }])
}());