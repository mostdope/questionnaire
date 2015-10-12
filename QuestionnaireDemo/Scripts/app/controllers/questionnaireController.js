appMain.controller('questionnaireController', function($scope,  $http) {
    var uri = 'http://localhost:58252/api/questionnaire/';
    $http({
        method: 'GET',
        url: uri
    }).then(function(response) {
        $scope.questionnaires = response.data;
    }, function(response) {
        $scope.data = response.data || "Request failed";
        $scope.status = response.status;
    });

    $scope.calcStats = function () {
        
    };
    $scope.pageheader = "There are few questionnaires";
});