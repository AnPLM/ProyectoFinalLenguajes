//////////////////////////////////////////
let carrito = [];
var x = "5"
let total = 0;
let $carrito = document.querySelector('#carrito');
let $total = document.querySelector('#total');
/////////////////////////////////////////

function cargarPlatosTabla() {
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

function inicioPaginaMenu() {
    cargarPlatosTabla()
    cargarUsuarioDropMenu()
}

function cargarUsuarioDropMenu() {
    var usuario = sessionStorage.getItem("NombreUsuario");
    if (usuario == null) {
        document.location.href = document.location.href.replace("ClienteMenu.html", "InicioSesionCliente.html");
        alert("Debe iniciar sesión")
    } else {
        if (usuario.toString() == "null") {
            document.location.href = document.location.href.replace("ClienteMenu.html", "InicioSesionCliente.html");
            alert("Debe iniciar sesión")
        } else {
            document.getElementById("drpUsuario").innerHTML = usuario;
            document.getElementById("drpUsuario").innerHTML += '<span class="caret"></span><!--flecha para dropdown-->'
        }
        
    }
}

function cargarUsuarioDropCarrito() {
    var usuario = sessionStorage.getItem("NombreUsuario");
    if (usuario == null) {
        document.location.href = document.location.href.replace("ClienteCarrito.html", "InicioSesionCliente.html");
        alert("Debe iniciar sesión")
    } else {
        if (usuario.toString() == "null") {
            document.location.href = document.location.href.replace("ClienteCarrito.html", "InicioSesionCliente.html");
            alert("Debe iniciar sesión")
        } else {
            document.getElementById("drpUsuario").innerHTML = usuario;
            document.getElementById("drpUsuario").innerHTML += '<span class="caret"></span><!--flecha para dropdown-->'
        }
    }
}
 
setInterval(cargarPlatosTabla, 60000);

    function generarTablaPlatos(datos) {
        var bodyTablaPlatos = document.getElementById('bodyTablaPlatos');
        bodyTablaPlatos.innerHTML = "";
        $.each(datos, function () {
            var nombreAux = this.Nombre.replace(/\s/g, '');
            var auxCodeCantidad = this.Codigo;
            var tr = document.createElement("tr");
            tr.innerHTML += '<td class="text-center">' + this.Codigo + "</td>";
            tr.innerHTML += '<td class="text-center">' + this.Nombre + "</td>";
            tr.innerHTML += '<td class="text-center">' + this.Precio + "</td>";
            tr.innerHTML += '<td class="text-center">' + '<button type="button" class="btn btn-primary" id="' + nombreAux + '"' + '>Mostrar Detalles</button></td>'
            tr.innerHTML += '<td class="text-center">' + '<button type="button" class="btn btn-success" id="' + this.Codigo + '","' + this.Nombre + + '","' + this.Precio + '"' + '>Agregar Plato</button>\
<input id="' + nombreAux + auxCodeCantidad + 'cantidad" type="number" name="cantidadProd" step="1" min="1" max="'+ x +'" style="margin-left:2.0em" value="1" required></td>' ////////////
                bodyTablaPlatos.append(tr);
                
                var nombreAux2 = this.Nombre;
                $('#' + nombreAux).bind("click", function () {
                    mostrarDetallesPlato(nombreAux2);//Aquí no se usa this porque se referiría al botón.
                });
                
                //Crea un string con los datos de la fila seleccionada
                var nombreAuxCOd = this.Codigo + ", " + this.Nombre + ", " + this.Precio;

                var auxString = "cantidad";
                $('#' + nombreAuxCOd).bind("click", function () {
                    var carrito2 = JSON.parse(sessionStorage.getItem("carrito"));
                    if (carrito2 != null) {
                        var cantidad = document.getElementById(nombreAux + auxCodeCantidad + auxString).value;
                        revisarCarrito(auxCodeCantidad, cantidad, nombreAuxCOd)
                        alert("Producto añadido: " + nombreAux2)
                    } else {
                        var a = nombreAux + auxCodeCantidad + auxString;
                        var cantidad = document.getElementById(nombreAux + auxCodeCantidad + auxString).value;
                    carrito.push(nombreAuxCOd + ", " + cantidad) //Mete en el array "carrito" la info
                    window.sessionStorage.setItem("carrito", JSON.stringify(carrito))
                    alert("Producto añadido: " + nombreAux2)
                    }
                });

            //Prohibir que los input de cantidad sean editables sin flecha
                $('[id="' + nombreAux + auxCodeCantidad + 'cantidad"]').keypress(function (evt) {
                    evt.preventDefault();
                    alert("¡Use las flechas por favor!")
                });
        });
    }

    function revisarCarrito(auxCodeCantidad, cantidad, nombreAuxCOd) {
        var carrito2 = JSON.parse(sessionStorage.getItem("carrito"));
        for (i = carrito2.length - 1; i >= 0; i--) {
            info = carrito2[i]
            info = info.split(",")
            if (info[0] === auxCodeCantidad) {
                var nuevaCantidad = parseInt(info[3]) + parseInt(cantidad)
                var pos = carrito2[i].toString().lastIndexOf(info[3]);
                var x = carrito2[i].toString().substring(0, pos + 1) + nuevaCantidad + carrito2[i].toString().substring(pos + 2);
                carrito2[i] = x;
                window.sessionStorage.setItem("carrito", JSON.stringify(carrito2))
                break;
            }
            if (i == 0) {
                carrito2.push(nombreAuxCOd + ", " + cantidad) //Mete en el array "carrito" la info
                window.sessionStorage.setItem("carrito", JSON.stringify(carrito2))
            }
        }
    }
 
    function calcularTotal() {
        var carrito2 = JSON.parse(sessionStorage.getItem("carrito"));
        total = 0;
            var i = 0
            var info = "";
            var precio = 0;
            var cantidad = 0;
            // Se recorre el array "carrito" sacando los precios y sumandolos
            for (let item of carrito2) {
                info = carrito2[i]
                info = info.split(",")
                cantidad = parseInt(info[3]);
                precio = parseInt(info[2])
                total = total + (precio*cantidad);
                i = i + 1;
            }
            var totalSession = sessionStorage.setItem("total", total)
       document.getElementById("total").innerHTML = total;
    }

    function llenarCarrito() {
        var carrito2 = JSON.parse(sessionStorage.getItem("carrito"));
        $('#carrito2').empty();
        var bodyTablaCarrito = document.getElementById('bodyTablaCarrito');
        bodyTablaCarrito.innerHTML = "";
        var i = 0
        $.each(carrito2, function (i, item) {
            info = carrito2[i]
            info = info.split(",")
            var tr = document.createElement("tr");
            var btID = info[1].replace(/\s/g, '');
            tr.innerHTML += '<td class="text-center">' + info[1] + "</td>";
            tr.innerHTML += '<td class="text-center">' + info[2] + "</td>";
            tr.innerHTML += '<td class="text-center">' + info[3] + "</td>";
            tr.innerHTML += '<td class="text-center">' + '<button type="button" class="btn btn-danger" id="' + btID + '"' + '>X</button></td>'
            bodyTablaCarrito.append(tr);
            $('#' + btID).bind("click", function () {
                borrarItemCarrito(btID);
            });
            i = i + 1;
        });
    }

    function borrarItemCarrito(btID) {
        var btAux;
        var carrito2 = JSON.parse(sessionStorage.getItem("carrito"));
        for (i = carrito2.length - 1; i >= 0; i--) {
            info = carrito2[i]
            info = info.split(",")
            btAux = info[1].replace(/\s/g, '');
            if (btAux === btID) {
                carrito2.splice(i, 1);
                break;
            }
        }
        window.sessionStorage.setItem("carrito", JSON.stringify(carrito2))
        // volvemos a renderizar
        llenarCarrito();
        // Calcula el nuevo precio
        calcularTotal();
    }

    function mostrarDetallesPlato(nombreAux2) {
        var req = $.ajax({
            url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/buscarPlatoPorNombre" + "?Nombre=" + nombreAux2,
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

    function buscarPorNombrePlatos() {
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

    function buscarPorNombreCarrito() {
        var txtBuscarPlato = document.getElementById("txtBuscarPlato");
        txtBuscarPlato = txtBuscarPlato.value.toUpperCase();
        var td;
        var filas;

        table = document.getElementById("tablaCarrito");
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

    function cerrarSesion() {
        var user = sessionStorage.removeItem("NombreUsuario");
        session.removeItem("carrito");
            document.location.href = document.location.href.replace("ClienteMenu.html", "InicioSesionCliente.html");
    }

    function finalizarCompra() {
        var usuario = sessionStorage.getItem("NombreUsuario");
        var carrito2 = JSON.parse(sessionStorage.getItem("carrito"));
        var req = $.ajax({
            url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/finalizarCompraCarrito?Carrito=" + carrito2 + "&nombreUsuario=" + usuario.toString(),
            timeout: 10000,
            dataType: "jsonp"
        }); //Es el que permite consultar/cargar información
        //de una URL sin hacer postback

        req.done(function (datos) {
            sessionStorage.removeItem("carrito");
            document.location.href = document.location.href.replace("InicioSesionCliente.html", "ClienteMenu.html");

        })
        req.fail(function () {
            alert("¡Servicio no disponible, disculpe las molestias! Si desea emitir un reporte, puede hacerlo a nuestros teléfonos");
        });
    }

    function inicioPaginaCarrito() {
        cargarUsuarioDropCarrito()
        llenarCarrito()
        calcularTotal()
    }
  