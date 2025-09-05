using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class TamGiac
    {
        private int canh1;
        private int canh2;
        private int canh3;

        public int Canh1
        {
            get { return canh1; }
            set { canh1 = value; }
        }

        public int Canh2
        {
            get { return canh2; }
            set { canh2 = value; }
        }

        public int Canh3
        {
            get { return canh3; }
            set { canh3 = value; }
        }

        public int ChuVi
        {
            get { return TinhChuVi(); }
        }

        public float DienTich
        {
            get { return TinhDienTich(); }
        }

        public string LoaiTamGiac
        {
            get { return XacDinhLoai(); }
        }

        // ====== Constructor ======
        public TamGiac()  // mặc định
        {
            this.canh1 = 2;
            this.canh2 = 3;
            this.canh3 = -5;
        }

        public TamGiac(int a, int b, int c)
        {
            this.canh1 = a;
            this.canh2 = b;
            this.canh3 = c;
        }

        // ====== Phương thức ======
        public int TinhChuVi()
        {
            return canh1 + canh2 + canh3;
        }

        public float TinhDienTich()
        {
            float p = (float)TinhChuVi() / 2;
            double s = Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
            return (float)s;
        }

        private string XacDinhLoai()
        {
            if (!KiemTraHopLe())
                return "Không phải tam giác";

            if (canh1 == canh2 && canh2 == canh3)
                return "Tam giác đều";
            else if (canh1 == canh2 || canh2 == canh3 || canh1 == canh3)
                return "Tam giác cân";
            else if (canh1 * canh1 + canh2 * canh2 == canh3 * canh3 ||
                     canh1 * canh1 + canh3 * canh3 == canh2 * canh2 ||
                     canh2 * canh2 + canh3 * canh3 == canh1 * canh1)
                return "Tam giác vuông";
            else
                return "Tam giác thường";
        }

        private bool KiemTraHopLe()
        {
            return (canh1 > 0 && canh2 > 0 && canh3 > 0 &&
                    canh1 + canh2 > canh3 &&
                    canh1 + canh3 > canh2 &&
                    canh2 + canh3 > canh1);
        }

        public void HienThi()
        {
            Console.WriteLine("Cạnh 1: " + canh1);
            Console.WriteLine("Cạnh 2: " + canh2);
            Console.WriteLine("Cạnh 3: " + canh3);

            if (KiemTraHopLe())
            {
                Console.WriteLine("Chu vi: " + ChuVi);
                Console.WriteLine("Diện tích: " + DienTich);
                Console.WriteLine("Loại: " + LoaiTamGiac);
            }
            else
            {
                Console.WriteLine("Ba cạnh không tạo thành tam giác hợp lệ.");
            }
        }
    }
}
