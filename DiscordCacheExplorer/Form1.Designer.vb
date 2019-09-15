<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OverrideCheck = New System.Windows.Forms.CheckBox()
        Me.AutoPlayCheck = New System.Windows.Forms.CheckBox()
        Me.SecureDeleteButton = New System.Windows.Forms.Button()
        Me.DeleteALLbutton = New System.Windows.Forms.Button()
        Me.OpenTypeCheck = New System.Windows.Forms.ComboBox()
        Me.OpenTypeLabel = New System.Windows.Forms.Label()
        Me.ClearCacheButton = New System.Windows.Forms.Button()
        Me.ExportButt = New System.Windows.Forms.Button()
        Me.ScanCachebutton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PlainTextBox = New System.Windows.Forms.RichTextBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AutoPlayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UpdateAvailable = New System.Windows.Forms.LinkLabel()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.ChangeCacheFoldButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UnableUpdates = New System.Windows.Forms.Label()
        Me.BuildInformationLabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CacheListBackup = New System.Windows.Forms.ListBox()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.FilterLabel = New System.Windows.Forms.Label()
        Me.TotalFilesLabel = New System.Windows.Forms.Label()
        Me.CacheExplorerList = New System.Windows.Forms.ListBox()
        Me.ImageSizeModeStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StretchImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.ImageDisplay = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ImageSizeModeStrip.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.OverrideCheck)
        Me.Panel1.Controls.Add(Me.AutoPlayCheck)
        Me.Panel1.Controls.Add(Me.SecureDeleteButton)
        Me.Panel1.Controls.Add(Me.DeleteALLbutton)
        Me.Panel1.Controls.Add(Me.OpenTypeCheck)
        Me.Panel1.Controls.Add(Me.OpenTypeLabel)
        Me.Panel1.Controls.Add(Me.ClearCacheButton)
        Me.Panel1.Controls.Add(Me.ExportButt)
        Me.Panel1.Controls.Add(Me.ScanCachebutton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 68)
        Me.Panel1.TabIndex = 3
        '
        'OverrideCheck
        '
        Me.OverrideCheck.AutoSize = True
        Me.OverrideCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OverrideCheck.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverrideCheck.ForeColor = System.Drawing.Color.White
        Me.OverrideCheck.Location = New System.Drawing.Point(265, 42)
        Me.OverrideCheck.Name = "OverrideCheck"
        Me.OverrideCheck.Size = New System.Drawing.Size(66, 18)
        Me.OverrideCheck.TabIndex = 7
        Me.OverrideCheck.Text = "Override"
        Me.OverrideCheck.UseVisualStyleBackColor = True
        '
        'AutoPlayCheck
        '
        Me.AutoPlayCheck.AutoSize = True
        Me.AutoPlayCheck.Checked = True
        Me.AutoPlayCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoPlayCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AutoPlayCheck.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoPlayCheck.ForeColor = System.Drawing.Color.White
        Me.AutoPlayCheck.Location = New System.Drawing.Point(367, 2)
        Me.AutoPlayCheck.Name = "AutoPlayCheck"
        Me.AutoPlayCheck.Size = New System.Drawing.Size(101, 18)
        Me.AutoPlayCheck.TabIndex = 6
        Me.AutoPlayCheck.Text = "Auto-Play Video"
        Me.AutoPlayCheck.UseVisualStyleBackColor = True
        '
        'SecureDeleteButton
        '
        Me.SecureDeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SecureDeleteButton.FlatAppearance.BorderSize = 0
        Me.SecureDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SecureDeleteButton.Font = New System.Drawing.Font("Arial Narrow", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecureDeleteButton.ForeColor = System.Drawing.Color.Aqua
        Me.SecureDeleteButton.Location = New System.Drawing.Point(147, 32)
        Me.SecureDeleteButton.Name = "SecureDeleteButton"
        Me.SecureDeleteButton.Size = New System.Drawing.Size(111, 33)
        Me.SecureDeleteButton.TabIndex = 5
        Me.SecureDeleteButton.Text = "Securely Delete Selected"
        Me.SecureDeleteButton.UseVisualStyleBackColor = False
        '
        'DeleteALLbutton
        '
        Me.DeleteALLbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.DeleteALLbutton.FlatAppearance.BorderSize = 0
        Me.DeleteALLbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteALLbutton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteALLbutton.ForeColor = System.Drawing.Color.Aqua
        Me.DeleteALLbutton.Location = New System.Drawing.Point(147, 0)
        Me.DeleteALLbutton.Name = "DeleteALLbutton"
        Me.DeleteALLbutton.Size = New System.Drawing.Size(111, 31)
        Me.DeleteALLbutton.TabIndex = 5
        Me.DeleteALLbutton.Text = "Delete Selected"
        Me.DeleteALLbutton.UseVisualStyleBackColor = False
        '
        'OpenTypeCheck
        '
        Me.OpenTypeCheck.Enabled = False
        Me.OpenTypeCheck.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenTypeCheck.FormattingEnabled = True
        Me.OpenTypeCheck.Items.AddRange(New Object() {"Image", "Plain Text", "Video"})
        Me.OpenTypeCheck.Location = New System.Drawing.Point(264, 19)
        Me.OpenTypeCheck.Name = "OpenTypeCheck"
        Me.OpenTypeCheck.Size = New System.Drawing.Size(92, 22)
        Me.OpenTypeCheck.TabIndex = 4
        Me.OpenTypeCheck.Text = "Image"
        '
        'OpenTypeLabel
        '
        Me.OpenTypeLabel.AutoSize = True
        Me.OpenTypeLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenTypeLabel.ForeColor = System.Drawing.Color.White
        Me.OpenTypeLabel.Location = New System.Drawing.Point(261, 4)
        Me.OpenTypeLabel.Name = "OpenTypeLabel"
        Me.OpenTypeLabel.Size = New System.Drawing.Size(62, 14)
        Me.OpenTypeLabel.TabIndex = 3
        Me.OpenTypeLabel.Text = "Open Type:"
        '
        'ClearCacheButton
        '
        Me.ClearCacheButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearCacheButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClearCacheButton.FlatAppearance.BorderSize = 0
        Me.ClearCacheButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearCacheButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearCacheButton.ForeColor = System.Drawing.Color.Aqua
        Me.ClearCacheButton.Location = New System.Drawing.Point(477, -1)
        Me.ClearCacheButton.Name = "ClearCacheButton"
        Me.ClearCacheButton.Size = New System.Drawing.Size(97, 68)
        Me.ClearCacheButton.TabIndex = 0
        Me.ClearCacheButton.Text = "Clear Cache Explorer Dump"
        Me.ClearCacheButton.UseVisualStyleBackColor = False
        '
        'ExportButt
        '
        Me.ExportButt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExportButt.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ExportButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ExportButt.FlatAppearance.BorderSize = 0
        Me.ExportButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportButt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportButt.ForeColor = System.Drawing.Color.Aqua
        Me.ExportButt.Location = New System.Drawing.Point(575, -1)
        Me.ExportButt.Name = "ExportButt"
        Me.ExportButt.Size = New System.Drawing.Size(125, 68)
        Me.ExportButt.TabIndex = 0
        Me.ExportButt.Text = "Export"
        Me.ExportButt.UseVisualStyleBackColor = False
        '
        'ScanCachebutton
        '
        Me.ScanCachebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ScanCachebutton.FlatAppearance.BorderSize = 0
        Me.ScanCachebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScanCachebutton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanCachebutton.ForeColor = System.Drawing.Color.Aqua
        Me.ScanCachebutton.Location = New System.Drawing.Point(-2, 0)
        Me.ScanCachebutton.Name = "ScanCachebutton"
        Me.ScanCachebutton.Size = New System.Drawing.Size(148, 67)
        Me.ScanCachebutton.TabIndex = 2
        Me.ScanCachebutton.Text = "Scan/Rescan Cache"
        Me.ScanCachebutton.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "CE_"
        Me.SaveFileDialog1.Title = "Save Selected file(s) to a folder."
        '
        'PlainTextBox
        '
        Me.PlainTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlainTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PlainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlainTextBox.ForeColor = System.Drawing.Color.LightGray
        Me.PlainTextBox.Location = New System.Drawing.Point(150, 53)
        Me.PlainTextBox.Name = "PlainTextBox"
        Me.PlainTextBox.ReadOnly = True
        Me.PlainTextBox.Size = New System.Drawing.Size(551, 315)
        Me.PlainTextBox.TabIndex = 4
        Me.PlainTextBox.Text = ""
        Me.PlainTextBox.Visible = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(150, 49)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(551, 319)
        Me.AxWindowsMediaPlayer1.TabIndex = 5
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'AutoPlayTimer
        '
        Me.AutoPlayTimer.Enabled = True
        Me.AutoPlayTimer.Interval = 200
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.UpdateAvailable)
        Me.Panel2.Controls.Add(Me.AboutButton)
        Me.Panel2.Controls.Add(Me.Logo)
        Me.Panel2.Controls.Add(Me.ChangeCacheFoldButton)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(701, 52)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(74, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cache Explorer"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Aqua
        Me.Button1.Location = New System.Drawing.Point(505, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 168
        Me.Button1.Text = "Settings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UpdateAvailable
        '
        Me.UpdateAvailable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateAvailable.AutoSize = True
        Me.UpdateAvailable.Font = New System.Drawing.Font("Arial", 11.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateAvailable.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UpdateAvailable.Location = New System.Drawing.Point(380, 6)
        Me.UpdateAvailable.Name = "UpdateAvailable"
        Me.UpdateAvailable.Size = New System.Drawing.Size(117, 17)
        Me.UpdateAvailable.TabIndex = 167
        Me.UpdateAvailable.TabStop = True
        Me.UpdateAvailable.Text = "Update Available"
        Me.UpdateAvailable.Visible = False
        '
        'AboutButton
        '
        Me.AboutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.AboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AboutButton.FlatAppearance.BorderSize = 0
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutButton.ForeColor = System.Drawing.Color.Aqua
        Me.AboutButton.Location = New System.Drawing.Point(505, -2)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(109, 29)
        Me.AboutButton.TabIndex = 10
        Me.AboutButton.Text = "About and Help"
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Logo.Image = Global.DiscordCacheExplorer.My.Resources.Resources.icons8_opened_folder_64
        Me.Logo.Location = New System.Drawing.Point(-1, -1)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(69, 52)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 8
        Me.Logo.TabStop = False
        '
        'ChangeCacheFoldButton
        '
        Me.ChangeCacheFoldButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangeCacheFoldButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ChangeCacheFoldButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ChangeCacheFoldButton.FlatAppearance.BorderSize = 0
        Me.ChangeCacheFoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeCacheFoldButton.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeCacheFoldButton.ForeColor = System.Drawing.Color.Aqua
        Me.ChangeCacheFoldButton.Location = New System.Drawing.Point(615, -1)
        Me.ChangeCacheFoldButton.Name = "ChangeCacheFoldButton"
        Me.ChangeCacheFoldButton.Size = New System.Drawing.Size(84, 52)
        Me.ChangeCacheFoldButton.TabIndex = 10
        Me.ChangeCacheFoldButton.Text = "Change Cache Folder"
        Me.ChangeCacheFoldButton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.UnableUpdates)
        Me.Panel4.Controls.Add(Me.BuildInformationLabel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(699, 22)
        Me.Panel4.TabIndex = 9
        '
        'UnableUpdates
        '
        Me.UnableUpdates.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnableUpdates.AutoSize = True
        Me.UnableUpdates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UnableUpdates.Location = New System.Drawing.Point(353, 3)
        Me.UnableUpdates.Name = "UnableUpdates"
        Me.UnableUpdates.Size = New System.Drawing.Size(146, 14)
        Me.UnableUpdates.TabIndex = 11
        Me.UnableUpdates.Text = "Unable to check for updates."
        Me.UnableUpdates.Visible = False
        '
        'BuildInformationLabel
        '
        Me.BuildInformationLabel.AutoSize = True
        Me.BuildInformationLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildInformationLabel.ForeColor = System.Drawing.Color.LightGray
        Me.BuildInformationLabel.Location = New System.Drawing.Point(76, 2)
        Me.BuildInformationLabel.Name = "BuildInformationLabel"
        Me.BuildInformationLabel.Size = New System.Drawing.Size(171, 15)
        Me.BuildInformationLabel.TabIndex = 10
        Me.BuildInformationLabel.Text = "Change ProgramVer in Form1"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.CacheListBackup)
        Me.Panel3.Controls.Add(Me.FilterComboBox)
        Me.Panel3.Controls.Add(Me.FilterLabel)
        Me.Panel3.Controls.Add(Me.TotalFilesLabel)
        Me.Panel3.Controls.Add(Me.CacheExplorerList)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(149, 316)
        Me.Panel3.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(37, 267)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 19)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Exclude .unknown"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CacheListBackup
        '
        Me.CacheListBackup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CacheListBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CacheListBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CacheListBackup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CacheListBackup.ForeColor = System.Drawing.Color.LightGray
        Me.CacheListBackup.FormattingEnabled = True
        Me.CacheListBackup.HorizontalScrollbar = True
        Me.CacheListBackup.IntegralHeight = False
        Me.CacheListBackup.Location = New System.Drawing.Point(133, 270)
        Me.CacheListBackup.Name = "CacheListBackup"
        Me.CacheListBackup.Size = New System.Drawing.Size(10, 11)
        Me.CacheListBackup.TabIndex = 11
        Me.CacheListBackup.Visible = False
        '
        'FilterComboBox
        '
        Me.FilterComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FilterComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FilterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilterComboBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterComboBox.ForeColor = System.Drawing.Color.LightGray
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Items.AddRange(New Object() {".png", ".gif", ".jpeg", ".jpg", ".mp4", ".unknown", ".bmp", ".wmf", ".mpeg", ".webm"})
        Me.FilterComboBox.Location = New System.Drawing.Point(7, 286)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(136, 22)
        Me.FilterComboBox.TabIndex = 12
        '
        'FilterLabel
        '
        Me.FilterLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FilterLabel.AutoSize = True
        Me.FilterLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterLabel.ForeColor = System.Drawing.Color.LightGray
        Me.FilterLabel.Location = New System.Drawing.Point(4, 270)
        Me.FilterLabel.Name = "FilterLabel"
        Me.FilterLabel.Size = New System.Drawing.Size(33, 14)
        Me.FilterLabel.TabIndex = 9
        Me.FilterLabel.Text = "Filter:"
        '
        'TotalFilesLabel
        '
        Me.TotalFilesLabel.AutoSize = True
        Me.TotalFilesLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalFilesLabel.ForeColor = System.Drawing.Color.LightGray
        Me.TotalFilesLabel.Location = New System.Drawing.Point(4, 3)
        Me.TotalFilesLabel.Name = "TotalFilesLabel"
        Me.TotalFilesLabel.Size = New System.Drawing.Size(39, 15)
        Me.TotalFilesLabel.TabIndex = 8
        Me.TotalFilesLabel.Text = "Total: "
        '
        'CacheExplorerList
        '
        Me.CacheExplorerList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CacheExplorerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CacheExplorerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CacheExplorerList.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CacheExplorerList.ForeColor = System.Drawing.Color.LightGray
        Me.CacheExplorerList.FormattingEnabled = True
        Me.CacheExplorerList.HorizontalScrollbar = True
        Me.CacheExplorerList.IntegralHeight = False
        Me.CacheExplorerList.ItemHeight = 14
        Me.CacheExplorerList.Location = New System.Drawing.Point(7, 20)
        Me.CacheExplorerList.Name = "CacheExplorerList"
        Me.CacheExplorerList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.CacheExplorerList.Size = New System.Drawing.Size(136, 246)
        Me.CacheExplorerList.TabIndex = 7
        '
        'ImageSizeModeStrip
        '
        Me.ImageSizeModeStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenuItem, Me.CenterImageToolStripMenuItem, Me.NormalToolStripMenuItem, Me.StretchImageToolStripMenuItem})
        Me.ImageSizeModeStrip.Name = "ContextMenuStrip1"
        Me.ImageSizeModeStrip.Size = New System.Drawing.Size(156, 92)
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ZoomToolStripMenuItem.Text = "Zoom (Default)"
        '
        'CenterImageToolStripMenuItem
        '
        Me.CenterImageToolStripMenuItem.Name = "CenterImageToolStripMenuItem"
        Me.CenterImageToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CenterImageToolStripMenuItem.Text = "Center Image"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'StretchImageToolStripMenuItem
        '
        Me.StretchImageToolStripMenuItem.Name = "StretchImageToolStripMenuItem"
        Me.StretchImageToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.StretchImageToolStripMenuItem.Text = "Stretch Image"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Please Select a cache folder"
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.LocalApplicationData
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(155, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Please wait... Files Copied: 0"
        Me.Label3.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(155, 82)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(534, 25)
        Me.ProgressBar1.TabIndex = 9
        Me.ProgressBar1.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'ImageDisplay
        '
        Me.ImageDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageDisplay.ContextMenuStrip = Me.ImageSizeModeStrip
        Me.ImageDisplay.Location = New System.Drawing.Point(150, 53)
        Me.ImageDisplay.Name = "ImageDisplay"
        Me.ImageDisplay.Size = New System.Drawing.Size(551, 315)
        Me.ImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageDisplay.TabIndex = 1
        Me.ImageDisplay.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(701, 436)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.PlainTextBox)
        Me.Controls.Add(Me.ImageDisplay)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(717, 387)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cache Explorer - LunarHunter 2019"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ImageSizeModeStrip.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageDisplay As PictureBox
    Friend WithEvents ScanCachebutton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExportButt As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PlainTextBox As RichTextBox
    Friend WithEvents OpenTypeLabel As Label
    Friend WithEvents OpenTypeCheck As ComboBox
    Friend WithEvents DeleteALLbutton As Button
    Friend WithEvents SecureDeleteButton As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AutoPlayTimer As Timer
    Friend WithEvents AutoPlayCheck As CheckBox
    Friend WithEvents OverrideCheck As CheckBox
    Friend WithEvents ClearCacheButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents BuildInformationLabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TotalFilesLabel As Label
    Friend WithEvents CacheExplorerList As ListBox
    Friend WithEvents FilterLabel As Label
    Friend WithEvents CacheListBackup As ListBox
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ImageSizeModeStrip As ContextMenuStrip
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CenterImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StretchImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeCacheFoldButton As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents AboutButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents UpdateAvailable As LinkLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents UnableUpdates As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
