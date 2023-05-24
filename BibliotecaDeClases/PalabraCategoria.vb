Public Class PalabraCategoria
    Implements IEquatable(Of PalabraCategoria)

    Public Property Palabra As String
    Public Property Categoria As String
    Public Property Dificultad As String

    Public Sub New()
    End Sub

    Public Sub New(palabra As String, categoria As String, dificultad As String)
        Me.Palabra = palabra
        Me.Categoria = categoria
        Me.Dificultad = dificultad
    End Sub




    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, PalabraCategoria))
    End Function

    Public Overloads Function Equals(other As PalabraCategoria) As Boolean Implements IEquatable(Of PalabraCategoria).Equals
        Return other IsNot Nothing AndAlso
               Palabra = other.Palabra AndAlso
               Categoria = other.Categoria AndAlso
               Dificultad = other.Dificultad
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (Palabra, Categoria, Dificultad).GetHashCode()
    End Function

    Public Shared Operator =(left As PalabraCategoria, right As PalabraCategoria) As Boolean
        Return EqualityComparer(Of PalabraCategoria).Default.Equals(left, right)
    End Operator

    Public Shared Operator <>(left As PalabraCategoria, right As PalabraCategoria) As Boolean
        Return Not left = right
    End Operator
End Class
