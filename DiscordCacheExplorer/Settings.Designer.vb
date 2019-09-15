<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CacheExplorerLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.BuildInformationLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OKaybutton = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CacheExplorerLabel)
        Me.Panel2.Controls.Add(Me.Logo)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 56)
        Me.Panel2.TabIndex = 8
        '
        'CacheExplorerLabel
        '
        Me.CacheExplorerLabel.AutoSize = True
        Me.CacheExplorerLabel.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CacheExplorerLabel.ForeColor = System.Drawing.Color.LightGray
        Me.CacheExplorerLabel.Location = New System.Drawing.Point(73, 3)
        Me.CacheExplorerLabel.Name = "CacheExplorerLabel"
        Me.CacheExplorerLabel.Size = New System.Drawing.Size(117, 22)
        Me.CacheExplorerLabel.TabIndex = 9
        Me.CacheExplorerLabel.Text = "Cache Explorer"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BuildInformationLabel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(394, 24)
        Me.Panel4.TabIndex = 9
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Logo.Image = Global.DiscordCacheExplorer.My.Resources.Resources.icons8_opened_folder_64
        Me.Logo.Location = New System.Drawing.Point(-1, -1)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(69, 56)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 8
        Me.Logo.TabStop = False
        '
        'BuildInformationLabel
        '
        Me.BuildInformationLabel.AutoSize = True
        Me.BuildInformationLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildInformationLabel.ForeColor = System.Drawing.Color.LightGray
        Me.BuildInformationLabel.Location = New System.Drawing.Point(76, 2)
        Me.BuildInformationLabel.Name = "BuildInformationLabel"
        Me.BuildInformationLabel.Size = New System.Drawing.Size(52, 15)
        Me.BuildInformationLabel.TabIndex = 10
        Me.BuildInformationLabel.Text = "Settings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(14, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Skins:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Dark Purple", "Dark Gray(Grey)", "Light"})
        Me.ComboBox1.Location = New System.Drawing.Point(59, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.Text = "Dark Purple"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(17, 92)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 18)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "DEBUG MODE"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'OKaybutton
        '
        Me.OKaybutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.OKaybutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.OKaybutton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OKaybutton.FlatAppearance.BorderSize = 0
        Me.OKaybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKaybutton.ForeColor = System.Drawing.Color.Aqua
        Me.OKaybutton.Location = New System.Drawing.Point(0, 135)
        Me.OKaybutton.Name = "OKaybutton"
        Me.OKaybutton.Size = New System.Drawing.Size(396, 52)
        Me.OKaybutton.TabIndex = 13
        Me.OKaybutton.Text = "CONFIRM"
        Me.OKaybutton.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(396, 187)
        Me.Controls.Add(Me.OKaybutton)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents CacheExplorerLabel As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BuildInformationLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents OKaybutton As Button
End Class
