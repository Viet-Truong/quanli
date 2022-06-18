Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class NhapHang
    Dim con As SqlConnection = New SqlConnection("Data Source=ADMIN;Initial Catalog=QuanLySieuThi;Integrated Security=True")

    Private Sub NhapHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xuat_NhapHang()
    End Sub

    'Hiển thị db Nhập hàng
    Dim lenh As String
    Private WithEvents dsNH As BindingManagerBase
    Private Sub Xuat_NhapHang()

        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select SP.maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập', ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP
"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("NhapHang")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewNhapHang.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsNH = Me.BindingContext(dttable)

    End Sub

    '' Nhập hàng ->> cập nhật số lượng cho sản phẩm
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        If MsgBox("Bạn có muốn thêm không? ", vbYesNo, "Thêm hàng") = MsgBoxResult.Yes Then
            If txtMaSP.Text = "" Or txtSL.Text = "" Then
                MsgBox("Vùi lòng đủ thông tin")
            Else
                lenh = "update  SanPham  
                        set soLuongCon = soLuongCon + '" & txtSL.Text & "'
                        where maSP = '" & txtMaSP.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_NhapHang()
                MsgBox("Thêm thành công!")
            End If
        End If
    End Sub

    Private Sub ViewNhapHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewNhapHang.CellClick
        Dim selectedGD As DataGridViewRow
        selectedGD = ViewNhapHang.Rows(e.RowIndex)
        txtMaSP.Text = selectedGD.Cells(0).Value
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT dbo.PhieuNhap.maPN, dbo.PhieuNhap.ngayNhapHang, dbo.SanPham.tenSP, dbo.ChiTietPhieuNhap.soLuongNhap,dbo.ChiTietPhieuNhap.donGiaNhap
FROM     dbo.ChiTietPhieuNhap INNER JOIN
                  dbo.PhieuNhap ON dbo.ChiTietPhieuNhap.maPN = dbo.PhieuNhap.maPN INNER JOIN
                  dbo.SanPham ON dbo.ChiTietPhieuNhap.maSP = dbo.SanPham.maSP
WHERE CONCAT(dbo.PhieuNhap.maPN, dbo.SanPham.tenSP) like '%" & valueToSearch & "%'
group by dbo.PhieuNhap .maPN, dbo.PhieuNhap .ngayNhapHang, dbo.SanPham.tenSP, dbo.ChiTietPhieuNhap.soLuongNhap, dbo.ChiTietPhieuNhap.donGiaNhap"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewNhapHang.DataSource = table
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles InBtn.Click
        ReportNhapHang.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.ViewNhapHang.Width, Me.ViewNhapHang.Height)
        ViewNhapHang.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.ViewNhapHang.Width, Me.ViewNhapHang.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub


End Class