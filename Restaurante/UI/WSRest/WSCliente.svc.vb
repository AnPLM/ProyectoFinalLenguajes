' NOTE: You can use the "Rename" command on the context menu to change the class name "WSCliente" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select WSCliente.svc or WSCliente.svc.vb at the Solution Explorer and start debugging.
Imports BL
Imports UI

Public Class WSCliente
    Implements IWSCliente

    Dim listaPedidoBL As New ManejadorListaPedido

    Public Sub registrarCliente(nombre As String, nombreUsuario As String, correo As String, direccion As String, contrasenna As String) Implements IWSCliente.registrarCliente
        Dim cliente As New Cliente(nombre, correo, nombreUsuario, contrasenna, True, direccion)
        cliente.agregarCliente()
    End Sub

    Public Function obtenerPedidosPorUsuario(nombre_usuario As String) As List(Of BLListaPedido) Implements IWSCliente.obtenerPedidosPorUsuario
        Return listaPedidoBL.obtenerListaPedidosPorUsuario(nombre_usuario) 'Si manda conflicto convervar esta'
    End Function

    Public Function platosActivos() As List(Of Plato) Implements IWSCliente.platosActivos
        Dim plato As New Plato()
        Return plato.listarPlatosCliente()
    End Function
End Class
