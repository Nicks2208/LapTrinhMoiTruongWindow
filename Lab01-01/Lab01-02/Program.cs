using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_02;

namespace Lab01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Them sinh viên");
                Console.WriteLine("2. Hien thi danh sách sinh viên");
                Console.WriteLine("3. Xuat thong tin cac sinh vien thuoc khoa CNTT");
                Console.WriteLine("4. Xuat thong tin sv co diem trung binh hon 5");
                Console.WriteLine("5. Xuat ds sinh vien theo diem trung binh tang dan");
                Console.WriteLine("6. Xuat ra danh sach sinh viên có điem TB lon hơn bang 5 và thuoc khoa CNTT");
                Console.WriteLine("7. Xuat ra danh sách sinh viên có điem trung bình cao nhat và thuoc khoa CNTT");
                Console.WriteLine("8. Hay cho biet so luong cua tung xep loai trong danh sach? Biet rang theo thang\r\ndiem 10.");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang (0-8): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;
                    case "1":
                        AddStudent(studentList);
                        break;
                    case "2":
                        DisplayStudentList(studentList);
                        break;
                    case "3":
                        DisplayStudentsByFaculty(studentList, "CNTT");
                        break;
                    case "4":
                        DisplayStudentsWithHighAverageScore(studentList, 5);
                        break;
                    case "5":
                        SortStudentsByAverageScore(studentList);
                        break;
                    case "6":
                        DisplayStudentsByFacultyAndScore(studentList, "CNTT", 5);
                        break;
                    case "7":
                        DisplayStudentsWithHighestAverageScoreByFaculty(studentList, "CNTT");
                        break;
                    case "8":
                        DisplayClassificationCounts(studentList);
                        break;

                    default:
                        Console.WriteLine("Tùy chon khong hop le. Vui lòng chon lai.");
                        break;
                }
                Console.ReadKey();
            }
        }
        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("=== Nhap thông tin sinh viên ===");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Them sinh viên thành công!");
        }
        static void DisplayStudentList(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sach chi tiet thông tin sinh viên ===");
            foreach (Student student in studentList)
            {
                student.Show();
            }
        }
        static void DisplayStudentsByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Danh sach sinh vien thuoc khoa {0}", faculty);
            var students = studentList.Where(s => s.Faculty.Equals(faculty,
            StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }
        //case 4: Xuất ra thông tin sinh viên có điểm TB lớn hơn bằng 5.
        static void DisplayStudentsWithHighAverageScore(List<Student> studentList,
        float minDTB)
        {
            Console.WriteLine("=== Danh sach sinh vien có điwm TB >= {0}", minDTB);
            var students = studentList.Where(s => s.AverageScore >= minDTB).ToList();
            DisplayStudentList(students);
        }
        //case 5: Xuất ra danh sách sinh viên được sắp xếp theo điểm trung bình tăng dần
        static void SortStudentsByAverageScore(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sach sinh vien đuoc sap xep theo điem trung binh tang dan === ");
            var sortedStudents = studentList.OrderBy(s => s.AverageScore).ToList();
            DisplayStudentList(sortedStudents);
        }
        //case 6: DS sinh viên có ĐTB >=5 và thuộc khoa CNTT
        private static void DisplayStudentsByFacultyAndScore(List<Student> studentList, string faculty, float minDTB)
        {
            Console.WriteLine("=== Danh sách sinh viên có điểm TB >= {0} và thuộc khoa {1}", minDTB, faculty);
            List<Student> students = studentList.Where((Student s) => s.AverageScore >= minDTB && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }
        //case 7:
        static void DisplayStudentsWithHighestAverageScoreByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Danh sach sinh vien co diem trung binh cao nhat thuoc khoa {0} ===", faculty);


            var studentsInFaculty = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();


            if (studentsInFaculty.Count > 0)
            {
                float highestAverageScore = studentsInFaculty.Max(s => s.AverageScore);


                var topStudents = studentsInFaculty.Where(s => s.AverageScore == highestAverageScore).ToList();


                foreach (var student in topStudents)
                {
                    student.Show();
                }
            }
            else
            {
                Console.WriteLine("Khong co sinh vien nao thuoc khoa {0}.", faculty);
            }
        }
        //case 8
        static void DisplayClassificationCounts(List<Student> studentList)
        {

            int xuatsac = 0;
            int gioi = 0;
            int kha = 0;
            int trungbinh = 0;
            int kem = 0;

            foreach (var student in studentList)
            {
                if (student.AverageScore >= 9.0f && student.AverageScore <= 10.0f)
                {
                    xuatsac++;
                }
                else if (student.AverageScore >= 8.0f && student.AverageScore < 9.0f)
                {
                    gioi++;
                }
                else if (student.AverageScore >= 6.5f && student.AverageScore < 8.0f)
                {
                    kha++;
                }
                else if (student.AverageScore >= 5.0f && student.AverageScore < 6.5f)
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
