Imports System.IO
Imports System.Text

' This file is a component of the picoBench application.
' The original author is Chip Schnarel

' License:
' This code is free to use, change, improve, even sell!  All we ask for is two things:
' 1. That you give Chip Schnarel credit for the original code,
' 2. If you sell or give it away, you do so under the same license so others can do the same thing.
' More at http://creativecommons.org/licenses/by-sa/3.0/

Public Class picoBenchData
    ' This is the structure where the current weather data is stored.
    ' It should be updated with each new incoming sensor message
    Private _pBData As New picoBenchDataStruct

    '============================================================
    ' This method initializes the structure to display "No data available"
    ' This one is called when this class object is first instantiated.
    '============================================================
    Public Sub New()
        _pBData.VPVolts = "--"
        _pBData.CPAmps = "--"
        _pBData.PSVolts = "--"
        _pBData.PSAmps = "--"
        _pBData.PSWatts = "--"
        _pBData.Heart = 0
    End Sub

    '============================================================
    ' This method initializes the structure to display "No data available"
    ' This one can be called anytime the data needs to be reset.
    '============================================================
    Public Sub Initialize()
        _pBData.VPVolts = "--"
        _pBData.CPAmps = "--"
        _pBData.PSVolts = "--"
        _pBData.PSAmps = "--"
        _pBData.PSWatts = "--"
        _pBData.Heart = 0
    End Sub

    '============================================================
    ' This method takes in a weather data message from the sensors
    ' and fills in the weather data structure with values converted
    ' to the appropriate units.  It also creates values derived from the
    ' base sensor data such as Wind Chill, Dew Point, Minimums and Maximums.
    '============================================================
    Public Sub Parse(ByVal msgString As String)
        'sample message: 63495226205,!,3,EImImI,2.56,30.7,3.28,123.4,*
        Dim valueArray As String() = msgString.Split(New [Char]() {","c})
        Dim arrayLength As Integer = valueArray.Length()

        'Validate the message
        If arrayLength = 9 Then
            If valueArray(1) = "!" And valueArray(2) = "3" Then
                'should now have an array like the following
                '{"63495226205", "!", "3", "EImImI", "2.56", "30.7", "3.28", "123.4", "*"}

                'fill in the struct based on the array data
                _pBData.Status = valueArray(3)
                _pBData.VPVolts = valueArray(4)
                _pBData.CPAmps = valueArray(5)
                _pBData.PSVolts = valueArray(6)
                _pBData.PSAmps = valueArray(7)
                '_pBData.PSWatts = valueArray(8)
                _pBData.PSWatts = (Val(valueArray(6)) * Val(valueArray(7))).ToString("F1")
                _pBData.Heart = 0
            Else
                MsgBox("Oops.  Got a bad message. " & msgString)
            End If
        Else
            MsgBox("Oops.  Got a bad message. " & msgString)
        End If

    End Sub

    '============================================================
    ' General accessor methods
    '============================================================
    ReadOnly Property GetpBData() As picoBenchDataStruct
        Get
            GetpBData = _pBData
        End Get
    End Property
    ReadOnly Property GetStatus()
        Get
            GetStatus = _pBData.Status
        End Get
    End Property
    ReadOnly Property GetVPVolts()
        Get
            GetVPVolts = _pBData.VPVolts
        End Get
    End Property
    ReadOnly Property GetCPAmps()
        Get
            GetCPAmps = _pBData.CPAmps
        End Get
    End Property
    ReadOnly Property GetPSVolts()
        Get
            GetPSVolts = _pBData.PSVolts
        End Get
    End Property
    ReadOnly Property GetPSAmps()
        Get
            GetPSAmps = _pBData.PSAmps
        End Get
    End Property
    ReadOnly Property GetPSWatts()
        Get
            GetPSWatts = _pBData.PSWatts
        End Get
    End Property
    ReadOnly Property GetHeart()
        Get
            GetHeart = _pBData.Heart
        End Get
    End Property

    Sub IncHeart()
        _pBData.Heart += 1
    End Sub

End Class

