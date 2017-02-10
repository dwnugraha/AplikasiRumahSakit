﻿Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class detail
    Dim conn As New MySqlConnection
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader


    Private Sub detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("Data Source=localhost;userid=root;database=rumah_sakit;password=")
        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Error in connection, please check Database and connection server.")
        End Try


        Dim StrSql1 As String = "SELECT kd_dokter FROM dokter"
        Dim cmd1 As New MySqlCommand(StrSql1, dbconn)
        Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(cmd1)
        Dim dt1 As New DataTable("dokter")

        da1.Fill(dt1)

        dbread = cmd1.ExecuteReader()

        While dbread.Read
            kodedokter.Items.Add(dbread("kd_dokter"))
        End While
        dbread.Close()

        '        If dt1.Rows.Count > 0 Then
        '
        'kodedokter.DataSource = dt1
        'kodedokter.DisplayMember = "kd_dokter"
        'kodedokter.ValueMember = "kd_dokter"

        '        End If



        Dim StrSql3 As String = "SELECT kd_pesan FROM pesan"
        Dim cmd3 As New MySqlCommand(StrSql3, dbconn)
        Dim da3 As MySqlDataAdapter = New MySqlDataAdapter(cmd3)
        Dim dt3 As New DataTable("pesan")

        da3.Fill(dt3)
        dbread = cmd3.ExecuteReader()

        While dbread.Read
            ComboBox1.Items.Add(dbread("kd_pesan"))
        End While
        dbread.Close()

        'If dt3.Rows.Count > 0 Then

        'ComboBox1.DataSource = dt3
        ' ComboBox1.Text = " "
        'ComboBox1.DisplayMember = "kd_pesan"
        'ComboBox1.ValueMember = "kd_pesan"
        'End If

        sql = "SELECT * FROM detail_biaya"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("no_reg"), dbread("kd_pasien"), dbread("keluhan"), dbread("kd_dokter"), dbread("kd_ruang"), dbread("lama_inap").ToString, dbread("biaya_obat").ToString, dbread("biaya_dokter").ToString, dbread("biaya_ruang").ToString, dbread("total_biaya").ToString)
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
        Me.Close()
        menuutama.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT * FROM dokter where kd_dokter='" & CStr(kodedokter.SelectedItem) & "'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                biayadokter.Text = dbread("tarif")
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try

        sql = "SELECT * FROM ruang where kd_ruang='" & TextBox3.Text & "'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                biayaruang.Text = dbread("harga")
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
        If CInt(lama.Text) >= 1 Then
            total.Text = CInt(lama.Text) * (CInt(biayadokter.Text) + CInt(biayaobat.Text) + CInt(biayaruang.Text))
        ElseIf CInt(lama.Text) = 0 Then
            total.Text = (CInt(biayadokter.Text) + CInt(biayaobat.Text) + CInt(biayaruang.Text))
        Else
            MsgBox("Nilai yang adna masukkan salah!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        kembali.Text = CInt(bayar.Text) - CInt(total.Text)
        sql = "INSERT INTO detail_biaya(no_reg, kd_pasien, kd_dokter, kd_ruang, keluhan, lama_inap, biaya_obat, biaya_dokter, biaya_ruang, total_biaya) VALUES('" & no_reg.Text & "','" &
            TextBox2.Text & "','" & CStr(kodedokter.SelectedItem) & "','" & TextBox3.Text & "','" & TextBox1.Text & "','" & lama.Text & "','" & biayaobat.Text & "','" & biayadokter.Text & "','" & biayaruang.Text & "','" & total.Text & "')"
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
        sql = "delete FROM pesan where kd_pesan='" & ComboBox1.SelectedItem & "'"
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
        DataGridView1.Rows.Clear()
        sql = "SELECT * FROM detail_biaya"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("no_reg"), dbread("kd_pasien"), dbread("keluhan"), dbread("kd_dokter"), dbread("kd_ruang"), dbread("lama_inap").ToString, dbread("biaya_obat").ToString, dbread("biaya_dokter").ToString, dbread("biaya_ruang").ToString, dbread("total_biaya").ToString)
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
        sql = "delete FROM pesan where kd_pesan='" & ComboBox1.SelectedItem.ToString & "'"
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
        sql = "delete FROM pasien where kd_pasien='" & TextBox2.Text & "'"
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
        pesan.ComboBox2.Items.Add(TextBox3.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sql = "update detail_biaya set kd_pasien='" & TextBox2.Text & "', kd_dokter='" & kodedokter.SelectedValue & "', kd_ruang='" & TextBox3.Text & "', keluhan='" &
            TextBox1.Text & "', lama_inap='" & lama.Text & "', biaya_obat='" & biayaobat.Text & "', biaya_dokter='" & biayadokter.Text & "', biaya_ruang='" & biayaruang.Text & "', total_biaya='" & total.Text & "' where no_reg='" & no_reg.Text & "'"

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
        sql = "SELECT * FROM detail_biaya"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("no_reg"), dbread("kd_pasien"), dbread("keluhan"), dbread("kd_dokter"), dbread("kd_ruang"), dbread("lama_inap").ToString, dbread("biaya_obat").ToString, dbread("biaya_dokter").ToString, dbread("biaya_ruang").ToString, dbread("total_biaya").ToString)
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "delete FROM detail_biaya where no_reg='" & no_reg.Text & "'"
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
        sql = "SELECT * FROM detail_biaya"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("no_reg"), dbread("kd_pasien"), dbread("keluhan"), dbread("kd_dokter"), dbread("kd_ruang"), dbread("lama_inap").ToString, dbread("biaya_obat").ToString, dbread("biaya_dokter").ToString, dbread("biaya_ruang").ToString, dbread("total_biaya").ToString)
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DataGridView1.Rows.Clear()
        sql = "SELECT * FROM detail_biaya"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("no_reg"), dbread("kd_pasien"), dbread("keluhan"), dbread("kd_dokter"), dbread("kd_ruang"), dbread("lama_inap").ToString, dbread("biaya_obat").ToString, dbread("biaya_dokter").ToString, dbread("biaya_ruang").ToString, dbread("total_biaya").ToString)
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
        Using stream As New FileStream(folderPath & "Detail Biaya.pdf",
        FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        sql = "SELECT * FROM pesan where kd_pesan='" & ComboBox1.SelectedItem.ToString & "'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                TextBox2.Text = dbread("kd_pasien")
                TextBox3.Text = dbread("kd_ruang")
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