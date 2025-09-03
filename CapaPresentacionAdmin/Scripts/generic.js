
function Pintar(objConfiguration) {
    fetch(objConfiguration.url)
        .then(res => res.json())
        .then(data => {
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
                <table class="table table-striped rounded-top overflow-hidden">
                    <thead class="bg-dark text-white">
                        <tr>${cabecera}</tr>
                    </thead>
                    <tbody>
                        ${filas}
                    </tbody>
                </table>
            `;

            document.getElementById(objConfiguration.Id).innerHTML = tabla;
        });
}

