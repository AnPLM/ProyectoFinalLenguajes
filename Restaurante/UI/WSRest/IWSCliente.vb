Imports System.ServiceModel
Imports System.ServiceModel.Web
Imports BL

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IWSCliente" in both code and config file together.
<ServiceContract()>
Public Interface IWSCliente

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Function obtenerPedidosPorUsuario(nombre_usuario As String) As List(Of BLListaPedido)

    <OperationContract()>
    <WebGet()>
    Sub registrarCliente(nombre As String, nombreUsuario As String, correo As String, direccion As String,
                         contrasenna As String)

End Interface
