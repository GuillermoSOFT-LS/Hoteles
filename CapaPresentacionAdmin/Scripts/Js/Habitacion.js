window.onload = function () {
    listarHabitaciones();
}
function listarHabitaciones()
{
    Pintar({
        url: UrlListar,
        cabeceras: ['Id', 'Tipo', 'Descripcion'],
        Datos: ['Id', 'Tipo', 'Descripcion'],
        Id: 'IdTabla'
    }, {
        Buscar: true,
        placeholder: "Buscar habitacion",
        inputText: "textSearch",
        btnId: "btnSearch"
    });
}