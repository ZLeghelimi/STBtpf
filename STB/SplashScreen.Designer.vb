<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuPictureBox3 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 247)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 13)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(81, 13)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.STB.My.Resources.Resources.Group_72
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(111, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 92)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(271, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "STBtp"
        '
        'BunifuPictureBox3
        '
        Me.BunifuPictureBox3.AllowFocused = False
        Me.BunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox3.BorderRadius = 50
        Me.BunifuPictureBox3.Image = Global.STB.My.Resources.Resources.btnMinimize
        Me.BunifuPictureBox3.IsCircle = True
        Me.BunifuPictureBox3.Location = New System.Drawing.Point(521, 12)
        Me.BunifuPictureBox3.Name = "BunifuPictureBox3"
        Me.BunifuPictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.BunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox3.TabIndex = 13
        Me.BunifuPictureBox3.TabStop = False
        Me.BunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'BunifuPictureBox2
        '
        Me.BunifuPictureBox2.AllowFocused = False
        Me.BunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox2.BorderRadius = 50
        Me.BunifuPictureBox2.Image = Global.STB.My.Resources.Resources.btnMaximize
        Me.BunifuPictureBox2.IsCircle = True
        Me.BunifuPictureBox2.Location = New System.Drawing.Point(545, 12)
        Me.BunifuPictureBox2.Name = "BunifuPictureBox2"
        Me.BunifuPictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.BunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox2.TabIndex = 12
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
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(569, 12)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 11
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(192, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 36)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "LOADING..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(599, 260)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuPictureBox3)
        Me.Controls.Add(Me.BunifuPictureBox2)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuPictureBox3 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
