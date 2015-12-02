var UnidadController = function ($rootScope, $scope, $state, $stateParams, $http, $modal) {

    $scope.parameters = {
        Nombre: "",
        UnidadPresentacion: "",
    }

    $scope.New = {
        ID_UnidadMedida: 0,
        UnidadPresentacion: "",
        Observacion: "",
        Codigo_UMedida: "",
        Cantidad: "",
        CantidaBase:"",
    }



    $scope.Loadddl = function () {
        $http({
            method: 'GET',
            url: 'api/UnidadMedidaWS',
        }).success(function (response) {
            $scope.dll_UnidadList = response;
        });
    }



   
    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/UMWS',
            params: {
                Nombre: $scope.parameters.Nombre == (null || '') ? "%" : $scope.parameters.Nombre,
                UnidadPresentacion: $scope.parameters.UnidadPresentacion == (null || '') ? "%" : $scope.parameters.UnidadPresentacion,
            }
        }).success(function (response) {
            $scope.UMList = response;

        });
    }

    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('UnidadCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');

        $state.go('UnidadList');

    }

    $scope.Loadddl();
    $scope.List();
 

    $scope.SaveNew = function () {

        $http({
            method: 'POST',
            url: 'api/UMWS',
            data: $scope.New,
        }).success(function (response) {

            $scope.New.ID_UnidadMedida = response;
            //getProducto($scope.New.ID_Producto);
            alert("Registro Correcto");
            $state.go('UnidadList');
        });

    }
    $scope.select = function (id) {
        $('#Id').val(id);
    }
    $scope.Edit = function () {
        $state.go('UnidadEdit');
    }

    $scope.Delete = function () {
        $http({
            method: 'Delete',
            url: 'api/ProductoWS',
            params: {
                ID_Producto: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });

    }

    if ($('#Id').val() != '0') {   //Editar
         
        return $http({
            method: 'GET',
            url: 'api/UnidadMedidaWS',
        }).success(function (response) {
            $scope.dll_UnidadList = response;

            $http({
                method: 'GET',
                url: 'api/UMWS',
                params: {
                    ID_UnidadMedida: $('#Id').val(),
                }
            }).success(function (response) {
                $scope.New = response;

            });
        });


    } else {                      //Crear

    }
    

}
UnidadController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http', '$modal'];