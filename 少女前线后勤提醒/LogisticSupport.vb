Public Class LogisticSupport
    Private name As String
    Private hour As Integer
    Private minute As Integer
    Private manpower As Integer
    Private ammo As Integer
    Private ration As Integer
    Private part As Integer
    Private doll As Boolean
    Private equipment As Boolean
    Private production As Boolean
    Private restore As Boolean
    Private token As Boolean

    Public Sub New(_name As String, _hour As Integer, _minute As Integer,
                   _manpower As Integer, _ammo As Integer, _ration As Integer, _part As Integer,
                   _doll As Boolean, _equipment As Boolean, _production As Boolean, _restore As Boolean, _token As Boolean)
        name = _name
        hour = _hour
        minute = _minute
        manpower = _manpower
        ammo = _ammo
        ration = _ration
        part = _part
        doll = _doll
        equipment = _equipment
        production = _production
        restore = _restore
        token = _token
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

    Public Function getManpower() As Integer
        Return manpower
    End Function

    Public Function getAmmo() As Integer
        Return ammo
    End Function

    Public Function getRation() As Integer
        Return ration
    End Function

    Public Function getPart() As Integer
        Return part
    End Function

    Public Function getDoll() As Boolean
        Return doll
    End Function

    Public Function getEquipment() As Boolean
        Return equipment
    End Function

    Public Function getProduction() As Boolean
        Return production
    End Function

    Public Function getRestore() As Boolean
        Return restore
    End Function

    Public Function getToken() As Boolean
        Return token
    End Function
End Class
