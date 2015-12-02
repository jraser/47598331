var DetalleOCController = function ($rootScope, $scope, $modalInstance, $http, ID_Orden, ID_DetalleOrden, Codigo_Producto, Descripcion_Producto, PrecioUnitario, Cantidad, Monto, ID_Socio, scope) {


    $scope.New = {
        ID_DetalleOrden: ID_DetalleOrden,
        ID_Orden: ID_Orden,
        Codigo_Producto: Codigo_Producto,
        Descripcion_Producto: Descripcion_Producto,
        PrecioUnitario: PrecioUnitario,
        Cantidad: Cantidad,
        Monto: Monto,
        ID_Socio: ID_Socio,
        ID_Producto: '',
    }

    $scope.List = function () {


        $http({
            method: 'GET',
            url: 'api/ProductoWS',
            params: {
                Descripcion: "%",
                ID_Socio: ID_Socio
            }
        }).success(function (response) {
            $scope.ProductoList = response;

        });

    }

    $scope.ok = function () {

        $http({
            method: 'POST',
            url: 'api/DetalleOrdenCompraWS',
            data: $scope.New,
        }).success(function (response) {

            $scope.New.ID_Orden = response;
            //getProducto($scope.New.ID_Producto);
            alert("Registro Correcto");
            //$state.go('ProductoList');
        });

    }

    $scope.PrecioU = function (Id) {


        $http({
            method: 'GET',
            url: 'api/ProductoWS',
            params: {
                ID_Producto: Id,
                num: 0 
            }
        }).success(function (response) {
            $scope.ProductoGet = response;
            $scope.ayudatemp();

        });

    }

    $scope.ayudatemp = function () {
        var lista = [];
        $.each($scope.ProductoGet, function (index, value) {
            lista.push(value);
        });
        cargartemp(lista);

    };


    function cargartemp(lista) {
        $scope.ProductoGet = lista;
        $.each($scope.ProductoGet, function (index, value) {
            $scope.New.PrecioUnitario = value.PrecioUnitario;
            $scope.New.Cantidad = "1";
            $scope.New.Monto = $scope.New.PrecioUnitario * $scope.New.Cantidad;
        });

        $scope.Calcular();
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
            url: 'api/DetalleOrdenCompraWS',
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

        $scope.New.Monto = $scope.New.PrecioUnitario * $scope.New.Cantidad;





    }

    $scope.Calcular2 = function () {

        $scope.New.Monto = $scope.New.PrecioUnitario * $scope.New.Cantidad;





    }
    $scope.List();
}

DetalleOCController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'ID_Orden', 'ID_DetalleOrden', 'Codigo_Producto', 'Descripcion_Producto', 'PrecioUnitario', 'Cantidad', 'Monto', 'ID_Socio', 'scope'];