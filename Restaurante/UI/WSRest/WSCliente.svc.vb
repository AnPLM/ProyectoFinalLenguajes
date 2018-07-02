' NOTE: You can use the "Rename" command on the context menu to change the class name "WSCliente" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select WSCliente.svc or WSCliente.svc.vb at the Solution Explorer and start debugging.
Imports BL
Imports UI

Public Class WSCliente
    Implements IWSCliente

    Dim listaPedidoBL As New ManejadorListaPedido


    Public Function obtenerPedidosPorUsuario(nombre_usuario As String) As List(Of BLListaPedido) Implements IWSCliente.obtenerPedidosPorUsuario
        Return listaPedidoBL.obtenerPedidosPorUsuario(nombre_usuario)
    End Function
End Class
