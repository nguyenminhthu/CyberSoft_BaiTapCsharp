// Bài tập 1: Tính số ngày trong tuần
// Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao nhiêu ngày lẻ còn lại. 
// ví dụ, nếu người dùng nhập vào 10 ngày, kết quả sẽ là 1 tuần và 3 ngày.

int soNgay = 0;
int soTuan = 0;
int soNgayLe = 0;

Console.Write("Vui lòng nhập số ngày: ");
soNgay = Convert.ToInt32(Console.ReadLine());
soTuan = soNgay / 7;
soNgayLe = soNgay % 7;

Console.WriteLine($"{soTuan} tuần và {soNgayLe} ngày");
