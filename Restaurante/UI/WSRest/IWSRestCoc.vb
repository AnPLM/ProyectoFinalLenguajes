Imports System.ServiceModel
Imports System.ServiceModel.Web
Imports BL

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IWSRestCoc" in both code and config file together.
<ServiceContract()>
Public Interface IWSRestCoc

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Function ListaOrdenes() As ArrayList

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Sub insertar(nombreUsuario As String, fechas As DateTime, Estado As String, Identificador As Integer)

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Sub Eliminar(id As String)

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Sub actualizar(nombre As String, fecha As DateTime, estado As String, ide As Integer)

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Function ListaActiva() As List(Of BLOrden)

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Function Buscar(ide As String) As BLOrden

End Interface
