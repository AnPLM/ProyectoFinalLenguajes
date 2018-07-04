function cargarPlatosTabla() {
    var req = $.ajax({
        url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/platosActivos",
        timeout: 10000,
        dataType:"jsonp"
    }); //Es el que permite consultar/cargar información
    //de una URL sin hacer postback
		
    req.done(function(datos){
        generarTablaPlatos(datos);
    })
    req.fail(function(){
        alert("¡Servicio no disponible, disculpe las molestias! Si desea emitir un reporte, puede hacerlo a nuestros teléfonos");
    });
}

    function generarTablaPlatos(datos) {
        var bodyTablaPlatos = document.getElementById('bodyTablaPlatos');
        $.each(datos, function() {
            var tr = document.createElement("tr");
                tr.innerHTML += '<td class="text-center">' + this.Codigo + "</td>";
                tr.innerHTML += '<td class="text-center">' + this.Nombre + "</td>";
                tr.innerHTML += '<td class="text-center">' + this.Precio + "</td>";
                tr.innerHTML += '<td class="text-center">' + "<button onclick=mostrarDetallesPlato(" + this.Codigo + ")>Eliminar</button></td>"
                bodyTablaPlatos.append(tr);
        });
    }
