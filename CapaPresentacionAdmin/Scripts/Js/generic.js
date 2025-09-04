function getId(IdElement) {
    return document.getElementById(IdElement)
}


function Pintar(objConfiguration, objBusqueda) {
const SeccionBusqueda = (objBusqueda != undefined && objBusqueda.Buscar === true) ?
    `<div class="input-group mb-3" >
                    <input type="text" class="form-control" id="${objBusqueda.inputText}" placeholder="${objBusqueda.placeholder}">
                        <button class="btn btn-primary" type="button" id="${objBusqueda.btnId}">Buscar</button>
                </div>`: '';
    fetch(objConfiguration.url)
        .then(res => res.json())
        .then(data => {
            //Busqueda
          
            // Cabecera de la tabla
            const cabecera = objConfiguration.cabeceras
                .map(th => `<th>${th}</th>`)
                .join('');

            // Filas de la tabla
            const filas = data
                .map(fila => {
                    const celdas = objConfiguration.Datos
                        .map(col => {
                            const valor = fila[col];
                            if (col === 'Estado') {
                                return `<td>${valor === true
                                    ? '<span class="bg-success text-white rounded px-2 py-1 small">Disponible</span>'
                                    : '<span class="bg-danger text-white rounded px-2 py-1 small">Ocupada</span>'
                                    }</td>`;
                            }
                            return `<td>${valor}</td>`;
                        })
                        .join('');
                    return `<tr>${celdas}</tr>`;
                })
                .join('');

            // Tabla completa
            const tabla = `
            ${SeccionBusqueda}
                <table class="table table-striped rounded-top overflow-hidden">
                    <thead class="bg-dark text-white">
                        <tr>${cabecera}</tr>
                    </thead>
                    <tbody>
                        ${filas}
                    </tbody>
                </table>`;

            getId(objConfiguration.Id).innerHTML = tabla;
            if (objBusqueda && objBusqueda.Buscar == true) {
                getId(objBusqueda.btnId).addEventListener("click", () => {
                    const parametros = getId(objBusqueda.inputText).value;
                    const paramName = objBusqueda.paramName || "nombre";
                    Pintar({
                        ...objConfiguration,
                        url: UrlSearch + `?${paramName}=${encodeURIComponent(parametros)}`
                    }, objBusqueda);
                });
            }
        });
}

