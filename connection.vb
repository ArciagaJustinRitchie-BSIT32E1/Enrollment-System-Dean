Imports System.Data.OleDb
Module DbConnection

    Public cn As New OleDbConnection
    Public dset As New DataSet
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String
    Public da As OleDbDataAdapter


    Public Sub conn()
        cn.Close()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\CES_Database.accdb"
        cn.Open()
        ' MsgBox("Connection Success", vbInformation)

    End Sub

    Public Function QueryData(line) As OleDbDataReader
        cmd = New OleDbCommand(line, cn)
        Return cmd.ExecuteReader
    End Function

End Module