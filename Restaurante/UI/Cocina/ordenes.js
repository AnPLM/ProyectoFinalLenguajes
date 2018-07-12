function listaActiva(){
	var req = $.ajax({
	    url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSRestCoc.svc/ListaActiva",
		timeout: 10000,
    dataType:"jsonp"
	});
}

function Eliminar(identificador){
	var req = $.ajax({
	    url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSRestCoc.svc/Eliminar?" + identificador,
		timeout: 10000,
    dataType:"jsonp",
	});
}

function Buscar(){}

function Insertar(){}

function lista() {
	var req  = $.ajax({
	    url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSRestCoc.svc/ListaActiva",
		timeout: 10000,
    dataType: "jsonp"
	});
	req.done(function (datos) {
             cargarLista(datos);
         })
	req.fail(function (datos) {
	    alert("No hay ordenes solicitadas");
	});
}


setInterval(function () { lista(); }, 3000);

function cargarLista(datos){

    var table = document.getElementById('table');
    table.innerHTML = "";
	$.each(datos, function () {
	    var seg = calcularMinutos(this.Fecha);
	    var color = "#24D624"; //verde
	    if (seg > 10) {
	        color = "#F7FA04"; //amarillo
	    }
	    if (seg > 20) {
	        color = "#FF0000"; //rojo
	    }

	    var tr = document.createElement("tr");
	    tr.innerHTML += '<td class="text-center" bgcolor="' + color + '">' + this.nombreUsuario + "</td>";
	    tr.innerHTML += '<td class="text-center" bgcolor="' + color + '">' + this.Fecha + "</td>";
	    tr.innerHTML += '<td class="text-center" bgcolor="' + color + '">' + this.Estado + "</td>";
	    tr.innerHTML += '<td class="text-center" bgcolor="' + color + '">' + this.Identificador + "</td>";
	    tr.innerHTML += '<td class="text-center" bgcolor="' + color + '">' + '<button onclick="entregar(' + this.Identificador + ')"'
	    + '"id="' + this.Identificador + '"' + '>Entregar</button></td>'
	    var btnID = this.Identificador;
       // alert(btnID)
	    /*$('#' + btnID).bind("click", function () {
            alert("dentro del click")
	        entregar(btnID);
	    });*/
	    table.append(tr)
	});
}

function cargarPrimeraVez() {
    lista();
}

function calcularMinutos(fecha) {
    var fechaActual = new Date();
    var mili = Date.parse(fechaActual) - Date.parse(fecha, "dd-MM-yyyy HH:mm:ss")
    var segundos = (mili / 1000) - 3600;
   // alert(fechaActual);
    //alert(fecha);
    return segundos;
}

function entregar(btnId) {
   // alert("a punto de entregar")
    var req = $.ajax({
        url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSRestCoc.svc/actualizar?" + "estado=entregado" + "&" + "ide=" + btnId,
        timeout: 10000,
        dataType: "jsonp"
    });

    req.done(function (datos) {
       // alert("llego a renovar la lista");
        lista();
    })
    req.fail(function () {
       // alert("no logro renovar la lista");
    });

}


//     function generarTablaPlatos(datos) {
//         var bodyTablaPlatos = document.getElementById('bodyTablaPlatos');
//         bodyTablaPlatos.innerHTML = "";
//         $.each(datos, function() {
//             var tr = document.createElement("tr");
//             tr.innerHTML += '<td class="text-center">' + this.Codigo + "</td>";
//             tr.innerHTML += '<td class="text-center">' + this.Nombre + "</td>";
//             tr.innerHTML += '<td class="text-center">' + this.Precio + "</td>";
//                 tr.innerHTML += '<td class="text-center">' + '<button id="' + this.Nombre + '"'+'>Mostrar Detalles</button></td>'
//                 tr.innerHTML += '<td class="text-center">' + '<button id="' + this.Codigo + '","' + this.Nombre + + '","' + this.Precio + '"' + '>Agregar Plato</button></td>' ////////////
//                 bodyTablaPlatos.append(tr);
//                 var nombreAux = this.Nombre;
//                 $('#' + nombreAux).bind("click", function () {
//                     mostrarDetallesPlato(nombreAux);//Aquí no se usa this porque se referiría al botón.
//                 });
                
//                 //Crea un string con los datos de la fila seleccionada
//                 var nombreAuxCOd = this.Codigo + ", " + this.Nombre + ", " + this.Precio;
//                 $('#' + nombreAuxCOd).bind("click", function () {
//                     carrito.push(nombreAuxCOd) //Mete en el array "carrito" la info
//                     calcularTotal();
//                     llenarCarrito();
//                 });
//         });
//     }


// //////////////////////////////////////////
// let carrito = [];
// let total = 0;
// let $carrito = document.querySelector('#carrito');
// let $total = document.querySelector('#total');
// /////////////////////////////////////////

// function cargarPlatosTabla() {
//     var req = $.ajax({
//         url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/platosActivos",
//         timeout: 10000,
//         dataType:"jsonp"
//     }); //Es el que permite consultar/cargar información
//     //de una URL sin hacer postback
		
//     req.done(function (datos) {
//         generarTablaPlatos(datos);
//     })
//     req.fail(function(){
//         alert("¡Servicio no disponible, disculpe las molestias! Si desea emitir un reporte, puede hacerlo a nuestros teléfonos");
//     });
// }

// function inicioPagina() {
//     cargarPlatosTabla()
//     cargarUsuarioDrop()
// }

// function cargarUsuarioDrop() {
//     document.getElementById("drpUsuario").innerHTML = sessionStorage.getItem("NombreUsuario");
//     document.getElementById("drpUsuario").innerHTML += '<span class="caret"></span><!--flecha para dropdown-->'
// }
 
// setInterval(cargarPlatosTabla, 60000);
 
//     function calcularTotal() {
//        var i = 0
//        total = 0;
//        var info = "";
//        var precio = 0;
//         // Se recorre el array "carrito" sacando los precios y sumandolos
//         for (let item of carrito) {
//             info = carrito[i]
//             info = info.split(",")
//             precio = parseInt(info[2])
//             total = total + precio;
//             i = i + 1;
//         }
//         document.getElementById("total").innerHTML = total + "";
//     }

//     function llenarCarrito() {
//         $('#carrito').empty();
//         var bodyTablaCarrito = document.getElementById('bodyTablaCarrito');
//         bodyTablaCarrito.innerHTML = "";
//         var i = 0
//         for (let item of carrito) {
//             info = carrito[i]
//             info = info.split(",")
//             var tr = document.createElement("tr");
//             tr.innerHTML += '<td class="text-center">' + info[1] + "</td>";
//             tr.innerHTML += '<td class="text-center">' + info[2] + "</td>";
//             tr.innerHTML += '<td class="text-center">' + "Hola" + "</td>";
//             tr.innerHTML += '<td class="text-center">' + '<button id="' + i + '"'+'>X</button></td>'
//             bodyTablaCarrito.append(tr);
//             var nombreA = i;
//             $('#' + nombreA).bind("click", function () {
//                 borrarItemCarrito(i);
//             });
//             i = i + 1;
//         }   
//     }


//     function borrarItemCarrito(i) {
//         carrito.splice(i - 1, 1);
//         // volvemos a renderizar
//         llenarCarrito();
//         // Calcula el nuevo precio
//         calcularTotal();
//     }

//     function mostrarDetallesPlato(nombreAux) {
//         var req = $.ajax({
//             url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/buscarPlatoPorNombre" + "?Nombre=" + nombreAux,
//             timeout: 10000,
//             dataType: "jsonp"
//         }); //Es el que permite consultar/cargar información
//         //de una URL sin hacer postback

//         req.done(function (datos) {
//             generarTablaDetallePlato(datos);
//         })
//         req.fail(function () {
//             alert("¡Servicio no disponible, disculpe las molestias! Si desea emitir un reporte, puede hacerlo a nuestros teléfonos");
//         });
//     }

//     function generarTablaDetallePlato(datos) {
//         var bodyTablaDetallePlato = document.getElementById('bodyTablaDetallePlato');
//         var headListaPlatos = document.getElementById("headListaPlatos")
//         bodyTablaDetallePlato.innerHTML = "";
//         headListaPlatos.innerHTML = "";
//         $.each(datos, function () {
//             var tr = document.createElement("tr");
//             tr.innerHTML = '<th>Codigo</th>'
//             tr.innerHTML += '<th>Nombre</th>'
//             tr.innerHTML += '<th>Precio</th>'
//             tr.innerHTML += '<th>Descripcion</th>'
//             tr.innerHTML += '<th>Foto del plato</th>'
//             headListaPlatos.append(tr)
            
//             var tr2 = document.createElement("tr");
//             tr2.innerHTML = '<td class="text-center">' + this.Codigo + "</td>";
//             tr2.innerHTML += '<td class="text-center">' + this.Nombre + "</td>";
//             tr2.innerHTML += '<td class="text-center">' + this.Precio + "</td>";
//             tr2.innerHTML += '<td class="text-center">' + this.Descripcion + "</td>";
//             tr2.innerHTML += '<td class="text-center">' + this.Fotografia + "</td>";
//             bodyTablaDetallePlato.append(tr2);
//         });
//     }

//     function buscarPorNombre() {
//             var txtBuscarPlato = document.getElementById("txtBuscarPlato");
//             txtBuscarPlato = txtBuscarPlato.value.toUpperCase();
//             var td;
//             var filas;
            
//             table = document.getElementById("tablaPlatos");
//             filas = table.getElementsByTagName("tr");
//             for (i = 0; i < filas.length; i++) {
//                 td = filas[i].getElementsByTagName("td")[1];//Nombre del plato
//                 if (td) {
//                     if (td.innerHTML.toUpperCase().indexOf(txtBuscarPlato) > -1) {
//                         filas[i].style.display = "";
//                     } else {
//                         filas[i].style.display = "none";
//                     }
//                 }
//         }
//     }

    //function IniciarSesion() {
    //    var txtEmail = document.getElementById("txtEmail").value;
   //     var txtContrasenna = document.getElementById("txtContrasenna").value;
   //     if (txtContrasenna != null && txtEmail != null) {
   //         if (txtContrasenna.toString().trim() == "" || txtEmail.toString().trim() == "") {
  //              alert("¡Rellene los campos obligatorios, campos vacíos!")
  //          } else {
//                var req = $.ajax({
                    //url: "http://angielopez-001-site1.ctempurl.com/WSRest/WSCliente.svc/iniciarSesionCliente" + "?Email=" + txtEmail + "&" + "Contrasenna=" + txtContrasenna,
                    //timeout: 10000,
                  //  dataType: "jsonp"
                //});

                //req.done(function (datos) {
                  //  autenticarCliente(datos);
                //})
               // req.fail(function () {
              //      alert("¡Servicio no disponible, disculpe las molestias! Si desea emitir un reporte, puede hacerlo a nuestros teléfonos");
            //    });
          //  }
        //} else {
        //    alert("¡Rellene los campos obligatorios!")
      //  }
    //}

    //function autenticarCliente(datos) {
       // $.each(datos, function () {
            //window.sessionStorage.setItem("Nombre", this.Nombre)
            //window.sessionStorage.setItem("Correo", this.Correo)
            //window.sessionStorage.setItem("NombreUsuario", this.NombreUsuario)
           // window.sessionStorage.setItem("Direccion", this.Direccion)
         //   document.location.href = document.location.href.replace("InicioSesionCliente.html", "ClienteMenu.html");
       // });
    ///}

    //function pruebaAlert() {
      //  alert("La prueba ha funcionado. :)")
    //}