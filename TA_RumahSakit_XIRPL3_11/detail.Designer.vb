<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detail))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nm_pasien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.almt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.umr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dokter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totbiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lama = New System.Windows.Forms.TextBox()
        Me.biayaobat = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.no_reg = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kodedokter = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.biayadokter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.biayaruang = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.kembali = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bayar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Hari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Nb : Ubah dan Hapus  sesuai no. registrasi"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(565, 126)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 85
        Me.Button4.Text = "Bayar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(360, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "Total"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode, Me.nm_pasien, Me.jk, Me.almt, Me.umr, Me.inap, Me.obat, Me.dokter, Me.ruang, Me.totbiaya})
        Me.DataGridView1.Location = New System.Drawing.Point(246, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(394, 167)
        Me.DataGridView1.TabIndex = 83
        '
        'kode
        '
        Me.kode.HeaderText = "No. Reg"
        Me.kode.Name = "kode"
        '
        'nm_pasien
        '
        Me.nm_pasien.HeaderText = "Kode Pasien"
        Me.nm_pasien.Name = "nm_pasien"
        '
        'jk
        '
        Me.jk.HeaderText = "Keluhan"
        Me.jk.Name = "jk"
        '
        'almt
        '
        Me.almt.HeaderText = "Kode Dokter"
        Me.almt.Name = "almt"
        '
        'umr
        '
        Me.umr.HeaderText = "Kode Ruang"
        Me.umr.Name = "umr"
        '
        'inap
        '
        Me.inap.HeaderText = "Lama Inap"
        Me.inap.Name = "inap"
        '
        'obat
        '
        Me.obat.HeaderText = "Biaya Obat"
        Me.obat.Name = "obat"
        '
        'dokter
        '
        Me.dokter.HeaderText = "Biaya Dokter"
        Me.dokter.Name = "dokter"
        '
        'ruang
        '
        Me.ruang.HeaderText = "Biaya Ruang"
        Me.ruang.Name = "ruang"
        '
        'totbiaya
        '
        Me.totbiaya.HeaderText = "Total Biaya"
        Me.totbiaya.Name = "totbiaya"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(151, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Lama Inap"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(240, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Biaya Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Kode Pasien"
        '
        'lama
        '
        Me.lama.Location = New System.Drawing.Point(314, 71)
        Me.lama.Name = "lama"
        Me.lama.Size = New System.Drawing.Size(40, 20)
        Me.lama.TabIndex = 77
        '
        'biayaobat
        '
        Me.biayaobat.Location = New System.Drawing.Point(314, 98)
        Me.biayaobat.Name = "biayaobat"
        Me.biayaobat.Size = New System.Drawing.Size(121, 20)
        Me.biayaobat.TabIndex = 76
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(238, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Pilih"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'no_reg
        '
        Me.no_reg.Location = New System.Drawing.Point(105, 98)
        Me.no_reg.Name = "no_reg"
        Me.no_reg.Size = New System.Drawing.Size(121, 20)
        Me.no_reg.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "No. Registrasi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 59)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "DETAIL BAYAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Kode Dokter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Kode Ruang"
        '
        'kodedokter
        '
        Me.kodedokter.FormattingEnabled = True
        Me.kodedokter.Location = New System.Drawing.Point(105, 151)
        Me.kodedokter.Name = "kodedokter"
        Me.kodedokter.Size = New System.Drawing.Size(121, 21)
        Me.kodedokter.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(240, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Biaya Dokter"
        '
        'biayadokter
        '
        Me.biayadokter.Location = New System.Drawing.Point(314, 125)
        Me.biayadokter.Name = "biayadokter"
        Me.biayadokter.Size = New System.Drawing.Size(121, 20)
        Me.biayadokter.TabIndex = 96
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(240, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Biaya Ruang"
        '
        'biayaruang
        '
        Me.biayaruang.Location = New System.Drawing.Point(314, 152)
        Me.biayaruang.Name = "biayaruang"
        Me.biayaruang.Size = New System.Drawing.Size(121, 20)
        Me.biayaruang.TabIndex = 98
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(445, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Uang Kembali"
        '
        'kembali
        '
        Me.kembali.Location = New System.Drawing.Point(519, 155)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(121, 20)
        Me.kembali.TabIndex = 104
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(445, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "Uang Bayar"
        '
        'bayar
        '
        Me.bayar.Location = New System.Drawing.Point(519, 100)
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(121, 20)
        Me.bayar.TabIndex = 102
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(445, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Total Biaya"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(519, 71)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(121, 20)
        Me.total.TabIndex = 100
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 207)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 107
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 210)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 106
        Me.Label15.Text = "Keluhan"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(21, 294)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 110
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(21, 265)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 109
        Me.Button6.Text = "Ubah"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(151, 294)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 111
        Me.Button8.Text = "Lihat Semua"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(128, 265)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(98, 23)
        Me.Button9.TabIndex = 112
        Me.Button9.Text = "Export to PDF"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Kode Pesan"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 114
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(105, 125)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 115
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(105, 178)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 116
        '
        'detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(661, 378)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.bayar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.biayaruang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.biayadokter)
        Me.Controls.Add(Me.kodedokter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lama)
        Me.Controls.Add(Me.biayaobat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.no_reg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Name = "detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lama As System.Windows.Forms.TextBox
    Friend WithEvents biayaobat As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents no_reg As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents kodedokter As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents biayadokter As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents biayaruang As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents kembali As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents bayar As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nm_pasien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents almt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents umr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dokter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totbiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
