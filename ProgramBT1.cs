using BaiTapB1;
/*
Tìm từ dài nhất
Đề bài: Viết một hàm nhận vào một chuỗi s, trả về từ dài nhất trong chuỗi đó. Nếu có nhiều từ có độ dài bằng
nhau, trả về từ đầu tiên tìm thấy.
Ví dụ:
Input: "I love programming"
Output: "programming"
*/

Console.Write("Nhập vào một chuỗi: ");
string s = Console.ReadLine();

    
string tuDaiNhat = MethodBaiTapB1.TimTuDaiNhat(s);

Console.WriteLine($"Từ dài nhất là: {tuDaiNhat}");


