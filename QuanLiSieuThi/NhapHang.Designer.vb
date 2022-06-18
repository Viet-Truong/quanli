<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhapHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NhapHang))
        Me.ViewNhapHang = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.InBtn = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.emailLB = New System.Windows.Forms.Label()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        CType(Me.ViewNhapHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewNhapHang
        '
        Me.ViewNhapHang.AllowUserToAddRows = False
        Me.ViewNhapHang.AllowUserToDeleteRows = False
        Me.ViewNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewNhapHang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewNhapHang.Location = New System.Drawing.Point(51, 159)
        Me.ViewNhapHang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ViewNhapHang.Name = "ViewNhapHang"
        Me.ViewNhapHang.RowHeadersWidth = 51
        Me.ViewNhapHang.RowTemplate.Height = 24
        Me.ViewNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewNhapHang.Size = New System.Drawing.Size(569, 301)
        Me.ViewNhapHang.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 78)
        Me.Panel2.TabIndex = 8
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(260, 27)
        Me.Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(282, 25)
        Me.Title.TabIndex = 3
        Me.Title.Text = "DANH SÁCH NHẬP HÀNG"
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(310, 108)
        Me.TimBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TimBtn.Name = "TimBtn"
        Me.TimBtn.Size = New System.Drawing.Size(114, 37)
        Me.TimBtn.TabIndex = 42
        Me.TimBtn.Text = "TÌM"
        Me.TimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TimBtn.UseVisualStyleBackColor = False
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.searchText.Location = New System.Drawing.Point(52, 117)
        Me.searchText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(236, 23)
        Me.searchText.TabIndex = 41
        '
        'InBtn
        '
        Me.InBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.InBtn.Location = New System.Drawing.Point(506, 108)
        Me.InBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.InBtn.Name = "InBtn"
        Me.InBtn.Size = New System.Drawing.Size(114, 37)
        Me.InBtn.TabIndex = 46
        Me.InBtn.Text = "BẢNG BIỂU"
        Me.InBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InBtn.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'btnNhap
        '
        Me.btnNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNhap.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnNhap.Location = New System.Drawing.Point(353, 512)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(114, 37)
        Me.btnNhap.TabIndex = 49
        Me.btnNhap.Text = "NHẬP HÀNG"
        Me.btnNhap.UseVisualStyleBackColor = False
        '
        'emailLB
        '
        Me.emailLB.AutoSize = True
        Me.emailLB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.emailLB.Location = New System.Drawing.Point(642, 240)
        Me.emailLB.Name = "emailLB"
        Me.emailLB.Size = New System.Drawing.Size(74, 19)
        Me.emailLB.TabIndex = 52
        Me.emailLB.Text = "Số lượng:"
        '
        'txtSL
        '
        Me.txtSL.BackColor = System.Drawing.SystemColors.Window
        Me.txtSL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSL.Location = New System.Drawing.Point(645, 262)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(115, 26)
        Me.txtSL.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(642, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Mã sản phẩm:"
        '
        'txtMaSP
        '
        Me.txtMaSP.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaSP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSP.Location = New System.Drawing.Point(645, 181)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(115, 26)
        Me.txtMaSP.TabIndex = 53
        '
        'NhapHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(789, 569)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.emailLB)
        Me.Controls.Add(Me.txtSL)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.InBtn)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ViewNhapHang)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "NhapHang"
        Me.Text = "Trung_48_Nhom07"
        CType(Me.ViewNhapHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewNhapHang As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents TimBtn As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents InBtn As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnNhap As Button
    Friend WithEvents emailLB As Label
    Friend WithEvents txtSL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaSP As TextBox
End Class
