
// Bài tập 2: Tính tổng giá trị đơn hàng su khi áp dụng giảm giá.
// Yêu cầu người dùng nhập vào giá trị một đơn hàng và phần trăm giảm giá. Tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dụng giảm giá.

decimal giaTriDonHang;
double phanTramGiamGia ;
decimal soTienGiamGia;
decimal soTienThanhToan;

Console.Write("Vui lòng nhập giá trị đơn hàng: ");
giaTriDonHang = Convert.ToDecimal(Console.ReadLine());

Console.Write("Nhập phần trăm giảm giá: ");
phanTramGiamGia = Convert.ToDouble(Console.ReadLine());

soTienGiamGia = giaTriDonHang*(1-(decimal)phanTramGiamGia/100);
soTienThanhToan = giaTriDonHang - soTienGiamGia;

Console.WriteLine($"Số tiền giảm giá: {soTienGiamGia}");
Console.WriteLine($"Số tiền phải thanh toán: {soTienThanhToan}");
