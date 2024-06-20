<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInputMhs
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        lbProdi = New Label()
        tbAlamat = New TextBox()
        dtpTgl_lahir = New DateTimePicker()
        tbTmp_lahir = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        cbStatus = New ComboBox()
        cbJurusan = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        cbAgama = New ComboBox()
        cbKelamin = New ComboBox()
        tbNama = New TextBox()
        tbNIM = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        btnBatal = New Button()
        btnTambah = New Button()
        btnHapus = New Button()
        btnSimpan = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Courier New", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(87, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(406, 33)
        Label1.TabIndex = 0
        Label1.Text = ":: BIODATA MAHASISWA ::"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 0
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(75, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 1
        Label3.Text = "Nama"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(lbProdi)
        GroupBox1.Controls.Add(tbAlamat)
        GroupBox1.Controls.Add(dtpTgl_lahir)
        GroupBox1.Controls.Add(tbTmp_lahir)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(cbStatus)
        GroupBox1.Controls.Add(cbJurusan)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(cbAgama)
        GroupBox1.Controls.Add(cbKelamin)
        GroupBox1.Controls.Add(tbNama)
        GroupBox1.Controls.Add(tbNIM)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(13, 52)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(556, 366)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' lbProdi
        ' 
        lbProdi.AutoSize = True
        lbProdi.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbProdi.Location = New Point(341, 282)
        lbProdi.Name = "lbProdi"
        lbProdi.Size = New Size(0, 15)
        lbProdi.TabIndex = 15
        ' 
        ' tbAlamat
        ' 
        tbAlamat.Location = New Point(120, 194)
        tbAlamat.Multiline = True
        tbAlamat.Name = "tbAlamat"
        tbAlamat.ScrollBars = ScrollBars.Vertical
        tbAlamat.Size = New Size(146, 68)
        tbAlamat.TabIndex = 14
        ' 
        ' dtpTgl_lahir
        ' 
        dtpTgl_lahir.CustomFormat = "yyyy-MM-dd"
        dtpTgl_lahir.Format = DateTimePickerFormat.Custom
        dtpTgl_lahir.Location = New Point(396, 150)
        dtpTgl_lahir.Name = "dtpTgl_lahir"
        dtpTgl_lahir.Size = New Size(121, 23)
        dtpTgl_lahir.TabIndex = 5
        dtpTgl_lahir.Value = New Date(2023, 11, 19, 0, 0, 0, 0)
        ' 
        ' tbTmp_lahir
        ' 
        tbTmp_lahir.Location = New Point(122, 154)
        tbTmp_lahir.Name = "tbTmp_lahir"
        tbTmp_lahir.Size = New Size(121, 23)
        tbTmp_lahir.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(311, 154)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 15)
        Label10.TabIndex = 13
        Label10.Text = "Tanggal Lahir"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(39, 158)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 15)
        Label9.TabIndex = 12
        Label9.Text = "Tempat Lahir"
        ' 
        ' cbStatus
        ' 
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.FormattingEnabled = True
        cbStatus.Location = New Point(122, 319)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(121, 23)
        cbStatus.TabIndex = 8
        ' 
        ' cbJurusan
        ' 
        cbJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cbJurusan.FormattingEnabled = True
        cbJurusan.Location = New Point(122, 279)
        cbJurusan.Name = "cbJurusan"
        cbJurusan.Size = New Size(121, 23)
        cbJurusan.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 323)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 15)
        Label8.TabIndex = 11
        Label8.Text = "Status Mahasiswa"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(67, 283)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 15)
        Label7.TabIndex = 10
        Label7.Text = "Jurusan"
        ' 
        ' cbAgama
        ' 
        cbAgama.DropDownStyle = ComboBoxStyle.DropDownList
        cbAgama.FormattingEnabled = True
        cbAgama.Location = New Point(396, 113)
        cbAgama.Name = "cbAgama"
        cbAgama.Size = New Size(121, 23)
        cbAgama.TabIndex = 3
        ' 
        ' cbKelamin
        ' 
        cbKelamin.DropDownStyle = ComboBoxStyle.DropDownList
        cbKelamin.FormattingEnabled = True
        cbKelamin.Items.AddRange(New Object() {""})
        cbKelamin.Location = New Point(122, 114)
        cbKelamin.Name = "cbKelamin"
        cbKelamin.Size = New Size(121, 23)
        cbKelamin.TabIndex = 2
        ' 
        ' tbNama
        ' 
        tbNama.Location = New Point(122, 74)
        tbNama.Name = "tbNama"
        tbNama.Size = New Size(143, 23)
        tbNama.TabIndex = 1
        ' 
        ' tbNIM
        ' 
        tbNIM.Location = New Point(122, 34)
        tbNIM.Name = "tbNIM"
        tbNIM.Size = New Size(114, 23)
        tbNIM.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(69, 221)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 4
        Label6.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(343, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 3
        Label5.Text = "Agama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 2
        Label4.Text = "Jenis Kelamin"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnBatal)
        GroupBox2.Controls.Add(btnTambah)
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(btnSimpan)
        GroupBox2.Location = New Point(14, 424)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(554, 73)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(416, 22)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(82, 39)
        btnBatal.TabIndex = 3
        btnBatal.Text = "&BATAL"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(296, 22)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(82, 39)
        btnTambah.TabIndex = 2
        btnTambah.Text = "&TAMBAH"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(176, 22)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(82, 39)
        btnHapus.TabIndex = 1
        btnHapus.Text = "&HAPUS"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(56, 22)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(82, 39)
        btnSimpan.TabIndex = 0
        btnSimpan.Text = "&SIMPAN"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' formInputMhs
        ' 
        AcceptButton = btnSimpan
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnBatal
        ClientSize = New Size(580, 513)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "formInputMhs"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formInputMhs"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbKelamin As ComboBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents tbNIM As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbJurusan As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbAgama As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tbTmp_lahir As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpTgl_lahir As DateTimePicker
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents lbProdi As Label
End Class
