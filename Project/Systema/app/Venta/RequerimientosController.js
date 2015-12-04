var RequerimientosController = function ($rootScope, $scope, $state, $stateParams, $http, $modal) {
    $scope.parameters = {
        Descripcion_Sucursal: "",
        Descripcion_Almacen: "",
        FechaInI: "",
        FechaFin: "",
        Estado: "",
    }


    $scope.Xparameters = {
        Descripcion_Producto: "",
        ID_Almacen: "",
        ID_Sucursal: "",
    }

    $scope.New = {
        ID_Requerimientos: 0,
        Numero_Req: '',
        Motivo: "",
        ID_Almacen: '',
        ID_Sucursal: '',
        FechaContabilidad: new Date(),
        FechaEmision: new Date(),
        FechaEntrega: new Date(),
        Lista: [],
        Estado: "",
        CantidadRequisito: 0,
        Lot: "",
        Codigo_Producto: 0,
        Descripcion_Producto: '',
        Fecha_venci: "",
        Cantida: '',
    }


    $scope.New2 = {
        ID_Requerimientos: 0,
        CantidadRequisito: '',
        ID_Producto: '',
        Lot: "",
        ID_Almacen: '',
        ID_Sucursal:'',
    }


    $scope.Edit = function () {
        $state.go('RequerimientosModific');

    }



    $scope.select = function (id) {
        $('#Id').val(id);


    }


    $scope.dateOptions = {
        formatYear: 'yy',
        startingDay: 1,
        showWeeks: false
    };

    $scope.open = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();

        $scope.opened = true;


    };

    $scope.open1 = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();

        $scope.opened1 = true;


    };

    $scope.open2 = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();

        $scope.opened2 = true;


    };


    //-------------------------------------FILTRO DE BUSQUEDA  DE INICIO------------------------------------------

    $scope.List = function () {
        $http({
            method: 'GET',
            url: 'api/RequerimientosWS',
            params: {
                Descripcion_Sucursal: $scope.parameters.Descripcion_Sucursal == (null || '') ? "%" : $scope.parameters.Descripcion_Sucursal,
                Descripcion_Almacen: $scope.parameters.Descripcion_Almacen == (null || '') ? "%" : $scope.parameters.Descripcion_Almacen,
                FechaInI: $scope.parameters.FechaInI == (null || '') ? "01/01/1900" : $scope.parameters.FechaInI,
                FechaFin: $scope.parameters.FechaFin == (null || '') ? "01/01/2200" : $scope.parameters.FechaFin,
                Estado: $scope.parameters.Estado == (null || '') ? "P" : $scope.parameters.Estado,
            }
        }).success(function (response) {
            $scope.RequerimientosList = response;
        });
    }

    //-------------------------------------FILTRO DE BUSQUEDA PRODUCTOS * ALMACEN  PARA EL REGISTRO------------------------------------------

    $scope.PList = function () {
        $http({
            method: 'GET',
            url: 'api/AlmacenWS',
            params: {
                Descripcion_Producto: $scope.Xparameters.Descripcion_Producto == (null || '') ? "%" : $scope.Xparameters.Descripcion_Producto,
                ID_Almacen: $scope.Xparameters.ID_Almacen == (null || '') ? "01/01/1900" : $scope.Xparameters.ID_Almacen,
                ID_Sucursal: $scope.Xparameters.ID_Sucursal == (null || '') ? "01/01/2200" : $scope.Xparameters.ID_Sucursal,
            }
        }).success(function (response) {
            $scope.ProductoXalmacen = response;

            $.each($scope.ProductoXalmacen, function (index, value) {
                value.checked = false;

            });
        });
    }

    //-------------------------------------FCARGA DE DATOS PARA EL REGISTRO DEL DETALLE------------------------------------------


    $scope.Lok = function () {
        var lista = [];
        $.each($scope.ProductoXalmacen, function (index, value) {
            if (value.checked == true) {
                value.checked = false;
                lista.push(value);
            }
        });
        modeAction(lista);

    };

    function modeAction(lista) {
        if (lista.length > 0) {
            $scope.getdetalle(lista);
            $modalInstance.dismiss('cancel');
        } else {

            alert("No selecciono Item");
        }

    }

    $scope.getdetalle = function (lista) {
        $scope.ProductoList = lista;
        $.each($scope.ProductoList, function (index, value) {
            value.CantidadRequisito = 0;
        });
    }


    //-------------------------------------------------------------------------------------------


    $scope.select = function (id) {
        $('#Id').val(id);
    }

    //------------------------------------SELECCION DE SUCURSAL * ALMACEN------------------------------------------

    $scope.ListSuc = function () {

        $http({
            method: 'GET',
            url: 'api/SucursalWS',
        }).success(function (response) {
            $scope.SucursalList = response;
        });

    }

    $scope.SelectSuc = function () {
        $http({
            method: 'GET',
            url: 'api/AlmacenWS',
            params: {
                ID_Sucursal: $scope.Xparameters.ID_Sucursal == (null || 0) ? "%" : $scope.Xparameters.ID_Sucursal,
            }
        }).success(function (response) {
            $scope.A2lmacenList2 = response;
        });
    }

    $scope.RSelectSuc = function () {
        $http({
            method: 'GET',
            url: 'api/AlmacenWS',
            params: {
                ID_Sucursal: $scope.New.ID_Sucursal == (null || 0) ? "%" : $scope.New.ID_Sucursal,
            }
        }).success(function (response) {
            $scope.A1lmacenList2 = response;
        });
    }

    //-------------------------------------LISTADO DEL DETALLE DE LOS REQUERIMIENTOS------------------------------------------
    $scope.ListarDetalle = function () {
        $http({
            method: 'GET',
            url: 'api/DetalleRequerimientosWS',
            params: {
                ID_Requerimientos: $scope.New.ID_Requerimientos,
            }
        }).success(function (response) {
            $scope.DetalleRequerimientoList = response;
        });
    }
    //------------------------------------


    $scope.AList = function () {
        $http({
            method: 'GET',
            url: 'api/AlmacenWS',
            params: {
                Descripcion_Almacen: '%',

            }
        }).success(function (response) {
            $scope.AlmacenList = response;
        });
    }

    $scope.Create = function () {
        $('#Id').val('0');
        $('#Action').val('Create');
        $state.go('RequerimientosCreate');
    }

    $scope.Cancel = function () {
        $('#Id').val('0');
        $('#Action').val('List');
        $state.go('RequerimientoList');

    }

    //-------------------------------------GRABACION DEL REQUERIMIENTO------------------------------------------

    $scope.SaveNew2 = function () {
        $http({
            method: 'POST',
            url: 'api/RequerimientosWS',
            data: $scope.New,
        }).success(function (response) {
            $scope.New.ID_Requerimientos = response;
            alert("Registro Modificado");
            $scope.Cancel();

        });

    }


    $scope.SaveNew = function () {
        $http({
            method: 'POST',
            url: 'api/RequerimientosWS',
            data: $scope.New,
        }).success(function (response) {
            var Id = response;

            if (Id != 0) {
                for (var i = 0; i < $scope.ProductoList.length; i++) {
                    var item = $scope.ProductoList[i];
                    item.ID_Requerimientos = Id;

                    $http({
                        method: 'POST',
                        url: 'api/DetalleRequerimientosWS',
                        data: item,
                    }).success(function (response) {

                    });

                }

            }
            alert("Registro Correcto");
            $scope.Cancel();
        });
    }







    $scope.ActualizarOden = function () {
        $http({
            method: 'Delete',
            url: 'api/OrdenVentaWS',
            params: {
                ID_Orden: $scope.New.ID_Orden,
            }
        }).success(function (response) {

        });

    }

    //$scope.SaveNew = function () {
    //    $http({
    //        method: 'POST',
    //        url: 'api/RequerimientosWS',
    //        data: $scope.New,
    //    }).success(function (response) {
    //        var Id = response;

    //        if (Id != 0) {
    //            for (var i = 0; i < $scope.DetalleOrdenVentaList.length; i++) {
    //                var item = $scope.DetalleOrdenVentaList[i];
    //                item.ID_Requerimientos = Id;

    //                $http({
    //                    method: 'POST',
    //                    url: 'api/DetalleRequerimientosWS',
    //                    data: item,
    //                }).success(function (response) {

    //                });

    //                $http({
    //                    method: 'Delete',
    //                    url: 'api/DetalleRequerimientosWS',
    //                    params: {
    //                        Atendido: item.CantidadRequisito,
    //                        Faltante: item.Faltante,
    //                        ID_DetalleOrden: item.ID_DetalleOrden,
    //                    }
    //                }).success(function (response) {

    //                });

    //                $http({
    //                    method: 'POST',
    //                    url: 'api/StockWS',
    //                    params: {
    //                        Id_Producto: item.ID_Producto,
    //                        Codigo_Producto: item.Codigo_Producto,
    //                        CodigoDif: "A",
    //                        Lote: item.Lote_Requermientos,
    //                        Cantidad: item.CantidadRequisito,
    //                    }
    //                }).success(function (response) {

    //                });

    //                $http({
    //                    method: 'Delete',
    //                    url: 'api/OrdenVentaWS',
    //                    params: {
    //                        ID_Orden: $scope.New.ID_Orden,
    //                    }
    //                }).success(function (response) {

    //                });
    //            }

    //        }
    //        //$scope.ActualizarOden();
    //        alert("Registro Correcto");
    //        $scope.Cancel();
    //    });
    //}

    $scope.Edit = function () {
        $state.go('RequerimientosCreate');
    }

    $scope.Edit = function () {

        $state.go('RequerimientosModific');
    }


    if ($('#Id').val() != '0') {   //Editar

        $http({
            method: 'GET',
            url: 'api/RequerimientosWS',
            params: {
                ID_Requerimientos: $('#Id').val(),

            }
        }).success(function (response) {
            $scope.New = response;
            $scope.AList();
            $scope.RSelectSuc();
            $scope.ListarDetalle();
        });
    } else {                      //Crear
    }


    $scope.Delete = function () {
    }

    $scope.deleteDetalle = function (Id) {
        $http({
            method: 'Delete',
            url: 'api/DetalleRequerimientosWS',
            params: {
                ID_RequerimientoDetalle: Id,
            }
        }).success(function (response) {
            $scope.ListarDetalle();
            alert("Registro Eliminado");
        });

    }


    $scope.editDetalle = function (Id, CodProducto, DespProducto, fec, Lot, canReq, Almacen, Sucursal) {
        var modalInstance = $modal.open({
            templateUrl: '/DetalleRequerimientos/Modific',
            controller: 'DetalleRequerimientosController',
            resolve: {
                ID_Requerimientos: function () {
                    return $scope.New.ID_Requerimientos;
                },
                ID_RequerimientoDetalle: function () {
                    return Id;
                },
                Codigo_Producto: function () {
                    return CodProducto;
                },
                Descripcion_Producto: function () {
                    return DespProducto;
                },
                Fecha_venci: function () {
                    return fec;
                },
                Lot: function () {
                    return Lot;
                },
                CantidadRequisito: function () {
                    return canReq;
                },
                ID_Almacen: function () {
                    return Almacen;
                },

                ID_Sucursal: function () {
                    return Sucursal;
                },
                
                scope: function () {
                    return $scope;
                }

            }
        });

    }


    //function Loadddl() {
    //    $http({
    //        method: 'GET',
    //        url: 'api/ConceptoWS',
    //        params: {
    //            CodigoTabla: '004',

    //        }
    //    }).success(function (response) {
    //        $scope.MonedaList = response;
    //        $http({
    //            method: 'GET',
    //            url: 'api/ConceptoWS',
    //            params: {
    //                CodigoTabla: '013',

    //            }
    //        }).success(function (response) {
    //            $scope.FormaList = response;

    //            $http({
    //                method: 'GET',
    //                url: 'api/ConceptoWS',
    //                params: {
    //                    CodigoTabla: '013',

    //                }
    //            }).success(function (response) {
    //                $scope.CondicionList = response;

    //            });
    //        });
    //    });

    //}





    $scope.ListSuc();
    $scope.List();
}

RequerimientosController.$inject = ['$rootScope', '$scope', '$state', '$stateParams', '$http', '$modal'];