
// Bài tập 5: Chuyển đổi đơn vị tiền tệ
// Yêu cầu người dùng nhập vào một số tiền bằng USD và tỷ giá chuyển đổi từ USD sang VND.
// Tính và in ra số tiền tương ứng bằng VND.


int sotienUSD = 0;
int tyGia = 0;
int sotienVND = 0;

Console.Write("Bạn nhập vào số tiền USD: ");
sotienUSD = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhập tỷ giá: ");
tyGia = Convert.ToInt32(Console.ReadLine());

sotienVND = sotienUSD * tyGia;
Console.WriteLine($"\nSố tiền USD: {sotienUSD} đổi ra tiền VND bằng : {sotienVND}\n");
