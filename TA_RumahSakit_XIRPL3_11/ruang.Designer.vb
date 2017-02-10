<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ruang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ruang))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.kd_ruang = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jenis = New System.Windows.Forms.ComboBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nm_ruang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Nb : Ubah dan Hapus  sesuai kode ruang"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(64, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 85
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(64, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "Ubah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode, Me.nm_ruang, Me.jns, Me.hrg})
        Me.DataGridView1.Location = New System.Drawing.Point(244, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(394, 233)
        Me.DataGridView1.TabIndex = 83
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Jenis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Nama Ruang"
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(99, 157)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(121, 20)
        Me.harga.TabIndex = 76
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(99, 101)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(121, 20)
        Me.nama.TabIndex = 75
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'kd_ruang
        '
        Me.kd_ruang.Location = New System.Drawing.Point(99, 75)
        Me.kd_ruang.Name = "kd_ruang"
        Me.kd_ruang.Size = New System.Drawing.Size(121, 20)
        Me.kd_ruang.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Kode Ruang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 59)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "RUANG"
        '
        'jenis
        '
        Me.jenis.FormattingEnabled = True
        Me.jenis.Items.AddRange(New Object() {"Kelas 1", "Kelas 2", "Kelas 3", "VIP", "VVIP"})
        Me.jenis.Location = New System.Drawing.Point(99, 130)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(121, 21)
        Me.jenis.TabIndex = 90
        Me.jenis.Text = "Pilih"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(540, 315)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(98, 23)
        Me.Button9.TabIndex = 114
        Me.Button9.Text = "Export to PDF"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(459, 315)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 113
        Me.Button8.Text = "Lihat Semua"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'kode
        '
        Me.kode.HeaderText = "Kode Ruang"
        Me.kode.Name = "kode"
        '
        'nm_ruang
        '
        Me.nm_ruang.HeaderText = "Nama Ruang"
        Me.nm_ruang.Name = "nm_ruang"
        '
        'jns
        '
        Me.jns.HeaderText = "Jenis"
        Me.jns.Name = "jns"
        '
        'hrg
        '
        Me.hrg.HeaderText = "Harga"
        Me.hrg.Name = "hrg"
        '
        'ruang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(650, 342)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.jenis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.kd_ruang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ruang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ruang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents harga As System.Windows.Forms.TextBox
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents kd_ruang As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents jenis As System.Windows.Forms.ComboBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nm_ruang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jns As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hrg As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
