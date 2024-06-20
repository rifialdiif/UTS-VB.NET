<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        tbPass = New TextBox()
        tbUser = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        btnBatal = New Button()
        btnLogin = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Typewriter", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(90, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 37)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(tbPass)
        GroupBox1.Controls.Add(tbUser)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 61)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(269, 91)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' tbPass
        ' 
        tbPass.Location = New Point(127, 52)
        tbPass.Name = "tbPass"
        tbPass.Size = New Size(123, 23)
        tbPass.TabIndex = 3
        ' 
        ' tbUser
        ' 
        tbUser.Location = New Point(127, 21)
        tbUser.Name = "tbUser"
        tbUser.Size = New Size(123, 23)
        tbUser.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 1
        Label3.Text = "PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 0
        Label2.Text = "USER"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnBatal)
        GroupBox2.Controls.Add(btnLogin)
        GroupBox2.Location = New Point(12, 162)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(269, 68)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(143, 22)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(104, 35)
        btnBatal.TabIndex = 1
        btnBatal.Text = "&BATAL"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(21, 22)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(104, 35)
        btnLogin.TabIndex = 0
        btnLogin.Text = "&LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnBatal
        ClientSize = New Size(293, 252)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbPass As TextBox
    Friend WithEvents tbUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnLogin As Button
End Class
