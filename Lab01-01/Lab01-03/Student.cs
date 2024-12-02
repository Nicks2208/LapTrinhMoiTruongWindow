using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_03;
namespace Lab01_03
{
    internal class Student : Person
{
        public double DiemTrungBinh { get; set; }
        public string Khoa { get; set; }

        public Student(string maSo, string hoTen, double diemTrungBinh, string khoa)
            : base(maSo, hoTen)
        {
            DiemTrungBinh = diemTrungBinh;
            Khoa = khoa;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Diem trung binh: {DiemTrungBinh}, Khoa: {Khoa}");
        }
    }
}
