<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dokter
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nm_dokter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spsls = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tarif = New System.Windows.Forms.TextBox()
        Me.no_telp = New System.Windows.Forms.TextBox()
        Me.spesialis = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.kd_dokter = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-46, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 59)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "DOKTER"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode, Me.nm_dokter, Me.spsls, Me.nomer, Me.trf})
        Me.DataGridView1.Location = New System.Drawing.Point(244, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(394, 233)
        Me.DataGridView1.TabIndex = 47
        '
        'kode
        '
        Me.kode.HeaderText = "Kode Dokter"
        Me.kode.Name = "kode"
        '
        'nm_dokter
        '
        Me.nm_dokter.HeaderText = "Nama Dokter"
        Me.nm_dokter.Name = "nm_dokter"
        '
        'spsls
        '
        Me.spsls.HeaderText = "Spesialis"
        Me.spsls.Name = "spsls"
        '
        'nomer
        '
        Me.nomer.HeaderText = "No.Telp"
        Me.nomer.Name = "nomer"
        '
        'trf
        '
        Me.trf.HeaderText = "Tarif"
        Me.trf.Name = "trf"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Tarif"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "No. Telp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Spesialis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Nama"
        '
        'tarif
        '
        Me.tarif.Location = New System.Drawing.Point(99, 189)
        Me.tarif.Name = "tarif"
        Me.tarif.Size = New System.Drawing.Size(121, 20)
        Me.tarif.TabIndex = 39
        '
        'no_telp
        '
        Me.no_telp.Location = New System.Drawing.Point(99, 163)
        Me.no_telp.Name = "no_telp"
        Me.no_telp.Size = New System.Drawing.Size(121, 20)
        Me.no_telp.TabIndex = 38
        '
        'spesialis
        '
        Me.spesialis.Location = New System.Drawing.Point(99, 138)
        Me.spesialis.Name = "spesialis"
        Me.spesialis.Size = New System.Drawing.Size(121, 20)
        Me.spesialis.TabIndex = 35
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(99, 112)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(121, 20)
        Me.nama.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'kd_dokter
        '
        Me.kd_dokter.Location = New System.Drawing.Point(99, 86)
        Me.kd_dokter.Name = "kd_dokter"
        Me.kd_dokter.Size = New System.Drawing.Size(121, 20)
        Me.kd_dokter.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Kode Dokter"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(64, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "Ubah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(64, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Nb : Ubah dan Hapus  sesuai kode dokter"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(41, 277)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(98, 23)
        Me.Button9.TabIndex = 114
        Me.Button9.Text = "Export to PDF"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(145, 277)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 113
        Me.Button8.Text = "Lihat Semua"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'dokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 324)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tarif)
        Me.Controls.Add(Me.no_telp)
        Me.Controls.Add(Me.spesialis)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.kd_dokter)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "dokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dokter"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tarif As System.Windows.Forms.TextBox
    Friend WithEvents no_telp As System.Windows.Forms.TextBox
    Friend WithEvents spesialis As System.Windows.Forms.TextBox
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents kd_dokter As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nm_dokter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spsls As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
