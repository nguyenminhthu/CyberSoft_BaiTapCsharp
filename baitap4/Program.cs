//Bài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT
// Yêu cầu người dùng nhập vào số tiền gốc và tỷ lệ thuế VAT (ví dụ: 10%).
// Tính và in ra tổng số tiền sau khi đã cộng thêm thuế.


decimal soTienGoc = 0;
double tyLeThue = 0;
decimal tongSoTien = 0;

Console.Write("Nhập số tiền gốc: ");
soTienGoc = Convert.ToDecimal(Console.ReadLine());

Console.Write("Nhập tỷ lệ thuế (%): ");
tyLeThue = Convert.ToDouble(Console.ReadLine());

tongSoTien = soTienGoc * (1 + (decimal)tyLeThue/100);

Console.WriteLine($"Tổng số tiền sau khi tính thuế: {tongSoTien}");