Public Class TOPlato

    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Precio As Double
    Public Property Fotografia As String
    Public Property Habilitado As Boolean

    Sub New()

    End Sub

    Sub New(nombre As String, descripcion As String, precio As Double, fotografia As String, habilitado As Boolean)
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Precio = precio
        Me.Fotografia = fotografia
        Me.Habilitado = habilitado
    End Sub


End Class
