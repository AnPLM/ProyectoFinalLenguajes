﻿function cargarPlatosTabla() {
    var req = $.ajax({
        url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/platosActivos",
        timeout: 10000,
        dataType:"jsonp"
    }); //Es el que permite consultar/cargar información
    //de una URL sin hacer postback
		
    req.done(function (datos) {
        generarTablaPlatos(datos);
    })
    req.fail(function(){
        alert("¡Servicio no disponible, disculpe las molestias! Si desea emitir un reporte, puede hacerlo a nuestros teléfonos");
    });
}

setInterval(cargarPlatosTabla, 60000);

    function generarTablaPlatos(datos) {
        var bodyTablaPlatos = document.getElementById('bodyTablaPlatos');
        bodyTablaPlatos.innerHTML = "";
        $.each(datos, function() {
            var tr = document.createElement("tr");
            tr.innerHTML += '<td class="text-center">' + this.Codigo + "</td>";
                tr.innerHTML += '<td class="text-center">' + this.Nombre + "</td>";
                tr.innerHTML += '<td class="text-center">' + this.Precio + "</td>";
                tr.innerHTML += '<td class="text-center">' + '<button id="' + this.Nombre + '"'+'>Mostrar Detalles</button></td>'
                tr.innerHTML += '<td class="text-center">' + "<button onclick=agregarPlato()>Agregar plato, no funciona aún</button></td>"
                bodyTablaPlatos.append(tr);
                var nombreAux = this.Nombre;
                $('#' + nombreAux).bind("click", function () {
                    mostrarDetallesPlato(nombreAux);//Aquí no se usa this porque se referiría al botón.
                    });

        });
    }

    function mostrarDetallesPlato(nombreAux) {
        var req = $.ajax({
            url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/buscarPlatoPorNombre" + "?Nombre=" + nombreAux,
            timeout: 10000,
            dataType: "jsonp"
        }); //Es el que permite consultar/cargar información
        //de una URL sin hacer postback

        req.done(function (datos) {
            generarTablaDetallePlato(datos);
        })
        req.fail(function () {
            alert("¡Servicio no disponible, disculpe las molestias! Si desea emitir un reporte, puede hacerlo a nuestros teléfonos");
        });
    }

    function generarTablaDetallePlato(datos) {
        var bodyTablaDetallePlato = document.getElementById('bodyTablaDetallePlato');
        bodyTablaDetallePlato.innerHTML = "";
        $.each(datos, function () {
            var tr = document.createElement("tr");
            tr.innerHTML += '<td class="text-center">' + this.Codigo + "</td>";
            tr.innerHTML += '<td class="text-center">' + this.Nombre + "</td>";
            tr.innerHTML += '<td class="text-center">' + this.Precio + "</td>";
            tr.innerHTML += '<td class="text-center">' + this.Descripcion + "</td>";
            tr.innerHTML += '<td class="text-center">' + this.Fotografia + "</td>";
            bodyTablaDetallePlato.append(tr);
        });
    }

    function buscarPorNombre() {
            var txtBuscarPlato = document.getElementById("txtBuscarPlato");
            txtBuscarPlato = txtBuscarPlato.value.toUpperCase();
            var td;
            var filas;
            
            table = document.getElementById("tablaPlatos");
            filas = table.getElementsByTagName("tr");
            for (i = 0; i < filas.length; i++) {
                td = filas[i].getElementsByTagName("td")[1];//Nombre del plato
                if (td) {
                    if (td.innerHTML.toUpperCase().indexOf(txtBuscarPlato) > -1) {
                        filas[i].style.display = "";
                    } else {
                        filas[i].style.display = "none";
                    }
                }
        }
    }

    function IniciarSesion() {
        var txtEmail = document.getElementById("txtEmail");
        var txtContrasenna = document.getElementById("txtContrasenna");
        var req = $.ajax({
            url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/iniciarSesionCliente?Email=" + txtEmail + "&" + "Contrasenna=" + txtContrasenna,
            //timeout: 10000,
            dataType: "jsonp"
        }); 

        req.done(function (datos) {
            autenticarCliente(datos);
        })
        req.fail(function () {
            alert("¡Servicio no disponible, disculpe las molestias! Si desea emitir un reporte, puede hacerlo a nuestros teléfonos");
        });
    }


   
