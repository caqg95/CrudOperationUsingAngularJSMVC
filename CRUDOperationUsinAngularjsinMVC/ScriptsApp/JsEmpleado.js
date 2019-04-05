var JsEmpleado = angular.module('JsEmpleado', []);
JsEmpleado.controller('empleadoCtrl', function ($scope, $http) {

    $scope.empleado = "";
    $http({
        method: 'GET',
        url: '/Empleado/ObtenerEmpleado'
    }).then(function (result) {
        $scope.empleado = result.data;
        }, function (result) {
        console.log('sucedio un error por que sera:' + result)
    });
});