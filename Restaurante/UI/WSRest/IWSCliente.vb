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
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Sub registrarCliente(nombre As String, nombreUsuario As String, correo As String, direccion As String,
                         contrasenna As String)

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Function platosActivos() As List(Of Plato)

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Function buscarPlatoPorNombre(Nombre As String) As List(Of Plato)

    <OperationContract()>
    <WebGet(RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json)>
    Sub iniciarSesionCliente(Email As String, Contrasenna As String)


End Interface
