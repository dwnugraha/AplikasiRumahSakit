Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class lupa
    Dim conn As New MySqlConnection
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "update login set pass='" & TextBox2.Text & "' where user='" & TextBox1.Text & "'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in saving to Database. Error is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try
        MsgBox("Data sudah diperbarui")
    End Sub

    Private Sub lupa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("Data Source=localhost;userid=root;database=rumah_sakit;password=")
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Error in connection, please check Database and connection server.")
        End Try
    End Sub
End Class