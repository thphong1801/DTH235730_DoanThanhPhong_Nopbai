using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class GiaiThuaN
    {
        public int NhapMotSo()
        {
            int so;
            do
            {
                so= Convert.ToInt32(Console.ReadLine());
            }while (so < 0);
            return so;
        }
        public long TinhGiaiThua(int h)
        {
            long gt = 1;
             for(int i=1; i<=h; i++)
            {
                gt = gt * i;
            }
            return gt;
        }
    }
}
