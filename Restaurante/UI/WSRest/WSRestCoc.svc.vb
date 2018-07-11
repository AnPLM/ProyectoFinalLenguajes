' NOTE: You can use the "Rename" command on the context menu to change the class name "WSRestCoc" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select WSRestCoc.svc or WSRestCoc.svc.vb at the Solution Explorer and start debugging.
Imports BL
Imports UI

Public Class WSRestCoc
    Implements IWSRestCoc

    Dim man As New ManejadorOrdenes

    Public Sub actualizar(nombre As String, fecha As Date, estado As String, ide As Integer) Implements IWSRestCoc.actualizar
        man.actualizar(nombre, fecha, estado, ide)
    End Sub

    Public Sub Eliminar(id As String) Implements IWSRestCoc.Eliminar
        man.eliminar(id)
    End Sub

    Public Sub insertar(nombreUsuario As String, fechas As Date, Estado As String, Identificador As Integer) Implements IWSRestCoc.insertar
        man.insertar(nombreUsuario, fechas, Estado, Identificador)
    End Sub

    Public Function Buscar(ide As String) As BLOrden Implements IWSRestCoc.Buscar
        Return man.Buscar(ide)
    End Function

    Public Function ListaActiva() As List(Of BLOrden) Implements IWSRestCoc.ListaActiva
        Return man.listaActiva()
    End Function

    Public Function ListaOrdenes() As List(Of BLOrden) Implements IWSRestCoc.ListaOrdenes
        Dim list As New List(Of BLOrden)
        For Each i As BLOrden In man.listaOrdenes
            list.Add(i)
        Next

        Return list
    End Function
End Class
