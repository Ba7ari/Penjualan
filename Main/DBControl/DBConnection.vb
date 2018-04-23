Option Strict On
Imports System.Data.OleDb
Public Class DBConnection
    Private mConn As OleDbConnection
    Private strConn As String = gM.connString
    Private mCommand As OleDbCommand
    Private mReader As OleDbDataReader
    Private mAdapter As OleDbDataAdapter

    Public Sub New()
        mConn = New OleDbConnection(strConn)
    End Sub

    Private Function conn() As OleDbConnection
        Try
            If mConn.State <> ConnectionState.Closed Then mConn.Close()
            mConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
        Return mConn
    End Function

    Public Function exeNonQuery(ByVal sql As String) As Boolean
        Try
            mCommand = New OleDbCommand(sql, conn)
            If mCommand.ExecuteNonQuery = 1 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function exeReader(ByVal sql As String) As OleDbDataReader
        mCommand = New OleDbCommand(sql, conn)
        mReader = mCommand.ExecuteReader
        Return mReader
    End Function

    Public Function adapter(ByVal sql As String) As OleDbDataAdapter
        mAdapter = New OleDbDataAdapter(sql, conn)
        Return mAdapter
    End Function



End Class
