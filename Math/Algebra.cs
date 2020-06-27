using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Algebra
    {
        // 2차 방정식 근의 공식
        public static (double RootPlus, double RootMinus) GetRootsOfQuadraticEquation(double a, double b, double c)
        {
            var pm = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

            return ((-b + pm) / (2 * a), (-b - pm) / (2 * a));
        }

        // 문자열이 전부 숫자인지 검사
        public static bool IsNumberString(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (!int.TryParse(num[i].ToString(), out int cNum)) return false;
            }
            return true;
        }

        // 아주 큰 수의 덧셈
        public static string SumBigNumber(string num1, string num2)
        {
            if(!IsNumberString(num1) || !IsNumberString(num2))
            {
                throw new Exception("SumBigNumber의 인자값에 숫자가 아닌 문자열이 들어있습니다.");
            }

            var minLen = Math.Min(num1.Length, num2.Length);
            var minNo = num1.Length == minLen ? num1 : num2;
            var maxNo = num1.Length == minLen ? num2 : num1;

            var rMin = string.Concat(minNo.Reverse());
            var rMax = string.Concat(maxNo.Reverse());

            string newNo = "";
            int olim = 0;

            for (int i = 0; i < minLen; i++)
            {
                var nMin = int.Parse(rMin[i].ToString());
                var nMax = int.Parse(rMax[i].ToString());
                var sum = nMin + nMax + olim;

                var nn = sum % 10;
                newNo += nn;
                olim = sum / 10;
            }

            for (int i = minLen; i < maxNo.Length; i++)
            {
                var nMax = int.Parse(rMax[i].ToString());
                var sum = nMax + olim;

                var nn = sum % 10;
                newNo += nn;
                olim = sum / 10;
            }

            if (olim != 0)
                newNo += olim;

            return string.Concat(newNo.Reverse());
        }
    }
}
