var DetalleRequerimientosController = function ($rootScope, $scope, $modalInstance, $http, ID_Orden, ID_DetalleOrden, Codigo_Producto, Descripcion_Producto, PrecioUnitario, Cantidad, Descuento, Monto, ID_Socio, scope) {

    $scope.New = {
        ID_RequerimientoDetalle: ID_RequerimientoDetalle,
        ID_Requerimientos: ID_Requerimientos,
        Lot: Lote_Requermientos,
        ID_Producto: 0,
        CantidadRequisito: CantidadRequisito,
        CantidadxMe: CantidadxMe,
        ID_Almacen: ID_Almacen,
        ID_Sucursal: ID_Sucursal,
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

    $scope.ok = function () {

        $http({
            method: 'POST',
            url: 'api/DetalleRequerimientosWS',
            data: $scope.New,
        }).success(function (response) {

            $scope.New.ID_Requerimientos = response;
            //getProducto($scope.New.ID_Producto);
            alert("Registro Correcto");
            //$state.go('ProductoList');
        });

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
            url: 'api/DetalleRequerimientosWS',
            data: $scope.New,
        }).success(function (response) {
            scope.ListarDetalle();

            $modalInstance.dismiss('cancel');
        });


    }

    //if (ID_DetalleOrden != 0) {
    //    $http({
    //        method: 'Get',
    //        url: 'api/DetalleOrdenCompraWS',
    //        params: {
    //            ID_DetalleOrden: ID_DetalleOrden,
    //            ID_Orden: ID_Orden,
    //        }
    //    }).success(function (responsse) {
    //        $scope.New = responsse;
    //    });

    //}

    $scope.Calcular = function () {

        $scope.New.Monto = $scope.New.PrecioUnitario * $scope.New.Cantidad ;
        $scope.New.Total = $scope.New.Monto - ($scope.New.Monto * ($scope.New.Descuento / 100));




    }

    $scope.Calcular2 = function () {

        $scope.New.Monto = $scope.New.PrecioUnitario * $scope.New.Cantidad;
        $scope.New.Total = $scope.New.Monto - ($scope.New.Monto * ($scope.New.Descuento / 100));



    }
    $scope.PList();
}

DetalleRequerimientosController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'ID_Orden', 'ID_DetalleOrden', 'Codigo_Producto', 'Descripcion_Producto', 'PrecioUnitario', 'Cantidad', 'Descuento', 'Monto', 'ID_Socio', 'scope'];