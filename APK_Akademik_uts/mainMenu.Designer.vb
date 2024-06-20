<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem1 = New ToolStripMenuItem()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        DataProdiToolStripMenuItem1 = New ToolStripMenuItem()
        DataMahasiswaToolStripMenuItem1 = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem1 = New ToolStripMenuItem()
        Panel1 = New Panel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem1})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LogoutToolStripMenuItem1
        ' 
        LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        LogoutToolStripMenuItem1.Size = New Size(112, 22)
        LogoutToolStripMenuItem1.Text = "Logout"
        ' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DataProdiToolStripMenuItem1, DataMahasiswaToolStripMenuItem1})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(55, 20)
        MasterToolStripMenuItem.Text = "Master"
        ' 
        ' DataProdiToolStripMenuItem1
        ' 
        DataProdiToolStripMenuItem1.Name = "DataProdiToolStripMenuItem1"
        DataProdiToolStripMenuItem1.Size = New Size(159, 22)
        DataProdiToolStripMenuItem1.Text = "Data Prodi"
        ' 
        ' DataMahasiswaToolStripMenuItem1
        ' 
        DataMahasiswaToolStripMenuItem1.Name = "DataMahasiswaToolStripMenuItem1"
        DataMahasiswaToolStripMenuItem1.Size = New Size(159, 22)
        DataMahasiswaToolStripMenuItem1.Text = "Data Mahasiswa"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem1})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem1
        ' 
        AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        AboutToolStripMenuItem1.Size = New Size(107, 22)
        AboutToolStripMenuItem1.Text = "About"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Location = New Point(12, 27)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(6)
        Panel1.Size = New Size(776, 411)
        Panel1.TabIndex = 4
        ' 
        ' mainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "mainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Menu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataProdiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataMahasiswaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
