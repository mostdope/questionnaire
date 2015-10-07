(function () {

    angular
        .module('questionsApp')
        .controller('questionsController', questionsController);

    questionsController.$inject = ['$scope', 'Questions'];

    function questionsController($scope, Questions) {
        $scope.questions = Questions.query();
    }
});