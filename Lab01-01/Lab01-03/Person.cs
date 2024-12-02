using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_03;
namespace Lab01_03
{
    internal class Person
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }

        public Person(string maSo, string hoTen)
        {
            MaSo = maSo;
            HoTen = hoTen;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ma so: {MaSo}, Ho ten: {HoTen}");
        }
    }
}
