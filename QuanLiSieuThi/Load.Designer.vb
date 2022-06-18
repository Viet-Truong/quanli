<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Load
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Load))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MyProgress = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MyProgress.SuspendLayout
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'MyProgress
        '
        Me.MyProgress.Controls.Add(Me.Guna2PictureBox1)
        Me.MyProgress.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.MyProgress.FillThickness = 15
        Me.MyProgress.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MyProgress.ForeColor = System.Drawing.Color.White
        Me.MyProgress.Location = New System.Drawing.Point(145, 152)
        Me.MyProgress.Margin = New System.Windows.Forms.Padding(2)
        Me.MyProgress.Minimum = 0
        Me.MyProgress.Name = "MyProgress"
        Me.MyProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyProgress.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyProgress.ProgressThickness = 15
        Me.MyProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.MyProgress.Size = New System.Drawing.Size(151, 151)
        Me.MyProgress.TabIndex = 4
        Me.MyProgress.Text = "Guna2CircleProgressBar1"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(44, 44)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(65, 67)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Location = New System.Drawing.Point(74, 32)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(294, 53)
        Me.Panel7.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(136, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 26)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "SIÊU THỊ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 26)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "QUẢN LÍ"
        '
        'Load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(441, 371)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.MyProgress)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Load"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Truong_45"
        Me.MyProgress.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MyProgress As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
