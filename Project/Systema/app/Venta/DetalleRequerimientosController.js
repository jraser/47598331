var DetalleRequerimientosController = function ($rootScope, $scope, $modalInstance, $http, ID_Requerimientos, ID_RequerimientoDetalle, Codigo_Producto, Descripcion_Producto, CantidadRequisito, Fecha_venci, ID_Sucursal, ID_Almacen, scope) {

    $scope.New = {
        ID_RequerimientoDetalle: ID_RequerimientoDetalle,
        ID_Requerimientos: ID_Requerimientos,
        Codigo_Producto: Codigo_Producto,
        Descripcion_Producto: Descripcion_Producto,
        Fecha_venci: Fecha_venci,
        ID_Almacen: ID_Almacen,
        ID_Sucursal: ID_Sucursal,
        CantidadRequisito: CantidadRequisito,
        ID_Producto: '',
        
        
    }

    $scope.PList = function () {
        $http({
            method: 'GET',
            url: 'api/AlmacenWS',
            params: {
                Descripcion_Producto: "%",
                ID_Almacen:"%",
                ID_Sucursal: "%",
            }
        }).success(function (response) {
            $scope.ProductoXalmacen = response;

            $.each($scope.ProductoXalmacen, function (index, value) {
                value.checked = false;

            });
        });
    }

    //$scope.ok = function () {

    //    $http({
    //        method: 'POST',
    //        url: 'api/DetalleRequerimientosWS',
    //        data: $scope.New,
    //    }).success(function (response) {
    //        $scope.New.ID_Requerimientos = response;
    //        //getProducto($scope.New.ID_Producto);
    //        alert("Registro Correcto");
    //        //$state.go('ProductoList');
    //    });

    //}



    $scope.ok = function () {
        modeAction();

    };

    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction() {

        $http({
            method: 'Post',
            url: 'api/DetalleRequerimientosWS',
            data: $scope.New,
        }).success(function (response) {
            scope.ListarDetalle();

            $modalInstance.dismiss('cancel');
        });


    }

  
    $scope.PList();
}

DetalleRequerimientosController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'ID_Requerimientos', 'ID_RequerimientoDetalle', 'Codigo_Producto', 'Descripcion_Producto', 'CantidadRequisito','Fecha_venci','ID_Sucursal', 'ID_Almacen','scope'];