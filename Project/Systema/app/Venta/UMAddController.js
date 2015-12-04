var UMAddController = function ($rootScope, $scope, $modalInstance, $http, Codigo_UMedida, IdTemp, scope) {


    $scope.New = {
        Codigo_UMedida: Codigo_UMedida,
        IdTemp: IdTemp,
    }

    $scope.Item = {
        ID_UnidadMedida: 0,
        UnidadPresentacion: '',
        Cantidad: '',
        CantidaBase: ''
    }

    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/UMWS',
            params: {
                Codigo_UMedida: Codigo_UMedida,
                Ayuda: "0",
            }
        }).success(function (response) {
            $scope.UMList = response;
        });

    }


    $scope.Select = function (item) {
        $.each($scope.UMList, function (index, value) {
            if (value.ID_UnidadMedida != item.ID_UnidadMedida) {
                value.checked = false;
            } else {
                value.checked = true;
                $scope.Item.ID_UnidadMedida = item.ID_UnidadMedida;
                $scope.Item.CantidaBase = item.CantidaBase;
                $scope.Item.Cantidad = item.Cantidad;
            }
        });

    }




    $scope.ok = function () {

        modeAction();

    };

    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction() {

        if ($scope.Item.ID_UnidadMedida != 0) {

            $.each($scope.UMList, function (index, value) {
                if (value.checked == true) {

                    $http({
                        method: 'Delete',
                        url: 'api/TempWS',
                        params: {
                            IdTemp: IdTemp,
                            ID_UnidadMedida: $scope.Item.ID_UnidadMedida,
                            CB: $scope.Item.CantidaBase,
                            CP: $scope.Item.Cantidad,
                        }
                    }).success(function (response) {
                        scope.TemporalList()
                    });
                    value.checked = false;
                    //lista.push(value);
                }
            });
            $scope.cancel();


        } else {

            alert("No selecciono Item");
        }


       


    }

    $scope.List();
}

UMAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'Codigo_UMedida', 'IdTemp', 'scope'];