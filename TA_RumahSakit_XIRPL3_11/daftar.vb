Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class daftar
    Dim conn As New MySqlConnection
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader

    Private Sub daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("Data Source=localhost;userid=root;database=rumah_sakit;password=")
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Error in connection, please check Database and connection server.")
        End Try

        sql = "SELECT * FROM pegawai"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("kd_pegawai"), dbread("nm_pegawai"), dbread("jabatan"), dbread("no_telp"), dbread("alamat"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "INSERT INTO login(user, pass) VALUES('" & user.Text & "','" & pass.Text & "')"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in saving to Database. Error is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try


        sql = "INSERT INTO pegawai(kd_pegawai, nm_pegawai, jabatan, no_telp, alamat) VALUES('" & kd_pegawai.Text & "','" & nama.Text & "','" & jabatan.Text & "','" & no_telp.Text & "','" & alamat.Text & "')"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in saving to Database. Error is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try
        MsgBox("Data telah tersimpan")

        DataGridView1.Rows.Clear()
        sql = "SELECT * FROM pegawai"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("kd_pegawai"), dbread("nm_pegawai"), dbread("jabatan"), dbread("no_telp"), dbread("alamat"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "update pegawai set nm_pegawai='" & nama.Text & "', jabatan='" & jabatan.Text & "', no_telp='" & no_telp.Text & "', alamat='" & alamat.Text & "' where kd_pegawai='" & kd_pegawai.Text & "'"
        sql = "update login set username='" & user.Text & "' where kd_pegawai='" & kd_pegawai.Text & "'"
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

        DataGridView1.Rows.Clear()
        sql = "SELECT * FROM pegawai"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("kd_pegawai"), dbread("nm_pegawai"), dbread("jabatan"), dbread("no_telp"), dbread("alamat"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "delete FROM pegawai where kd_pegawai='" & kd_pegawai.Text & "'"
        sql = "delete FROM login where kd_pegawai='" & kd_pegawai.Text & "'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
        MsgBox("Data sudah dihapus")
        DataGridView1.Rows.Clear()
        sql = "SELECT * FROM pegawai"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("kd_pegawai"), dbread("nm_pegawai"), dbread("jabatan"), dbread("no_telp"), dbread("alamat"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 30
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1
        'Adding Header row
        For Each column As DataGridViewColumn In DataGridView1.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(180, 30, 39)
            pdfTable.AddCell(cell)
        Next
        'Adding DataRow
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                'pdfTable.AddCell(cell.Value.ToString())
                If cell.Value <> "" Then
                    'MsgBox(cell.Value)
                    pdfTable.AddCell(cell.Value)
                End If
            Next
        Next
        'Exporting to PDF
        Dim folderPath As String = "C:\Report Rumah Sakit\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using stream As New FileStream(folderPath & "Daftar Pegawai.pdf",
        FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DataGridView1.Rows.Clear()
        sql = "SELECT * FROM pegawai"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("kd_pegawai"), dbread("nm_pegawai"), dbread("jabatan"), dbread("no_telp"), dbread("alamat"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub
End Class