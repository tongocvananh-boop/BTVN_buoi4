namespace BaiTapB1;
/*
Tìm từ dài nhất
Đề bài: Viết một hàm nhận vào một chuỗi s, trả về từ dài nhất trong chuỗi đó. Nếu có nhiều từ có độ dài bằng
nhau, trả về từ đầu tiên tìm thấy.
Ví dụ:
Input: "I love programming"
Output: "programming"
*/
public class MethodBaiTapB1
{
    public static string TimTuDaiNhat(string s)
    {
        string tu = "";        
        string tuDaiNhat = ""; 

        for (int i = 0; i < s.Length; i++)
        {
            char kyTu = s[i];

            if (kyTu != ' ')
            {
                tu += kyTu;
            }
            else
            {
                if (tu.Length > tuDaiNhat.Length)
                {
                    tuDaiNhat = tu;
                }

                tu = "";
            }
        }

        if (tu.Length > tuDaiNhat.Length)
        {
            tuDaiNhat = tu;
        }

        return tuDaiNhat;
    }
}