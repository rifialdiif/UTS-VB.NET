<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(about))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.ImageLocation = ""
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(137, 279)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(166, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 15)
        Label1.TabIndex = 1
        Label1.Text = "Aplikasi_Akademik_UTS_2023"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(166, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 2
        Label2.Text = "Version 3.0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(166, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(251, 15)
        Label3.TabIndex = 3
        Label3.Text = "Copyright© 2023: Fadli Nurhidayat: 202104008"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(166, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 15)
        Label4.TabIndex = 4
        Label4.Text = "Teknologi Rekayasa Perangkat Lunak"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(166, 143)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(281, 113)
        TextBox1.TabIndex = 5
        TextBox1.TabStop = False
        TextBox1.Text = "Aplikasi ini dibuat sebagai salah satu syarat dalam Ujian Tengah Semester"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(372, 262)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Ok"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' about
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(459, 303)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "about"
        StartPosition = FormStartPosition.CenterScreen
        Text = "about"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
