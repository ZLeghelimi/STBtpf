<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estimation
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
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.mse = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.psnr = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.h = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(54, 40)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(283, 25)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Degradation image estimation  "
        '
        'mse
        '
        Me.mse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.mse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.mse.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.mse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mse.Enabled = False
        Me.mse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mse.ForeColor = System.Drawing.Color.White
        Me.mse.HintForeColor = System.Drawing.Color.Empty
        Me.mse.HintText = ""
        Me.mse.isPassword = False
        Me.mse.LineFocusedColor = System.Drawing.Color.Blue
        Me.mse.LineIdleColor = System.Drawing.Color.White
        Me.mse.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.mse.LineThickness = 4
        Me.mse.Location = New System.Drawing.Point(138, 92)
        Me.mse.Margin = New System.Windows.Forms.Padding(4)
        Me.mse.MaxLength = 32767
        Me.mse.Name = "mse"
        Me.mse.Size = New System.Drawing.Size(149, 33)
        Me.mse.TabIndex = 3
        Me.mse.Text = "0.0"
        Me.mse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'psnr
        '
        Me.psnr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.psnr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.psnr.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.psnr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.psnr.Enabled = False
        Me.psnr.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psnr.ForeColor = System.Drawing.Color.White
        Me.psnr.HintForeColor = System.Drawing.Color.Empty
        Me.psnr.HintText = ""
        Me.psnr.isPassword = False
        Me.psnr.LineFocusedColor = System.Drawing.Color.Blue
        Me.psnr.LineIdleColor = System.Drawing.Color.White
        Me.psnr.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.psnr.LineThickness = 4
        Me.psnr.Location = New System.Drawing.Point(138, 133)
        Me.psnr.Margin = New System.Windows.Forms.Padding(4)
        Me.psnr.MaxLength = 32767
        Me.psnr.Name = "psnr"
        Me.psnr.Size = New System.Drawing.Size(149, 33)
        Me.psnr.TabIndex = 4
        Me.psnr.Text = "0.0"
        Me.psnr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'h
        '
        Me.h.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.h.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.h.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.h.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.h.Enabled = False
        Me.h.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h.ForeColor = System.Drawing.Color.White
        Me.h.HintForeColor = System.Drawing.Color.Empty
        Me.h.HintText = ""
        Me.h.isPassword = False
        Me.h.LineFocusedColor = System.Drawing.Color.Blue
        Me.h.LineIdleColor = System.Drawing.Color.White
        Me.h.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.h.LineThickness = 4
        Me.h.Location = New System.Drawing.Point(138, 174)
        Me.h.Margin = New System.Windows.Forms.Padding(4)
        Me.h.MaxLength = 32767
        Me.h.Name = "h"
        Me.h.Size = New System.Drawing.Size(149, 33)
        Me.h.TabIndex = 5
        Me.h.Text = "0.0"
        Me.h.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = Global.STB.My.Resources.Resources.btnClose
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(342, 12)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 12
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(90, 97)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(44, 21)
        Me.GunaLabel2.TabIndex = 13
        Me.GunaLabel2.Text = "MSE"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(78, 137)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(54, 21)
        Me.GunaLabel3.TabIndex = 14
        Me.GunaLabel3.Text = "PSNR"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(108, 181)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(22, 21)
        Me.GunaLabel4.TabIndex = 15
        Me.GunaLabel4.Text = "H"
        '
        'Estimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(372, 236)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.h)
        Me.Controls.Add(Me.psnr)
        Me.Controls.Add(Me.mse)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Estimation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estimation"
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents mse As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents psnr As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents h As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
End Class
