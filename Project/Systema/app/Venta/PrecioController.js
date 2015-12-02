
var PrecioController = function ($rootScope, $scope, $modalInstance, $http, ID_Producto, ID_Precio, scope) {



    $scope.New = {
        ID_Precio: ID_Precio,
        ID_Producto: ID_Producto,
        Precios: '',
        ID_Socio: '',
        Nombres: '',
        Fecha_vigen: '',
        Tipo:'Proveedor',
    }


    $scope.CNew = {
        ID_Precio: ID_Precio,
        ID_Producto: ID_Producto,
        Precios: '',
        ID_Socio: '',
        Nombres: '',
        Fecha_vigen: '',
        Tipo: 'Cliente',
    }

    $scope.open = function ($event) {
        $event.preventDefault();
        $event.stopPropagation();

        $scope.opened = true;


    };

    $scope.List = function () {

        $http({
            method: 'GET',
            url: 'api/SocioNegocioWS',        
        }).success(function (response) {
            $scope.SocioList = response;

        });

    }


    $scope.List2 = function () {

        $http({
            method: 'GET',
            url: 'api/SocioNegocioWS',
            params: {

                TipoSocio: 'C',
                Nombres: ''

            }
        }).success(function (response) {
            $scope.CSocioList = response;

        });

    }



    $scope.ok = function () {
        modeAction();
      

    };


    $scope.Cok = function () {
        CmodeAction();

    };




    $scope.cancel = function () {

        $modalInstance.dismiss('cancel');
    };


    function modeAction() {

        $http({
            method: 'Post',
            url: 'api/PrecioWS',
            data: $scope.New,
        }).success(function (response) {
            scope.ListarPrecio();
   
            $modalInstance.dismiss('cancel');
        });
    }



    function CmodeAction() {

        $http({
            method: 'Post',
            url: 'api/PrecioWS',
            data: $scope.CNew,
        }).success(function (response) {
            scope.CListarPrecio();
            $modalInstance.dismiss('cancel');
        });
  }


    if (ID_Precio != 0) {
        $http({
            method: 'Get',
            url: 'api/PrecioWS',
            params: {
                ID_Precio: ID_Precio,
                cod: 0
            }
        }).success(function (responsse) {
            $scope.New = responsse;
        });

    }

    $scope.List();

    $scope.List2();

}
PrecioController.$inject = ['$rootScope', '$scope', '$modalInstance', '$http', 'ID_Producto', 'ID_Precio', 'scope'];