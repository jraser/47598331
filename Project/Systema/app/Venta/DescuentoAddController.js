var DescuentoAddController = function ($rootScope, $scope, $modalInstance, $http, ID_Grupo, scope) {

    $scope.New = {
        ID_Grupo: ID_Grupo,
        ID_Descuento: 0,
        DescuentoPor: '',
        Descripcion: '',

    }



    
    $scope.ok = function () {

        modeAction();

    };

    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction() {

        $http({
            method: 'Post',
            url: 'api/DescuentoGrupoWS',
            data: $scope.New,
        }).success(function (response) {
            scope.ListarDescuentos();

            $modalInstance.dismiss('cancel');
        });
    }


}
DescuentoAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http','ID_Grupo', 'scope'];



