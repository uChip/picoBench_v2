' This file is a component of the picoBench application.
' The original author is Chip Schnarel

' License:
' This code is free to use, change, improve, even sell!  All we ask for is two things:
' 1. That you give Chip Schnarel credit for the original code,
' 2. If you sell or give it away, you do so under the same license so others can do the same thing.
' More at http://creativecommons.org/licenses/by-sa/3.0/

Imports System.IO
Imports System.Runtime.Serialization.Formatters
Imports System.Environment

Public Class SettingsClass
    Private theSettingsData As SettingsStruct
    Private Const settingsFilename As String = "pBenchSettings.txt"

    '============================================================
    'This method sets each of the settings values to its default
    '============================================================
    Public Sub SetDefaults()
        'load the default values into the struct
        Dim thePath As String
        thePath = Path.Combine(GetFolderPath(SpecialFolder.MyDocuments), Application.ProductName)
        theSettingsData.VPLogFilePath = Path.Combine(thePath, "VPLog.txt")
        theSettingsData.CPLogFilePath = Path.Combine(thePath, "CPLog.txt")
        theSettingsData.PSLogFilePath = Path.Combine(thePath, "PSLog.txt")
        theSettingsData.appWindowLoc = FrontPanel.Location
        theSettingsData.COMPort = ""
    End Sub

    '============================================================
    'This method loads the settings data from a file into the settings structure.
    'If the file does not yet exist, one is created and the default
    'values are written to the file and also filled into the struct
    '============================================================
    Public Sub Load()
        Dim filePath As String = settingsFilename
        'filePath = Path.Combine(GetFolderPath(SpecialFolder.ApplicationData), Application.CompanyName)
        'filePath = Path.Combine(filePath, Application.ProductName)
        'filePath = Path.Combine(filePath, "pBConfig.txt")

        'If File.Exists(filePath) Then
        If False Then
            Dim stream As FileStream = File.OpenRead(filePath)

            Dim theBinFormatter As New Binary.BinaryFormatter
            theSettingsData = theBinFormatter.Deserialize(stream)
            stream.Close()
        Else
            Me.SetDefaults()

            'then create the file and write the default structure out.
            Dim stream As FileStream = File.Create(filePath)
            Dim theBinFormatter As New Binary.BinaryFormatter()
            theBinFormatter.Serialize(stream, theSettingsData)

            stream.Close()
        End If

    End Sub

    '============================================================
    'This method saves the settings data out to a file so that it can be read
    'in again on the next program launch
    '============================================================
    Public Sub Save()
        theSettingsData.appWindowLoc = FrontPanel.Location

        Dim stream As FileStream = File.Create(settingsFilename)

        Dim BinFormatter As New Binary.BinaryFormatter()
        BinFormatter.Serialize(stream, theSettingsData)

        stream.Close()
    End Sub

    '============================================================
    'This method shows the dialog that allows the user to change the settings.
    'It first sets all the controls to the current settings values,
    'then it displays the dialog, then it reads the control values 
    'and stores them as settings values.
    '============================================================
    Public Sub Edit()
        SetupForm.ShowDialog()
    End Sub

    '============================================================
    'Accessor methods
    '============================================================
    ReadOnly Property GetAppWindowLoc()
        Get
            GetAppWindowLoc = theSettingsData.appWindowLoc
        End Get
    End Property
    ReadOnly Property GetVPLogFilePath()
        Get
            GetVPLogFilePath = theSettingsData.VPLogFilePath
        End Get
    End Property
    ReadOnly Property GetCPLogFilePath()
        Get
            GetCPLogFilePath = theSettingsData.CPLogFilePath
        End Get
    End Property
    ReadOnly Property GetPSLogFilePath()
        Get
            GetPSLogFilePath = theSettingsData.PSLogFilePath
        End Get
    End Property
    ReadOnly Property GetCOMPort()
        Get
            GetCOMPort = theSettingsData.COMPort
        End Get
    End Property
    Sub SetCOMPort(comPort As String)
        theSettingsData.COMPort = comPort
    End Sub


    Sub SetVPLogFilePath(pathString As String)
        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(pathString)) Then
            'if it is then the path is okay
            theSettingsData.VPLogFilePath = pathString
        Else
            MsgBox("Log file directory, " & pathString & ", does not exist.  Disabling logging.")
            'FrontPanel.VPLogEnabled = False
        End If
    End Sub
    Sub SetCPLogFilePath(pathString As String)
        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(pathString)) Then
            'if it is then the path is okay
            theSettingsData.CPLogFilePath = pathString
        Else
            MsgBox("Log file directory, " & pathString & ", does not exist.  Disabling logging.")
            'FrontPanel.CPLogEnabled = False
        End If
    End Sub
    Sub SetPSLogFilePath(pathString As String)
        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(pathString)) Then
            'if it is then the path is okay
            theSettingsData.PSLogFilePath = pathString
        Else
            MsgBox("Log file directory, " & pathString & ", does not exist.  Disabling logging.")
            'FrontPanel.VPLogEnabled = False
        End If
    End Sub

End Class
