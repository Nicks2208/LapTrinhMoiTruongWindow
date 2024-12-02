using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_03;
namespace Lab01_03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chương trinh quan ly sinh vien và giao vien:");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Them giao vien");
                Console.WriteLine("3. Xuat danh sach sinh vien");
                Console.WriteLine("4. Xuat danh sach giao vien");
                Console.WriteLine("5. So luong tung danh sach");
                Console.WriteLine("6. Xuat danh sach sinh vien thuoc khoa 'CNTT'");
                Console.WriteLine("7. Xuat danh sach giao viên co đia chi chua 'Quan 9'");
                Console.WriteLine("8. Sinh viên co điem trung binh cao nhat và thuoc khoa 'CNTT'");
                Console.WriteLine("9. So luong sinh viên theo xep loai");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent(studentList);
                        break;
                    case 2:
                        AddTeacher(teacherList);
                        break;
                    case 3:
                        ShowStudents(studentList);
                        break;
                    case 4:
                        ShowTeachers(teacherList);
                        break;
                    case 5:
                        ShowCounts(teacherList, studentList);
                        break;
                    case 6:
                        ShowStudentsByKhoa(studentList, "CNTT");
                        break;
                    case 7:
                        ShowTeachersByAddress(teacherList, "Quan 9");
                        break;
                    case 8:
                        ShowTopStudentInCNTT(studentList);
                        break;
                    case 9:
                        ShowRankCount(studentList);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Tùy chon khong hop le. Vui lòng chon lai.");
                        break;
                }
                Console.WriteLine("Nhan Enter de tiep tuc...");
                Console.ReadLine();
            }
        }

        private static void AddStudent(List<Student>  studentList)
        {
            Console.Write("> Nhap ma so sinh viên: ");
            string maSo = Console.ReadLine();
            Console.Write("> Nhap ho ten sinh viên: ");
            string hoTen = Console.ReadLine();
            Console.Write("> Nhap diem trung binh: ");
            double diemTrungBinh = double.Parse(Console.ReadLine());
            Console.Write("> Nhap khoa: ");
            string khoa = Console.ReadLine();

            studentList.Add(new Student(maSo, hoTen, diemTrungBinh, khoa));
            Console.WriteLine("[+] Da them sinh vien.");
        }

        private static void AddTeacher(List<Teacher>  teacherList)
        {
            Console.Write("> Nhap ma so giao vien: ");
            string maSo = Console.ReadLine();
            Console.Write("> Nhap ho ten giao vien: ");
            string hoTen = Console.ReadLine();
            Console.Write("> Nhap dia chi giao vien: ");
            string diaChi = Console.ReadLine();

            teacherList.Add(new Teacher(maSo, hoTen, diaChi));
            Console.WriteLine("[+] Da them giao vien.");
        }

        private static void ShowStudents(List<Student> studentList)
        {
            Console.WriteLine("Danh sach sinh vien:");
            foreach (var student in studentList)
            {
                student.ShowInfo();
            }
        }

        private static void ShowTeachers(List<Teacher> teacherList)
        {
            Console.WriteLine("Danh sach giao vien:");
            foreach (var teacher in teacherList)
            {
                teacher.ShowInfo();
            }
        }

        private static void ShowCounts(List<Teacher> teacherList, List<Student> studentList)
        {
            Console.WriteLine($"Tong so sinh vien: {studentList.Count}");
            Console.WriteLine($"Tong so giao vien: {teacherList.Count}");
        }

        private static void ShowStudentsByKhoa(List<Student> studentList, string khoa)
        {
            Console.WriteLine($"Danh sach sinh viên khoa {khoa}:");
            var filteredStudents = studentList.Where(s => s.Khoa == khoa).ToList();
            foreach (var student in filteredStudents)
            {
                student.ShowInfo();
            }
        }

        private static void ShowTeachersByAddress(List<Teacher> teacherList, string address)
        {
            Console.WriteLine($"Danh sach giao vien có đia chi chua '{address}':");
            var filteredTeachers = teacherList.Where(t => t.DiaChi.Contains(address)).ToList();
            foreach (var teacher in filteredTeachers)
            {
                teacher.ShowInfo();
            }
        }

        private static void ShowTopStudentInCNTT(List<Student> studentList)
        {
            var topStudent = studentList
                .Where(s => s.Khoa == "CNTT")
                .OrderByDescending(s => s.DiemTrungBinh)
                .FirstOrDefault();

            if (topStudent != null)
            {
                Console.WriteLine("Sinh viên có diem trung binh cao nhat trong khoa CNTT:");
                topStudent.ShowInfo();
            }
            else
            {
                Console.WriteLine("Khong có sinh viên thuoc khoa CNTT.");
            }
        }

        private static void ShowRankCount(List<Student> studentList)
        {
            int xuatsac = 0;
            int gioi = 0;
            int kha = 0;
            int trungbinh = 0;
            int kem = 0;

            foreach (var student in studentList)
            {
                if (student.DiemTrungBinh >= 9.0f && student.DiemTrungBinh <= 10.0f)
                {
                    xuatsac++;
                }
                else if (student.DiemTrungBinh >= 8.0f && student.DiemTrungBinh < 9.0f)
                {
                    gioi++;
                }
                else if (student.DiemTrungBinh >= 6.5f && student.DiemTrungBinh < 8.0f)
                {
                    kha++;
                }
                else if (student.DiemTrungBinh >= 5.0f && student.DiemTrungBinh < 6.5f)
                {
                    trungbinh++;
                }
                else
                {
                    kem++;
                }
            }

            Console.WriteLine("=== So luong sinh vien theo xep loai ===");
            Console.WriteLine("Loai Xuat Sac (9.0 - 10.0): " + xuatsac);
            Console.WriteLine("Loai Gioi (8.0 - 9.0): " + gioi);
            Console.WriteLine("Loai Kha (6.5 - 8.0): " + kem);
            Console.WriteLine("Loai Trung Bình (5.0 - 6.5): " + trungbinh);
            Console.WriteLine("Loai Yếu (< 5.0): " + kem);
        }
    }
}
