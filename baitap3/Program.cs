// Bài tập 3: Chuyển đổi thời gian từ phút sang giờ và phút.
// Yêu cầu người dùng nhập một số phút và chuyển số phút này thành giờ và phút. Ví dụ, nếu người dùng nhập vào 130 phút, kết quả sẽ là 2 giờ và 10 phút.

int soPhut = 0;
int soGio = 0;
Console.Write("Nhập số phút: ");
soPhut = Convert.ToInt32(Console.ReadLine());

soGio = soPhut/60;
soPhut %= 60;
Console.WriteLine($"Số giờ: {soGio}, số phút: {soPhut}");