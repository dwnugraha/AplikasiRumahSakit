Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class login
    Dim conn As New MySqlConnection
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT * FROM login WHERE user = '" + TextBox1.Text + "' AND pass= '" + TextBox2.Text + "'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            If dbread.HasRows = 0 Then
                MsgBox("Username atau Password ada yang salah !", MsgBoxStyle.Exclamation, "Error Login")
            Else
                MsgBox("Login Berhasil, Selamat Datang ! ", MsgBoxStyle.Information, "Successfull Login")

                dbread.Read()
                menuutama.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error in saving to Database. Error is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("Data Source=localhost;userid=root;database=rumah_sakit;password=")
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Error in connection, please check Database and connection server.")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        daftar.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        lupa.Show()
        Me.Hide()
    End Sub

End Class
