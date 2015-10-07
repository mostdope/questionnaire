(function() {
    

    var questionsServices = angular.module('questionsServices', ['ngResource']);

    questionsServices.factory('Questions', [
        '$resource',
        function($resource) {
            return $resource('/api/questions/', {}, {
                query: { method: 'GET', params: {}, isArray: true }
            });
        }
    ]);
});