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
        placeholder: "Buscar cama",
        inputText: "textSearchCama",
        btnId: "btnSearchCama"
    });
}