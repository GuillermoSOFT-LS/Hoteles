window.onload = function () {
    listarCamas();
}
function listarCamas() {
    Pintar({
        url: UrlLista,
        cabeceras: ['Id', 'Tipo', 'Descripcion'],
        Datos: ['Id', 'Nombre', 'Descripcion'],
        Id: 'IdTablaCamas'
    }, {
        Buscar: true,
        placeolder: "Buscar cama",
        inputText: "textSearchCama",
        btnId: "btnSearchCama"
    });
}


function Buscar() {
    var parametros = document.getElementById(inputText).value;
    Pintar({
        url: UrlSearch + `?nombre=${encodeURIComponent(parametros)}`,
        Datos: ['Id', 'Tipo', 'Descripcion'],
        cabeceras: ['Id', 'Tipo', 'Descripcion'],
        Id: 'IdTabla'
    });
}


window.onload = function () {
    listarHabitaciones();
    document.getElementById(btnId).addEventListener("click", Buscar);
}
