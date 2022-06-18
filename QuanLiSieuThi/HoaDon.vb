Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class HoaDon
    Dim con As SqlConnection = New SqlConnection("Data Source=ADMIN;Initial Catalog=QuanLySieuThi;Integrated Security=True")

    Private Sub Load_Data()

        txtMaHD.Enabled = False
    End Sub
    Private Sub HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
        Xuat_HoaDon()
    End Sub

    'Hiển thị db Hóa Đơn
    Private WithEvents dsHD As BindingManagerBase
    Private Sub Xuat_HoaDon()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select HD.maHD as N'Mã hóa đơn', HD.ngayTaoHD as N'Ngày tạo hóa đơn', NV.tenNV as N'Nhân viên thanh toán',
	KH.tenKH as N'Tên khách hàng', SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt', 
	format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
        from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
        where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV
        GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("HoaDon")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewHD.DataSource = dttable
        'khoi tao lien ket voi datatable.
        dsHD = Me.BindingContext(dttable)

        txtMaHD.Text = dsHD.Current("Mã hóa đơn")
        txtTenKH.Text = dsHD.Current("Tên khách hàng")
        txtNV.Text = dsHD.Current("Nhân viên thanh toán")
        txtDateHD.Text = dsHD.Current("Ngày tạo hóa đơn")
        txtMaSP.Text = dsHD.Current("Mã sản phẩm")
        txtTT.Text = dsHD.Current("Thành tiền")


    End Sub

    ' Click vào row ở view Hóa Đơn
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim selectedGD As DataGridViewRow
        selectedGD = ViewHD.Rows(e.RowIndex)



    End Sub



    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV, SUM(dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan) AS TongTien
FROM     dbo.ChiTietHoaDon INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietHoaDon.maHD = dbo.HoaDon.maHD INNER JOIN
                  dbo.KhachHang ON dbo.HoaDon.maKH = dbo.KhachHang.maKH INNER JOIN
                  dbo.NhanVien ON dbo.HoaDon.maNV = dbo.NhanVien.maNV INNER JOIN
                  dbo.SanPham ON dbo.ChiTietHoaDon.maSP = dbo.SanPham.maSP
WHERE CONCAT(dbo.HoaDon.maHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV) like '%" & valueToSearch & "%'
GROUP BY dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewHD.DataSource = table
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles InBtn.Click
        ReportHoaDon.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.ViewHD.Width, Me.ViewHD.Height)
        ViewHD.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.ViewHD.Width, Me.ViewHD.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub

    Private Sub ViewHoaDon(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub CellClickHoaDon(sender As Object, e As DataGridViewCellEventArgs) Handles ViewHD.CellClick

    End Sub
End Class