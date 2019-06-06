Public Class LogisticFilter
    Private logistic As New List(Of LogisticSupport)
    Private filteredLogistic As New List(Of LogisticSupport)
    Private mw As Integer
    Private aw As Integer
    Private rw As Integer
    Private pw As Integer
    Private mplmt As Integer
    Private Tr As Double
    Private Tm As Double
    Private item1 As Integer
    Private item2 As Integer

    Private Sub setLogisticData()
        logistic.Clear()

        For i = 0 To frmMain.arr_Logistic.Count - 1
            logistic.Add(frmMain.arr_Logistic(i))
        Next
    End Sub

    Public Function getList(_mw As Integer, _aw As Integer, _rw As Integer, _pw As Integer,
                            _item1 As Integer, _item2 As Integer, _mplmt As Integer,
                            _Tr As Double, _Tm As Double) As List(Of LogisticSupport)
        setLogisticData()
        mw = _mw
        aw = _aw
        rw = _rw
        pw = _pw
        item1 = _item1
        item2 = _item2
        mplmt = _mplmt
        Tr = _Tr
        Tm = _Tm
        getRanking()
        Return filteredLogistic
    End Function

    Private Function obeyLimit(data As LogisticSupport) As Boolean
        Dim MapLimit As Double = Me.mplmt
        Dim s1 As Integer = Integer.Parse(data.getName.Substring(0, 1))
        Dim s2 As String = data.getName.Substring(1, 1)
        Dim mplmt = False

        If MapLimit = 4 Then
            MapLimit = 4.5
        Else
            If MapLimit < 4 Then
                MapLimit = MapLimit + 1
            End If
        End If

        If s1 = 0 Then
            If MapLimit >= 4.5 Then
                mplmt = True
            End If
        ElseIf s1 = 1 Then
            If s2 = "-" Then
                mplmt = True
            Else
                s1 = 10 + Integer.Parse(s2)
                If MapLimit >= s1 Then
                    mplmt = True
                End If
            End If
        Else
            If MapLimit >= s1 Then
                mplmt = True
            End If
        End If

        If data.getTime >= Tr And data.getTime <= Tm And mplmt Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function haveItem(data As LogisticSupport) As Boolean
        Dim validNum As Integer = 0

        If item1 = item2 Then
            If item1 = 0 Then
                validNum = validNum + 2
            Else
                If data.getDoll = True And item1 = 1 Then '人形契约
                    validNum = validNum + 2
                ElseIf data.getEquipment = True And item1 = 2 Then '装备契约
                    validNum = validNum + 2
                ElseIf data.getProduction = True And item1 = 3 Then '快速建造
                    validNum = validNum + 2
                ElseIf data.getRestore = True And item1 = 4 Then '快速修复
                    validNum = validNum + 2
                ElseIf data.getToken = True And item1 = 5 Then '采购币
                    validNum = validNum + 2
                End If
            End If
        Else
            If item1 = 0 Or item2 = 0 Then
                validNum = validNum + 1
            End If

            If data.getDoll = True And (item1 = 1 Or item2 = 1) Then
                validNum = validNum + 1
            End If

            If data.getEquipment = True And (item1 = 2 Or item2 = 2) Then
                validNum = validNum + 1
            End If

            If data.getProduction = True And (item1 = 3 Or item2 = 3) Then
                validNum = validNum + 1
            End If

            If data.getRestore = True And (item1 = 4 Or item2 = 4) Then
                validNum = validNum + 1
            End If

            If data.getToken = True And (item1 = 5 Or item2 = 5) Then
                validNum = validNum + 1
            End If
        End If

        If validNum = 2 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub getRanking()
        logistic.Sort(Function(a, b) b.getResWeight(mw, aw, rw, pw).CompareTo(a.getResWeight(mw, aw, rw, pw)))

        filteredLogistic.Clear()
        Dim allEntry As Integer = 0

        For i = 0 To logistic.Count - 1
            If allEntry < 10 Then
                If haveItem(logistic(i)) And obeyLimit(logistic(i)) Then
                    filteredLogistic.Add(logistic(i))
                    allEntry = allEntry + 1
                End If
            End If
        Next i
    End Sub
End Class
