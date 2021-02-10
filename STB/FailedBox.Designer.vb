<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FailedBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FailedBox))
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Display = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BunifuLabel1.Location = New System.Drawing.Point(73, 35)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(222, 27)
        Me.BunifuLabel1.TabIndex = 4
        Me.BunifuLabel1.Text = "Image Or Text Invalid"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BunifuLabel1)
        Me.Panel1.Controls.Add(Me.BunifuPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 81)
        Me.Panel1.TabIndex = 2
        '
        'Display
        '
        Me.Display.AllowToggling = False
        Me.Display.AnimationSpeed = 200
        Me.Display.AutoGenerateColors = False
        Me.Display.BackColor = System.Drawing.Color.Transparent
        Me.Display.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.Display.BackgroundImage = CType(resources.GetObject("Display.BackgroundImage"), System.Drawing.Image)
        Me.Display.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Display.ButtonText = "OK"
        Me.Display.ButtonTextMarginLeft = 0
        Me.Display.ColorContrastOnClick = 45
        Me.Display.ColorContrastOnHover = 45
        Me.Display.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.Display.CustomizableEdges = BorderEdges2
        Me.Display.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Display.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Display.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Display.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Display.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Display.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.Display.ForeColor = System.Drawing.Color.White
        Me.Display.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.Display.IconMarginLeft = 11
        Me.Display.IconPadding = 10
        Me.Display.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.Display.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.Display.IdleBorderRadius = 3
        Me.Display.IdleBorderThickness = 1
        Me.Display.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.Display.IdleIconLeftImage = Nothing
        Me.Display.IdleIconRightImage = Nothing
        Me.Display.IndicateFocus = False
        Me.Display.Location = New System.Drawing.Point(104, 93)
        Me.Display.Name = "Display"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.BorderRadius = 3
        StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.Display.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 3
        StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.Display.OnPressedState = StateProperties4
        Me.Display.Size = New System.Drawing.Size(95, 35)
        Me.Display.TabIndex = 3
        Me.Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Display.TextMarginLeft = 0
        Me.Display.UseDefaultRadiusAndThickness = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STB.My.Resources.Resources.report
        Me.PictureBox1.Location = New System.Drawing.Point(15, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = Global.STB.My.Resources.Resources.btnClose
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(283, 0)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 3
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'FailedBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 131)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FailedBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FailedBox"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Display As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Panel1 As Panel
End Class
