Public Class LogisticSupport
    Private name As String
    Private hour As Integer
    Private minute As Integer

    Public Sub New(_name As String, _hour As Integer, _minute As Integer)
        name = _name
        hour = _hour
        minute = _minute
    End Sub

    Public Function getName() As String
        Return name
    End Function

    Public Function getHour() As Integer
        Return hour
    End Function

    Public Function getMinute() As Integer
        Return minute
    End Function

    Public Function getTime() As Double
        Dim time As Double
        time = hour + (minute / 60)

        Return time
    End Function
End Class
