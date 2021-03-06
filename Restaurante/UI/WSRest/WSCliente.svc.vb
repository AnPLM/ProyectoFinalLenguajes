﻿' NOTE: You can use the "Rename" command on the context menu to change the class name "WSCliente" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select WSCliente.svc or WSCliente.svc.vb at the Solution Explorer and start debugging.
Imports BL
Imports UI

Public Class WSCliente
    Implements IWSCliente

    Dim listaPedidoBL As New ManejadorListaPedido
    Dim ordenBL As New ManejadorOrdenes

    Public Function buscarPlatoPorNombre(Nombre As String) As List(Of Plato) Implements IWSCliente.buscarPlatoPorNombre
        Dim plato As New Plato()
        plato.Nombre = Nombre
        plato.buscarPlato()
        Dim list As New List(Of Plato)
        list.Add(plato)
        Return list
    End Function

    Public Function platosActivos() As List(Of Plato) Implements IWSCliente.platosActivos
        Dim plato As New Plato()
        Return plato.listarPlatosCliente()
    End Function

    Public Function iniciarSesionCliente(Email As String, Contrasenna As String) As List(Of Cliente) Implements IWSCliente.iniciarSesionCliente
        Dim cliente As New Cliente()
        cliente.Correo = Email
        cliente.Contrasenna = Contrasenna
        cliente.autenticarCliente()
        Dim list As New List(Of Cliente)
        list.Add(cliente)
        Return list
        'Falta validar si posee Nombre_Usuario es porque se autentico correctamente
        'El nombre de usuario se ocupa para tenerlo en la session para agregar los pedidos del carrito
    End Function

    Public Function finalizarCompraCarrito(Carrito As String, nombreUsuario As String) As String Implements IWSCliente.finalizarCompraCarrito
        ''Return Carrito
        Dim carritoArray = Carrito.Split(",")
        Dim prueba = "Sirvió. :)"
        Dim secuencialOrden = ordenBL.insertar(nombreUsuario, Nothing, "activo", 0)
        For index = 0 To carritoArray.Length Step 4
            If index >= carritoArray.Length Then
                Exit For
            End If
            listaPedidoBL.insertarListaPedido(carritoArray(index), secuencialOrden, carritoArray(index + 3))
        Next
        Return prueba
    End Function

    Public Function registrarCliente(nombre As String, nombreUsuario As String, correo As String, direccion As String, contrasenna As String) As List(Of Cliente) Implements IWSCliente.registrarCliente
        Dim cliente As New Cliente(nombre, correo, nombreUsuario, contrasenna, True, direccion)
        cliente.agregarCliente()
        Dim list As New List(Of Cliente)
        list.Add(cliente)
        Return list
    End Function

    Public Sub actualizarDatosCliente(nombre As String, nombreUsuario As String, direccion As String, contrasenna As String) Implements IWSCliente.actualizarDatosCliente
        Dim cliente As New Cliente()
        cliente = cliente.buscarCliente(nombreUsuario)
        If String.Compare(cliente.Nombre, nombre) = 0 Then
            nombre = ""
        End If
        If String.Compare(cliente.Direccion, direccion) = 0 Then
            direccion = ""
        End If
        If String.Compare(cliente.Contrasenna, contrasenna) = 0 Then
            contrasenna = ""
        End If
        cliente.actualizarDatosCliente(nombreUsuario, direccion, nombre, contrasenna)
    End Sub

    Public Function buscarCliente(nombreUsuario As String) As List(Of Cliente) Implements IWSCliente.buscarCliente
        Dim blCliente As New Cliente()
        blCliente = blCliente.buscarCliente(nombreUsuario)
        Dim list As New List(Of Cliente)
        list.Add(blCliente)
        Return list
    End Function
End Class
