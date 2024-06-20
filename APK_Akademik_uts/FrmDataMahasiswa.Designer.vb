<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataMahasiswa
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
        btnEdit = New Button()
        GroupBox1 = New GroupBox()
        DataGridMahasiswa = New DataGridView()
        tbCari = New TextBox()
        Label1 = New Label()
        cbProdi = New ComboBox()
        Label2 = New Label()
        btnKeluar = New Button()
        btnAdd = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnEdit.Location = New Point(547, 42)
        btnEdit.Margin = New Padding(3, 2, 3, 2)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(47, 23)
        btnEdit.TabIndex = 0
        btnEdit.Text = "&EDIT"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(DataGridMahasiswa)
        GroupBox1.Location = New Point(20, 70)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(653, 260)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' DataGridMahasiswa
        ' 
        DataGridMahasiswa.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridMahasiswa.Location = New Point(18, 20)
        DataGridMahasiswa.Margin = New Padding(3, 2, 3, 2)
        DataGridMahasiswa.Name = "DataGridMahasiswa"
        DataGridMahasiswa.RowHeadersWidth = 51
        DataGridMahasiswa.RowTemplate.Height = 29
        DataGridMahasiswa.Size = New Size(620, 236)
        DataGridMahasiswa.TabIndex = 0
        ' 
        ' tbCari
        ' 
        tbCari.Location = New Point(306, 42)
        tbCari.Name = "tbCari"
        tbCari.Size = New Size(139, 23)
        tbCari.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 15)
        Label1.TabIndex = 3
        Label1.Text = "Program Studi"
        ' 
        ' cbProdi
        ' 
        cbProdi.DropDownStyle = ComboBoxStyle.DropDownList
        cbProdi.FormattingEnabled = True
        cbProdi.Location = New Point(109, 42)
        cbProdi.Name = "cbProdi"
        cbProdi.Size = New Size(121, 23)
        cbProdi.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(237, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 5
        Label2.Text = "Cari Nama"
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnKeluar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnKeluar.Location = New Point(598, 42)
        btnKeluar.Margin = New Padding(3, 2, 3, 2)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 6
        btnKeluar.Text = "&KELUAR"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.Location = New Point(500, 42)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(43, 23)
        btnAdd.TabIndex = 7
        btnAdd.Text = "&ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' FrmDataMahasiswa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(700, 338)
        ControlBox = False
        Controls.Add(btnAdd)
        Controls.Add(btnKeluar)
        Controls.Add(Label2)
        Controls.Add(cbProdi)
        Controls.Add(Label1)
        Controls.Add(tbCari)
        Controls.Add(GroupBox1)
        Controls.Add(btnEdit)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "FrmDataMahasiswa"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "FrmDataMahasiswa"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        CType(DataGridMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridMahasiswa As DataGridView
    Friend WithEvents tbCari As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbProdi As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnAdd As Button
End Class
