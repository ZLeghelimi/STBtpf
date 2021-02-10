<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cryptography = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuPictureBox3 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.textHeader = New System.Windows.Forms.Label()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Cryptography)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 555)
        Me.Panel1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Image = Global.STB.My.Resources.Resources._001_fingerprint_scan
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 336)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(215, 70)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Biometrics"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 409)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(215, 70)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "About"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.STB.My.Resources.Resources.Group_72
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = Global.STB.My.Resources.Resources._003_data
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(-1, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(215, 70)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Watermarking"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STBtp"
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Image = Global.STB.My.Resources.Resources._002_logout
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(3, 480)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(215, 70)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Logout"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = Global.STB.My.Resources.Resources._001_folder
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 70)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Steganography"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.STB.My.Resources.Resources._001_cryptography1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 70)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cryptography"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cryptography
        '
        Me.Cryptography.FlatAppearance.BorderSize = 0
        Me.Cryptography.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cryptography.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cryptography.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cryptography.Image = Global.STB.My.Resources.Resources._001_home
        Me.Cryptography.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cryptography.Location = New System.Drawing.Point(0, 51)
        Me.Cryptography.Name = "Cryptography"
        Me.Cryptography.Size = New System.Drawing.Size(209, 70)
        Me.Cryptography.TabIndex = 2
        Me.Cryptography.Text = "HOME"
        Me.Cryptography.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cryptography.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.BunifuPictureBox3)
        Me.Panel2.Controls.Add(Me.textHeader)
        Me.Panel2.Controls.Add(Me.BunifuPictureBox2)
        Me.Panel2.Controls.Add(Me.BunifuPictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(222, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(645, 30)
        Me.Panel2.TabIndex = 1
        '
        'BunifuPictureBox3
        '
        Me.BunifuPictureBox3.AllowFocused = False
        Me.BunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox3.BorderRadius = 50
        Me.BunifuPictureBox3.Image = Global.STB.My.Resources.Resources.btnMinimize
        Me.BunifuPictureBox3.IsCircle = True
        Me.BunifuPictureBox3.Location = New System.Drawing.Point(567, 6)
        Me.BunifuPictureBox3.Name = "BunifuPictureBox3"
        Me.BunifuPictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.BunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox3.TabIndex = 9
        Me.BunifuPictureBox3.TabStop = False
        Me.BunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'textHeader
        '
        Me.textHeader.AutoSize = True
        Me.textHeader.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textHeader.ForeColor = System.Drawing.Color.White
        Me.textHeader.Location = New System.Drawing.Point(15, 6)
        Me.textHeader.Name = "textHeader"
        Me.textHeader.Size = New System.Drawing.Size(53, 18)
        Me.textHeader.TabIndex = 0
        Me.textHeader.Text = "HOME"
        '
        'BunifuPictureBox2
        '
        Me.BunifuPictureBox2.AllowFocused = False
        Me.BunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox2.BorderRadius = 50
        Me.BunifuPictureBox2.Image = Global.STB.My.Resources.Resources.btnMaximize
        Me.BunifuPictureBox2.IsCircle = True
        Me.BunifuPictureBox2.Location = New System.Drawing.Point(591, 6)
        Me.BunifuPictureBox2.Name = "BunifuPictureBox2"
        Me.BunifuPictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.BunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox2.TabIndex = 8
        Me.BunifuPictureBox2.TabStop = False
        Me.BunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = Global.STB.My.Resources.Resources.btnClose
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(615, 6)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 2
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'pnlContainer
        '
        Me.pnlContainer.Location = New System.Drawing.Point(228, 46)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(627, 497)
        Me.pnlContainer.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 555)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STB"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cryptography As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents BunifuPictureBox3 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents textHeader As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button6 As Button
End Class
