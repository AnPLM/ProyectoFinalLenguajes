Public Class TOPlato

    Public Property Codigo As String
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Precio As Double
    Public Property Fotografia As String
    Public Property Habilitado As Integer

    Sub New()

    End Sub

    Sub New(codigo As String, nombre As String, descripcion As String, precio As Double, fotografia As String, habilitado As Integer)
        Me.Codigo = codigo
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

    Sub New(codigo As String, a As Integer)
        Me.Codigo = codigo
    End Sub


End Class
