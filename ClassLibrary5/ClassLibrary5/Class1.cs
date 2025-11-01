using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
    public class Class1
    {
        public static string KiemTraTamGiac(int a, int b, int c)
        {
            // Kiểm tra điều kiện không hợp lệ
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                return "";

            // Tam giác đều
            if (a == b && b == c)
                return "Tam_giac_deu";

            // Tam giác cân
            else if (a == b || b == c || a == c)
            {
                // Tam giác vuông cân
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    return "Tam_giac_vuong_can";
                else
                    return "Tam_giac_can";
            }

            // Tam giác vuông
            else if (a * a + b * b == c * c && a * a + c * c == b * b && b * b + c * c == a * a)
                return "Tam_giac_vuong";

            // Tam giác thường
            else
                return "Tam_giac_thuong";
        }

    }
}
