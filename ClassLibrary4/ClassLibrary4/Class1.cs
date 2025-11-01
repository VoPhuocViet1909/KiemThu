using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class Class1
    {
        public bool CheckTriangle(int a, int b, int c)
        {
            bool result;

            // Ném Exception nếu có cạnh ≤ 0
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Cạnh không được nhỏ hơn hoặc bằng 0!");

            // Kiểm tra điều kiện tam giác
            if (a + b > c)
                if (a + c > b)
                    if (b + c > a)
                        result = true;
                    else
                        result = false;
                else
                    result = false;
            else
                result = false;

            return result;
        }
    }
}
