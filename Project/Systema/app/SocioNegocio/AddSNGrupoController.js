var AddSNGrupoController = function ($rootScope, $scope, $modalInstance, $http, ID_Grupo, scope) {

    $scope.parameters = {
        Nombres: "",
        Nro_Documento: "",

    }
    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/SocioNegocioWS',
            params: {

                Nombres: $scope.parameters.Nombres == (null || '') ? "%" : $scope.parameters.Nombres,
                Nro_Documento: $scope.parameters.Nro_Documento == (null || '') ? "%" : $scope.parameters.Nro_Documento,
                TipoSocio: 'C'
            }
        }).success(function (response) {
            $scope.SocioNegocioList = response;

        });

    }




    $scope.New = {
        ID_Grupo: ID_Grupo,
        ID_Asociado: 0,

    }


    $scope.ok = function () {

        modeAction();

    };

    $scope.Cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction() {

        $.each($scope.SocioNegocioList, function (index, value) {
            if (value.checked == true) {

                var item = $scope.SocioNegocioList[index];
                item.ID_Grupo = ID_Grupo;
                $http({
                    method: 'POST',
                    url: 'api/GrupoDetalleWS',
                    data: item,
                }).success(function (response) {
                    scope.ListarDescuentos();
                });


                value.checked = false;
                //lista.push(value);
            }
        });
        $scope.Cancel();

    }

    $scope.List();

}
AddSNGrupoController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'ID_Grupo', 'scope'];



