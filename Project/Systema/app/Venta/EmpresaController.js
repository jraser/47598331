var EmpresaController = function ($rootScope, $scope, $state, $stateParams, $http) {



    $scope.msj = function () {
        alert();
    }


//-----------------------------

    $scope.List = function () {
        $http({
            method: 'GET',
            url: 'api/EmpresaWS',
           
        }).success(function (response) {
            $scope.dll_EmpresaList = response;
        });
    }

//----------------------------




    $scope.select2 = function (Id) {
        $scope.Id = Id;
    }
    


  

    $scope.List();


}
EmpresaController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http'];