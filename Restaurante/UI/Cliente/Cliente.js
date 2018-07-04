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

function inicioPagina() {
    cargarPlatosTabla()
    cargarUsuarioDrop()
}

function cargarUsuarioDrop() {
    document.getElementById("drpUsuario").innerHTML = sessionStorage.getItem("NombreUsuario");
    document.getElementById("drpUsuario").innerHTML += '<span class="caret"></span><!--flecha para dropdown-->'
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
        var headListaPlatos = document.getElementById("headListaPlatos")
        bodyTablaDetallePlato.innerHTML = "";
        headListaPlatos.innerHTML = "";
        $.each(datos, function () {
            var tr = document.createElement("tr");
            tr.innerHTML = '<th>Codigo</th>'
            tr.innerHTML += '<th>Nombre</th>'
            tr.innerHTML += '<th>Precio</th>'
            tr.innerHTML += '<th>Descripcion</th>'
            tr.innerHTML += '<th>Foto del plato</th>'
            headListaPlatos.append(tr)
            
            var tr2 = document.createElement("tr");
            tr2.innerHTML = '<td class="text-center">' + this.Codigo + "</td>";
            tr2.innerHTML += '<td class="text-center">' + this.Nombre + "</td>";
            tr2.innerHTML += '<td class="text-center">' + this.Precio + "</td>";
            tr2.innerHTML += '<td class="text-center">' + this.Descripcion + "</td>";
            tr2.innerHTML += '<td class="text-center">' + this.Fotografia + "</td>";
            bodyTablaDetallePlato.append(tr2);
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
        var txtEmail = document.getElementById("txtEmail").value;
        var txtContrasenna = document.getElementById("txtContrasenna").value;
        if (txtContrasenna != null && txtEmail != null) {
            if (txtContrasenna.toString().trim() == "" || txtEmail.toString().trim() == "") {
                alert("¡Rellene los campos obligatorios, campos vacíos!")
            } else {
                var req = $.ajax({
                    url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/iniciarSesionCliente" + "?Email=" + txtEmail + "&" + "Contrasenna=" + txtContrasenna,
                    timeout: 10000,
                    dataType: "jsonp"
                });

                req.done(function (datos) {
                    autenticarCliente(datos);
                })
                req.fail(function () {
                    alert("¡Servicio no disponible, disculpe las molestias! Si desea emitir un reporte, puede hacerlo a nuestros teléfonos");
                });
            }
        } else {
            alert("¡Rellene los campos obligatorios!")
        }
    }

    function autenticarCliente(datos) {
        $.each(datos, function () {
            window.sessionStorage.setItem("Nombre", this.Nombre)
            window.sessionStorage.setItem("Correo", this.Correo)
            window.sessionStorage.setItem("NombreUsuario", this.NombreUsuario)
            window.sessionStorage.setItem("Direccion", this.Direccion)
            document.location.href = document.location.href.replace("InicioSesionCliente.html", "ClienteMenu.html");
        });
    }

    function pruebaAlert() {
        alert("La prueba ha funcionado. :)")
    }