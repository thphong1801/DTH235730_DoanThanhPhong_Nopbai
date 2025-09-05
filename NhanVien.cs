using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai6
{
    internal class NhanVien
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private static double basicSalary; // thuộc tính dùng chung

        // Constructor
        public NhanVien() { }
        public NhanVien(int id, string name, int yearOfBirth, double salaryLevel)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
        }

        // Getter
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetYearOfBirth()
        {
            return yearOfBirth;
        }

        public double GetIncome()
        {
            return salaryLevel * basicSalary;
        }

        // Setter cho salaryLevel
        public void SetSalaryLevel(double salaryLevel)
        {
            this.salaryLevel = salaryLevel;
        }

        // Setter cho basicSalary (static)
        public static void SetBasicSalary(double basicSalaryValue)
        {
            basicSalary = basicSalaryValue;
        }

        // Input thông tin nhân viên
        public void Input()
        {
            Console.Write("Nhập ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Nhập tên: ");
            name = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            yearOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Nhập bậc lương: ");
            salaryLevel = double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Tên: " + name);
            Console.WriteLine("Năm sinh: " + yearOfBirth);
            Console.WriteLine("Lương cơ bản: " + basicSalary);
            Console.WriteLine("Thu nhập: " + GetIncome());
        }
    }
    
}
