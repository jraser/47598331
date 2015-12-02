var GrupoController = function ($rootScope, $scope, $state, $stateParams, $http, $modal) {

    $scope.parameters = {
        Nombre: "",
        TipoGrupo:"",
        Estado: "",
    }
    $scope.New = {
        ID_Grupo: 0,
        Nombre: "",
        Estado: "",
        ID_TipoDescuento:"",
        ID_Descuento:"",
    }

    $scope.msj = function () {
        alert();
    }

    $scope.Create = function () {
        $('#Id').val('0');
        $state.go('GrupoCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $state.go('GrupoList');
    }



    $scope.List = function () {
        $http({
            method: 'GET',
            url: 'api/GrupoWS',
            params: {
                Nombre: $scope.parameters.Nombre == (null || '') ? "%" : $scope.parameters.Nombre,
                TipoGrupo: $scope.parameters.TipoGrupo == (null || '') ? "%" : $scope.parameters.TipoGrupo,
                Estado: $scope.parameters.Estado == (null || '') ? "%" : $scope.parameters.Estado,
            }
        }).success(function (response) {
            $scope.GrupoList = response;
        });
    }

    $scope.Select = function (item) {
        $.each($scope.DescuentoGrupoList, function (index, value) {
            if (value.ID_Descuento != item.ID_Descuento) {
                value.checked = false;
            } else {
                value.checked = true;

                $http({
                    method: 'Delete',
                    url: 'api/DescuentoGrupoWS',
                    params: {
                        ID_Descuento: item.ID_Descuento,
                        ID_Grupo: $scope.New.ID_Grupo
                    }
                }).success(function (response) {
                    $scope.ListarDescuentos();
                });
            }
        });

    }


    //$scope.ActivarDescuento = function () {
    //    $http({
    //        method: 'POST',
    //        url: 'api/GrupoWS',
    //        data: $scope.New,
    //    }).success(function (response) {
    //        $scope.New.ID_Grupo = response;
    //        alert("Registro Correcto");
    //        //var Id = response;

    //        //if (Id != 0) {
    //        //    for (var i = 0; i < $scope.DescuentoList.length; i++) {
    //        //        var item = $scope.DescuentoList[i];
    //        //        item.ID_Grupo = Id;
    //        //        if (item.checked) {
    //        //            $http({
    //        //                method: 'POST',
    //        //                url: 'api/DescuentoGrupoWS',
    //        //                data: item,
    //        //            }).success(function (response) {

    //        //            });
    //        //        }
    //        //    }
    //        //    alert("Registro Correcto");
    //        //    $state.go('GrupoList');
    //        //}
    //    });




    //}


    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/GrupoWS',
            data: $scope.New,
        }).success(function (response) {
            $scope.New.ID_Grupo = response;
            alert("Registro Correcto");
            //var Id = response;
            
            //if (Id != 0) {
            //    for (var i = 0; i < $scope.DescuentoList.length; i++) {
            //        var item = $scope.DescuentoList[i];
            //        item.ID_Grupo = Id;
            //        if (item.checked) {
            //            $http({
            //                method: 'POST',
            //                url: 'api/DescuentoGrupoWS',
            //                data: item,
            //            }).success(function (response) {

            //            });
            //        }
            //    }
            //    alert("Registro Correcto");
            //    $state.go('GrupoList');
            //}
        });




    }

    $scope.Delete = function () {

        $http({
            method: 'Delete',
            url: 'api/GrupoWS',
            params: {
                ID_Grupo: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();

            alert("Registro Eliminado");

        }).catch(function (err) {
            alert("Este grupo contiene Registros", err);
            throw err;
        }).finally(function () {
            alert("");
        });

    }

    //function getDescuentos(Id) {
    //    $http({
    //        method: 'GET',
    //        url: 'api/DescuentoProductoWS',
    //        params: {
    //            ID_Grupo: Id,
    //            Mode:'1'
    //        }
    //    }).success(function (response) {
    //        $scope.DescuentoList = response;

    //        for (var i = 0; i < $scope.DescuentoList.length; i++) {
    //            var item = $scope.DescuentoList[i];
    //            if (item.ID_Grupo != 0) {
    //                item.checked = true;
    //            } else {
    //                item.checked = false;
    //            }
    //        }

    //    });

    //}

    $scope.Edit = function () {
       
        $state.go('GrupoEdit');
    }






    $scope.EstadoModificado = function () {
        $http({
            method: 'POST',
            url: 'api/GrupoWS',
            params: {
                ID_Grupo: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });
        alert("Estado Modificado a Desactivado");
    }


    $scope.PUT = function () {
        $http({
            method: 'PUT',
            url: 'api/GrupoWS',
            params: {
                ID_Grupo: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.List();
        });
        alert("Estado Modificado a Aceptado")
    }


    $scope.List();

    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/GruposWS',
            params: {
                ID_Grupo: $('#Id').val(),
            }
        }).success(function (response) {
            $scope.New = response;
            $scope.ListarDescuentos();
            //getDescuentos($('#Id').val());
        });



    } else {                      //Crear
        //getDescuentos(0);
    }

    $scope.select = function (id) {
        $('#Id').val(id);


    }

    function Loadddl() {
        $http({
            method: 'GET',
            url: 'api/ConceptoWS',
            params: {
                CodigoTabla: '004',

            }
        }).success(function (response) {
            $scope.MonedaList = response;
            $http({
                method: 'GET',
                url: 'api/ConceptoWS',
                params: {
                    CodigoTabla: '015',

                }
            }).success(function (response) {
                $scope.FormaList = response;

                $http({
                    method: 'GET',
                    url: 'api/ConceptoWS',
                    params: {
                        CodigoTabla: '015',

                    }
                }).success(function (response) {
                    $scope.CondicionList = response;

                });
            });
        });

    }



    $scope.addItem = function () {

        if ($scope.New.ID_Grupo != 0) {

            var modalInstance = $modal.open({
                templateUrl: '/Descuento/AddDescuento',
                controller: 'DescuentoAddController',

                resolve: {
                    ID_Grupo: function () {
                        return $scope.New.ID_Grupo;
                    },
                    scope: function () {
                        return $scope;
                    }

                }
            });

        } else {

            alert("Ingrese Grupo");
        }
    }

    $scope.ListarDescuentos = function () {

        $http({
            method: 'GET',
            url: 'api/DescuentoGrupoWS',
            params: {
                ID_Grupo: $scope.New.ID_Grupo,
            }
        }).success(function (response) {
            $scope.DescuentoGrupoList = response;
            
            for (var i = 0; i < $scope.DescuentoGrupoList.length; i++) {
                var item = $scope.DescuentoGrupoList[i];
                if (item.Estado != 'I') {
                    item.checked = true;
                } else {
                    item.checked = false;
                }
            }
        });
    }

    Loadddl();

}
GrupoController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http', '$modal'];
