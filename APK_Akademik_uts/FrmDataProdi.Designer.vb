<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataProdi
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnAdd = New Button()
        btnKeluar = New Button()
        Label2 = New Label()
        tbCari = New TextBox()
        btnEdit = New Button()
        DataGridProdi = New DataGridView()
        CType(DataGridProdi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.Location = New Point(294, 22)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(43, 23)
        btnAdd.TabIndex = 12
        btnAdd.Text = "&ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnKeluar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnKeluar.Location = New Point(392, 22)
        btnKeluar.Margin = New Padding(3, 2, 3, 2)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 11
        btnKeluar.Text = "&KELUAR"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 10
        Label2.Text = "Cari Nama"
        ' 
        ' tbCari
        ' 
        tbCari.Location = New Point(100, 22)
        tbCari.Name = "tbCari"
        tbCari.Size = New Size(139, 23)
        tbCari.TabIndex = 9
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnEdit.Location = New Point(341, 22)
        btnEdit.Margin = New Padding(3, 2, 3, 2)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(47, 23)
        btnEdit.TabIndex = 8
        btnEdit.Text = "&EDIT"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' DataGridProdi
        ' 
        DataGridProdi.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridProdi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridProdi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridProdi.DefaultCellStyle = DataGridViewCellStyle1
        DataGridProdi.Location = New Point(31, 68)
        DataGridProdi.Name = "DataGridProdi"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridProdi.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridProdi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridProdi.RowTemplate.Height = 25
        DataGridProdi.Size = New Size(436, 258)
        DataGridProdi.TabIndex = 13
        ' 
        ' FrmDataProdi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(495, 338)
        ControlBox = False
        Controls.Add(DataGridProdi)
        Controls.Add(btnAdd)
        Controls.Add(btnKeluar)
        Controls.Add(Label2)
        Controls.Add(tbCari)
        Controls.Add(btnEdit)
        FormBorderStyle = FormBorderStyle.None
        MinimizeBox = False
        Name = "FrmDataProdi"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "FrmDataProdi"
        WindowState = FormWindowState.Maximized
        CType(DataGridProdi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCari As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents DataGridProdi As DataGridView
End Class
