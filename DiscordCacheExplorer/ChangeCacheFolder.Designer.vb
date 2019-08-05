<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangeCacheFolder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeCacheFolder))
        Me.CacheFolderText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OKaybutton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AutoDetectListbox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackUPList = New System.Windows.Forms.ListBox()
        Me.FilterLabel = New System.Windows.Forms.Label()
        Me.FilterComboBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CacheFolderText
        '
        Me.CacheFolderText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CacheFolderText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CacheFolderText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CacheFolderText.ForeColor = System.Drawing.Color.White
        Me.CacheFolderText.Location = New System.Drawing.Point(12, 27)
        Me.CacheFolderText.Name = "CacheFolderText"
        Me.CacheFolderText.Size = New System.Drawing.Size(512, 20)
        Me.CacheFolderText.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
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
        Me.OKaybutton.Location = New System.Drawing.Point(0, 300)
        Me.OKaybutton.Name = "OKaybutton"
        Me.OKaybutton.Size = New System.Drawing.Size(536, 52)
        Me.OKaybutton.TabIndex = 5
        Me.OKaybutton.Text = "OK"
        Me.OKaybutton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Auto Detected Program Cache Folders:"
        '
        'AutoDetectListbox
        '
        Me.AutoDetectListbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutoDetectListbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.AutoDetectListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AutoDetectListbox.ForeColor = System.Drawing.Color.White
        Me.AutoDetectListbox.FormattingEnabled = True
        Me.AutoDetectListbox.HorizontalScrollbar = True
        Me.AutoDetectListbox.IntegralHeight = False
        Me.AutoDetectListbox.ItemHeight = 14
        Me.AutoDetectListbox.Location = New System.Drawing.Point(12, 70)
        Me.AutoDetectListbox.Name = "AutoDetectListbox"
        Me.AutoDetectListbox.Size = New System.Drawing.Size(512, 181)
        Me.AutoDetectListbox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(119, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Please wait, loading in folders..."
        '
        'BackUPList
        '
        Me.BackUPList.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BackUPList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BackUPList.ForeColor = System.Drawing.Color.White
        Me.BackUPList.FormattingEnabled = True
        Me.BackUPList.HorizontalScrollbar = True
        Me.BackUPList.IntegralHeight = False
        Me.BackUPList.ItemHeight = 14
        Me.BackUPList.Location = New System.Drawing.Point(440, 53)
        Me.BackUPList.Name = "BackUPList"
        Me.BackUPList.Size = New System.Drawing.Size(10, 11)
        Me.BackUPList.TabIndex = 9
        Me.BackUPList.Visible = False
        '
        'FilterLabel
        '
        Me.FilterLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FilterLabel.AutoSize = True
        Me.FilterLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterLabel.ForeColor = System.Drawing.Color.LightGray
        Me.FilterLabel.Location = New System.Drawing.Point(12, 255)
        Me.FilterLabel.Name = "FilterLabel"
        Me.FilterLabel.Size = New System.Drawing.Size(36, 13)
        Me.FilterLabel.TabIndex = 15
        Me.FilterLabel.Text = "Filter:"
        '
        'FilterComboBox
        '
        Me.FilterComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilterComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FilterComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilterComboBox.ForeColor = System.Drawing.Color.White
        Me.FilterComboBox.Location = New System.Drawing.Point(12, 272)
        Me.FilterComboBox.Multiline = True
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(512, 20)
        Me.FilterComboBox.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Aqua
        Me.Button1.Location = New System.Drawing.Point(400, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 22)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Refresh Program List"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ChangeCacheFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 352)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.FilterLabel)
        Me.Controls.Add(Me.BackUPList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AutoDetectListbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OKaybutton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CacheFolderText)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(552, 297)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents BackUPList As ListBox
    Friend WithEvents FilterLabel As Label
    Friend WithEvents FilterComboBox As TextBox
    Friend WithEvents Button1 As Button
End Class
