Public Class Rectangle
    Private intLength As Integer
    Private intWidth As Integer
    Public Property Length As Integer
        Get
            Return intLength
        End Get
        Set(value As Integer)
            If intLength > 0 Then
                Length = intLength
            Else
                Length = 0
            End If
        End Set
    End Property

    Public Property Width As Integer
        Get
            Return intWidth
        End Get
        Set(value As Integer)
            If intWidth > 0 Then
                Width = intWidth
            Else
                Width = 0
            End If
        End Set
    End Property

    Public Sub New()
        intLength = 0
        intWidth = 0
    End Sub

    Public Function GetArea() As Integer
        Return intLength * intWidth
    End Function
End Class
