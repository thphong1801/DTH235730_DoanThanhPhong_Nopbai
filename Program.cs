using System.Text;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PTBacHai pt1 = new PTBacHai(); // mặc định 1x^2 = 0
            pt1.HienThi();

            Console.WriteLine("==============");

            PTBacHai pt2 = new PTBacHai(1, -3, 2); // x^2 - 3x + 2 = 0
            pt2.HienThi();

            Console.WriteLine("==============");

            PTBacHai pt3 = new PTBacHai(0, 2, -4); // bậc nhất: 2x - 4 = 0
            pt3.HienThi();
        }
    }

}