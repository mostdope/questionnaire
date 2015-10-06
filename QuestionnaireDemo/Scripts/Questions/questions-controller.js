

root.controller("QuestionsController", function ($scope, questionsData) {
    $scope.questions = questionsData.questions;
});