<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HoaDon))
        Me.ViewHD = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.txtNV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDateHD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.InBtn = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ViewHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewHD
        '
        Me.ViewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewHD.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewHD.Location = New System.Drawing.Point(48, 318)
        Me.ViewHD.Margin = New System.Windows.Forms.Padding(2)
        Me.ViewHD.Name = "ViewHD"
        Me.ViewHD.RowHeadersWidth = 51
        Me.ViewHD.RowTemplate.Height = 24
        Me.ViewHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewHD.Size = New System.Drawing.Size(680, 240)
        Me.ViewHD.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 78)
        Me.Panel2.TabIndex = 6
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(274, 27)
        Me.Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(252, 25)
        Me.Title.TabIndex = 3
        Me.Title.Text = "DANH SÁCH HÓA ĐƠN"
        '
        'txtNV
        '
        Me.txtNV.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtNV.Location = New System.Drawing.Point(478, 142)
        Me.txtNV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNV.Name = "txtNV"
        Me.txtNV.Size = New System.Drawing.Size(204, 23)
        Me.txtNV.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(352, 145)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Nhân viên phụ trách:"
        '
        'txtTenKH
        '
        Me.txtTenKH.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenKH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtTenKH.Location = New System.Drawing.Point(478, 95)
        Me.txtTenKH.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(204, 23)
        Me.txtTenKH.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(352, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Tên khách hàng:"
        '
        'txtDateHD
        '
        Me.txtDateHD.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateHD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtDateHD.Location = New System.Drawing.Point(218, 142)
        Me.txtDateHD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDateHD.Name = "txtDateHD"
        Me.txtDateHD.Size = New System.Drawing.Size(104, 23)
        Me.txtDateHD.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(109, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Ngày tạo hóa đơn:"
        '
        'txtMaHD
        '
        Me.txtMaHD.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtMaHD.Location = New System.Drawing.Point(218, 95)
        Me.txtMaHD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(104, 23)
        Me.txtMaHD.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(109, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Mã hóa đơn:"
        '
        'txtTT
        '
        Me.txtTT.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtTT.Location = New System.Drawing.Point(478, 187)
        Me.txtTT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTT.Name = "txtTT"
        Me.txtTT.Size = New System.Drawing.Size(204, 23)
        Me.txtTT.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(352, 192)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Thành tiền:"
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(307, 262)
        Me.TimBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.TimBtn.Name = "TimBtn"
        Me.TimBtn.Size = New System.Drawing.Size(114, 37)
        Me.TimBtn.TabIndex = 44
        Me.TimBtn.Text = "TÌM"
        Me.TimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TimBtn.UseVisualStyleBackColor = False
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.searchText.Location = New System.Drawing.Point(48, 271)
        Me.searchText.Margin = New System.Windows.Forms.Padding(2)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(236, 23)
        Me.searchText.TabIndex = 43
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
        'InBtn
        '
        Me.InBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.InBtn.Location = New System.Drawing.Point(614, 262)
        Me.InBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.InBtn.Name = "InBtn"
        Me.InBtn.Size = New System.Drawing.Size(114, 37)
        Me.InBtn.TabIndex = 45
        Me.InBtn.Text = "BẢNG BIỂU"
        Me.InBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InBtn.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'txtMaSP
        '
        Me.txtMaSP.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtMaSP.Location = New System.Drawing.Point(218, 189)
        Me.txtMaSP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(104, 23)
        Me.txtMaSP.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(109, 193)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Mã sản phẩm:"
        '
        'HoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(789, 569)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.InBtn)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.txtTT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDateHD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ViewHD)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "HoaDon"
        Me.Text = "Trung_48_Nhom07"
        CType(Me.ViewHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewHD As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents txtNV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDateHD As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TimBtn As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents InBtn As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label6 As Label
End Class
