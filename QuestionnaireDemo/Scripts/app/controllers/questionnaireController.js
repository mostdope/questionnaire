appMain.controller('questionnaireController', function ($scope, $http) {

    var uri = '/api/questionnaire/';

    $http({
        method: 'GET',
        url: uri
    })
        .then(function (response) {
        $scope.questionnaires = response.data;
    }, function (response) {

        $scope.data = response.data || "Request failed";
    });

    $scope.calcStats = function () {


        $http.post(uri, $scope.questionnaires[0]).then(function(response) {
            
        }, function (response) {
            
            
        });
    };
    $scope.pageheader = "There are few questionnaires";
});