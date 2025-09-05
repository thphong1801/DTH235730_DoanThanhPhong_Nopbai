using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class PTBacHai
    {
        // ===== Thuộc tính =====
        private int soa;
        private int sob;
        private int soc;

        public int Soa
        {
            get { return soa; }
            set { soa = value; }
        }

        public int Sob
        {
            get { return sob; }
            set { sob = value; }
        }

        public int Soc
        {
            get { return soc; }
            set { soc = value; }
        }

        // ===== Constructor =====
        public PTBacHai()   // mặc định
        {
            soa = 1;
            sob = 0;
            soc = 0;
        }

        public PTBacHai(int a, int b, int c)
        {
            soa = a;
            sob = b;
            soc = c;
        }

        // ===== Phương thức tính nghiệm =====
        public string GiaiPT()
        {
            if (soa == 0) // về phương trình bậc nhất hoặc vô nghiệm
            {
                if (sob == 0)
                {
                    if (soc == 0)
                        return "Phương trình vô số nghiệm";
                    else
                        return "Phương trình vô nghiệm";
                }
                else
                {
                    double x = -(double)soc / sob;
                    return $"Phương trình bậc nhất, nghiệm: x = {x}";
                }
            }

            double delta = sob * sob - 4 * soa * soc;

            if (delta < 0)
                return "Phương trình vô nghiệm thực";
            else if (delta == 0)
            {
                double x = -(double)sob / (2 * soa);
                return $"Phương trình có nghiệm kép: x1 = x2 = {x}";
            }
            else
            {
                double x1 = (-sob + Math.Sqrt(delta)) / (2 * soa);
                double x2 = (-sob - Math.Sqrt(delta)) / (2 * soa);
                return $"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
            }
        }

        // ===== Hiển thị kết quả =====
        public void HienThi()
        {
            Console.WriteLine($"Phương trình: {soa}x^2 + {sob}x + {soc} = 0");
            Console.WriteLine(GiaiPT());
        }
    }
}
