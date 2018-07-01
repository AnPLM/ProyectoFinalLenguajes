Public Class TOPlato

    Public Property Identificador As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Precio As Double
    Public Property Fotografia As String
    Public Property Habilitado As Integer

    Sub New()

    End Sub

    Sub New(identificador As Integer, nombre As String, descripcion As String, precio As Double, fotografia As String, habilitado As Integer)
        Me.Identificador = identificador
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Precio = precio
        Me.Fotografia = fotografia
        Me.Habilitado = habilitado
    End Sub

    Sub New(nombre As String, descripcion As String, precio As Double, fotografia As String, habilitado As Integer)
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Precio = precio
        Me.Fotografia = fotografia
        Me.Habilitado = habilitado
    End Sub
    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub


End Class
