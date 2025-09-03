window.onload = function () {
    listarHabitaciones();
}
function listarHabitaciones()
{
    Pintar({
        url: 'Home/ListaHabitaciones',
        cabeceras: ['Id', 'Tipo', 'Descripcion'],
        Datos: ['Id', 'Tipo', 'Descripcion'],
        Id: 'IdTabla'
    });
}