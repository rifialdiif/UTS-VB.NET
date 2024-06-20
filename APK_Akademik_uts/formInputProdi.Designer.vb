<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInputProdi
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
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        tbNm_prodi = New TextBox()
        tbKode = New TextBox()
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
        Label1.Location = New Point(24, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(423, 33)
        Label1.TabIndex = 1
        Label1.Text = ":: DATA PROGRAM STUDI ::"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(tbNm_prodi)
        GroupBox1.Controls.Add(tbKode)
        GroupBox1.Location = New Point(12, 64)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(447, 142)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 3
        Label3.Text = "Nama Prodi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(78, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 2
        Label2.Text = "Kode"
        ' 
        ' tbNm_prodi
        ' 
        tbNm_prodi.Location = New Point(118, 76)
        tbNm_prodi.Name = "tbNm_prodi"
        tbNm_prodi.Size = New Size(203, 23)
        tbNm_prodi.TabIndex = 1
        ' 
        ' tbKode
        ' 
        tbKode.Location = New Point(118, 34)
        tbKode.Name = "tbKode"
        tbKode.Size = New Size(100, 23)
        tbKode.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnBatal)
        GroupBox2.Controls.Add(btnTambah)
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(btnSimpan)
        GroupBox2.Location = New Point(12, 219)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(447, 73)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(350, 22)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(82, 39)
        btnBatal.TabIndex = 7
        btnBatal.Text = "&BATAL"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(238, 22)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(82, 39)
        btnTambah.TabIndex = 6
        btnTambah.Text = "&TAMBAH"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(126, 22)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(82, 39)
        btnHapus.TabIndex = 5
        btnHapus.Text = "&HAPUS"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(14, 22)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(82, 39)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "&SIMPAN"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' formInputProdi
        ' 
        AcceptButton = btnSimpan
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnBatal
        ClientSize = New Size(471, 304)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "formInputProdi"
        Text = "formInputProdi"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNm_prodi As TextBox
    Friend WithEvents tbKode As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
End Class
