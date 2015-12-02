var AddProductosGrupoController = function ($rootScope, $scope, $modalInstance, $http, ID_Grupo, scope) {

    $scope.parameters = {
        Descripcion_Producto: "",
        ID_SubCategoria: "",
        ID_Categoria: "",
        ID_Marca:"",

    }

    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/ProductoWS',
            params: {

                Descripcion_Producto: $scope.parameters.Descripcion_Producto == (null || '') ? "%" : $scope.parameters.Descripcion_Producto,
                ID_SubCategoria: $scope.parameters.ID_SubCategoria == (null || '') ? "%" : $scope.parameters.ID_SubCategoria,
                ID_Categoria: $scope.parameters.ID_Categoria == (null || '') ? "%" : $scope.parameters.ID_Categoria,
                ID_Marca: $scope.parameters.ID_Marca == (null || '') ? "%" : $scope.parameters.ID_Marca,
            }
        }).success(function (response) {
            $scope.DetalleGrupoProductoAddList = response;

        });

    }

    $scope.ListMarca = function () {
        $http({
            method: 'GET',
            url: 'api/MarcaWS',
        }).success(function (response) {
            $scope.MarcaList = response;
        });

    }

    $scope.ListCategoria = function () {
        $http({
            method: 'GET',
            url: 'api/CategoriaWS',
        }).success(function (response) {
            $scope.CategoriaList = response;

            $http({
                method: 'GET',
                url: 'api/UnidadMedidaWS',
            }).success(function (response) {
                $scope.UnidadList = response;
            });


        });

    }

    $scope.Loadddl = function () {

        $http({
            method: 'GET',
            url: 'api/MarcaWS',
        }).success(function (response) {
            $scope.MarcaList = response;

            $scope.ListCategoria();

        });


    }

    $scope.SelectCategoria = function () {
        $http({
            method: 'GET',
            url: 'api/SubCategoriaWS',
            params: {
                ID_Categoria: $scope.New.ID_Categoria == (null || 0) ? "%" : $scope.New.ID_Categoria,

            }
        }).success(function (response) {
            $scope.SubCategoriaList = response;

        });


    }


    $scope.XSelectSubCategoria = function () {
        $http({
            method: 'GET',
            url: 'api/SubCategoriaWS',
            params: {
                ID_Categoria: $scope.parameters.ID_Categoria == (null || 0) ? "%" : $scope.parameters.ID_Categoria,

            }
        }).success(function (response) {
            $scope.SubCategoriaList = response;

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

        $.each($scope.DetalleGrupoProductoAddList, function (index, value) {
            if (value.checked == true) {

                var item = $scope.DetalleGrupoProductoAddList[index];
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
    $scope.Loadddl();
}
AddProductosGrupoController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'ID_Grupo', 'scope'];



