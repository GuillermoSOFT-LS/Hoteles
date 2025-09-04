function listarHabitaciones() {
    Pintar({
        url: UrlListar,
        cabeceras: ['Id', 'Tipo', 'Descripcion'],
        Datos: ['Id', 'Tipo', 'Descripcion'],
        Id: 'IdTabla'
    }, {
        Buscar: true,
        placeolder: "Buscar habitacion",
        inputText: "textSearchHabitacion",
        btnId: "btnSearchHabitacion"
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