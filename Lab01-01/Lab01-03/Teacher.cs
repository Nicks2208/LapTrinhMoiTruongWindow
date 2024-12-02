using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_03;
namespace Lab01_03
{
    internal class Teacher : Person
    {
        public string DiaChi { get; set; }

        public Teacher(string maSo, string hoTen, string diaChi)
            : base(maSo, hoTen)
        {
            DiaChi = diaChi;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Dia chi: {DiaChi}");
        }
    }
}
