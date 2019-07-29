<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeCacheFolder
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
        Me.CacheFolderText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OKaybutton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AutoDetectListbox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'CacheFolderText
        '
        Me.CacheFolderText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CacheFolderText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CacheFolderText.ForeColor = System.Drawing.Color.White
        Me.CacheFolderText.Location = New System.Drawing.Point(12, 25)
        Me.CacheFolderText.Name = "CacheFolderText"
        Me.CacheFolderText.Size = New System.Drawing.Size(512, 20)
        Me.CacheFolderText.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cache Folder:"
        '
        'OKaybutton
        '
        Me.OKaybutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.OKaybutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OKaybutton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OKaybutton.FlatAppearance.BorderSize = 0
        Me.OKaybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKaybutton.ForeColor = System.Drawing.Color.Aqua
        Me.OKaybutton.Location = New System.Drawing.Point(0, 164)
        Me.OKaybutton.Name = "OKaybutton"
        Me.OKaybutton.Size = New System.Drawing.Size(536, 48)
        Me.OKaybutton.TabIndex = 5
        Me.OKaybutton.Text = "OK"
        Me.OKaybutton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Auto Detected Program Cache Folders:"
        '
        'AutoDetectListbox
        '
        Me.AutoDetectListbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.AutoDetectListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AutoDetectListbox.ForeColor = System.Drawing.Color.White
        Me.AutoDetectListbox.FormattingEnabled = True
        Me.AutoDetectListbox.Location = New System.Drawing.Point(12, 65)
        Me.AutoDetectListbox.Name = "AutoDetectListbox"
        Me.AutoDetectListbox.Size = New System.Drawing.Size(512, 93)
        Me.AutoDetectListbox.TabIndex = 8
        '
        'ChangeCacheFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 212)
        Me.Controls.Add(Me.AutoDetectListbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OKaybutton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CacheFolderText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChangeCacheFolder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup: Cache Folder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CacheFolderText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OKaybutton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents AutoDetectListbox As ListBox
End Class
