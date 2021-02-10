<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuPictureBox3 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Username = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New Bunifu.Framework.UI.BunifuMetroTextbox()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuPictureBox3
        '
        Me.BunifuPictureBox3.AllowFocused = False
        Me.BunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox3.BorderRadius = 50
        Me.BunifuPictureBox3.Image = Global.STB.My.Resources.Resources.btnMinimize
        Me.BunifuPictureBox3.IsCircle = True
        Me.BunifuPictureBox3.Location = New System.Drawing.Point(628, 12)
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
        Me.BunifuPictureBox2.Location = New System.Drawing.Point(652, 12)
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
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(676, 12)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 11
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.STB.My.Resources.Resources.Group_8
        Me.PictureBox1.Image = Global.STB.My.Resources.Resources.Group_7
        Me.PictureBox1.Location = New System.Drawing.Point(-50, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 249)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "Login"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges1
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.IdleBorderRadius = 3
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(393, 278)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.BorderRadius = 3
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 3
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState = StateProperties2
        Me.BunifuButton1.Size = New System.Drawing.Size(210, 45)
        Me.BunifuButton1.TabIndex = 14
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'Username
        '
        Me.Username.BorderColorFocused = System.Drawing.Color.Blue
        Me.Username.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Username.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.Username.BorderThickness = 1
        Me.Username.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Username.isPassword = False
        Me.Username.Location = New System.Drawing.Point(329, 121)
        Me.Username.Margin = New System.Windows.Forms.Padding(4)
        Me.Username.MaxLength = 32767
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(339, 44)
        Me.Username.TabIndex = 18
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(98, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 33)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "STBtp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Secure you data with different mechanism"
        '
        'Password
        '
        Me.Password.BorderColorFocused = System.Drawing.Color.Blue
        Me.Password.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Password.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.Password.BorderThickness = 1
        Me.Password.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Password.isPassword = True
        Me.Password.Location = New System.Drawing.Point(329, 186)
        Me.Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Password.MaxLength = 32767
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(339, 44)
        Me.Password.TabIndex = 21
        Me.Password.Text = "Password"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(706, 395)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.BunifuPictureBox3)
        Me.Controls.Add(Me.BunifuPictureBox2)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuPictureBox3 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Username As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
