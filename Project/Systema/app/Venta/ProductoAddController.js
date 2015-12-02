var ProductoAddController = function ($rootScope, $scope, $modalInstance, $http, ID_TempDetalle, ID_Socio, scope) {


    $scope.parameters = {
        Descripcion: "",
    }

    $scope.New = {
        IdTemp: 0,
        ID_TempDetalle: ID_TempDetalle,
        ID_Socio: ID_Socio,
        ID_Producto: 0,
    }



    $scope.List = function () {


        $http({
            method: 'GET',
            url: 'api/ProductoWS',
            params: {
                Descripcion: $scope.parameters.Descripcion == (null || '') ? "%" : $scope.parameters.Descripcion,
                ID_Socio: scope.New.ID_Socio
            }
        }).success(function (response) {
            $scope.ProductoList = response;

            $.each($scope.ProductoList, function (index, value) {
                value.checked = false;

            });

        });



    }


    //$scope.temp = function () {

    //    if (ID_TempDetalle != 0) {
    //        var item = $scope.ProductoList[i];
    //        item.ID_TempDetalle = ID_TempDetalle;
    //        item.ID_Socio = ID_Socio;
    //        $http({
    //            method: 'POST',
    //            url: 'api/TempWS',
    //            data: item,
    //        }).success(function (response) {


    //        });

    //        }
    //        alert("Registro Correcto");
    //        $scope.Cancel();

    //}


    $scope.ok = function () {
        //var lista = [];
        $.each($scope.ProductoList, function (index, value) {
            if (value.checked == true) {

                var item = $scope.ProductoList[index];
                item.ID_TempDetalle = ID_TempDetalle;
                item.ID_Socio = ID_Socio;
                $http({
                    method: 'POST',
                    url: 'api/TempWS',
                    data: item,
                }).success(function (response) {
                    scope.TemporalList();
                });


                value.checked = false;
                //lista.push(value);
            }
        });
        $scope.Cancel();

    };





    //function modeAction() {
    //    if (lista.length > 0) {
    //        scope.cargartemp(lista);
    //        $modalInstance.dismiss('cancel');
    //    } else {

    //        alert("No selecciono Item");
    //    }

    //}




    $scope.Cancel = function () {

        $modalInstance.dismiss('cancel');

    };







    $scope.List();


}
ProductoAddController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'ID_TempDetalle', 'ID_Socio', 'scope'];

