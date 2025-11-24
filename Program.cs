using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();

            int choice;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Thêm giáo viên");
                Console.WriteLine("3. Xuất danh sách sinh viên");
                Console.WriteLine("4. Xuất danh sách giáo viên");
                Console.WriteLine("5. Số lượng sinh viên và giáo viên");
                Console.WriteLine("6. Danh sách sinh viên khoa CNTT");
                Console.WriteLine("7. Danh sách giáo viên ở Quận 9");
                Console.WriteLine("8. Sinh viên điểm cao nhất khoa CNTT");
                Console.WriteLine("9. Số lượng từng xếp loại sinh viên");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Student st = new Student();
                        st.Input();
                        students.Add(st);
                        break;
                    case 2:
                        Teacher t = new Teacher();
                        t.Input();
                        teachers.Add(t);
                        break;
                    case 3:
                        Console.WriteLine("=== Danh sách sinh viên===");
                        foreach (var s in students)
                            s.Output();
                        break;
                    case 4:
                        Console.WriteLine("=== Danh sách giáo viên===");
                        foreach (var teacher in teachers)
                            teacher.Output();
                        break;
                    case 5:
                        Console.WriteLine($"Tổng sinh viên: {students.Count}");
                        Console.WriteLine($"Tổng giáo viên: {teachers.Count}");
                        break;
                    case 6:
                        Console.WriteLine("===Sinh viên thuộc khoa CNTT===");
                        foreach (var s in students)
                        {
                            if (s.Faculty.ToUpper() == "CNTT")
                                s.Output();
                        }
                        break;
                    case 7:
                        Console.WriteLine("===Giáo viên có địa chỉ 'Quận 9'===");
                        foreach (var teacher in teachers)
                        {
                            if (teacher.Address.ToLower().Contains("Quận 9"))
                                teacher.Output();
                        }
                        break;
                    case 8:
                        Console.WriteLine("===Sinh viên có ĐTB cao nhất khoa CNTT===");
                        float max = -1;
                        foreach (var s in students)
                        {
                            if (s.Faculty.ToUpper() == "CNTT" && s.AvgScore > max)
                                s.Output();
                        }
                        break;
                    case 9:
                        int xuatSac = 0, gioi = 0, kha = 0, tb = 0, yeu = 0, kem = 0;

                        foreach (var s in students)
                        {
                            if (s.AvgScore >= 9.0f && s.AvgScore <= 10.0f) xuatSac++;
                            if (s.AvgScore >= 8.0f && s.AvgScore < 9.0f) gioi++;
                            if (s.AvgScore >= 7.0f && s.AvgScore < 8.0f) kha++;
                            if (s.AvgScore >= 5.0f && s.AvgScore < 7.0f) tb++;
                            if (s.AvgScore >= 4.0f && s.AvgScore < 5.0f) yeu++;
                            else kem++;
                        }
                        Console.WriteLine("=== THỐNG KÊ XẾP LOẠI ===");
                        Console.WriteLine($"Xuất sắc (>=9): {xuatSac}");
                        Console.WriteLine($"Giỏi (>=8): {gioi}");
                        Console.WriteLine($"Khá (>=6.5): {kha}");
                        Console.WriteLine($"Trung bình (>=5): {tb}");
                        Console.WriteLine($"Yếu (<5): {yeu}");
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình...");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
