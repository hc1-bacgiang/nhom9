// BadSchoolProgram.cs
// Chương trình quản lý trường học bằng C# cực kỳ BAD CODE
// Gồm: Sinh viên, Giáo viên, Môn học, Đăng ký, Điểm
// Tất cả lưu bằng List<string> kiểu "id|field1|field2|..."

using System;
using System.Collections.Generic;

public class BadSchoolProgram
{
    public static void Main(string[] args)
    {
        List<string> students = new List<string>();
        List<string> teachers = new List<string>();
        List<string> courses = new List<string>();
        List<string> enrollments = new List<string>();
        List<string> grades = new List<string>();

        int menu = 0;
        while (menu != 99)
        {
            Console.WriteLine("============= MENU CHINH =============");
            Console.WriteLine("1. Quan ly Sinh vien");
            Console.WriteLine("2. Quan ly Giao vien");
            Console.WriteLine("3. Quan ly Mon hoc");
            Console.WriteLine("4. Quan ly Dang ky hoc");
            Console.WriteLine("5. Quan ly Diem");
            Console.WriteLine("6. Bao cao tong hop");
            Console.WriteLine("99. Thoat");
            Console.Write("Nhap lua chon: ");
            menu = int.Parse(Console.ReadLine());

            // ================== QUẢN LÝ SINH VIÊN ==================
            if (menu == 1)
            {
                int smenu = 0;
                while (smenu != 9)
                {
                    Console.WriteLine("--- QUAN LY SINH VIEN ---");
                    Console.WriteLine("1. Them SV");
                    Console.WriteLine("2. Xoa SV");
                    Console.WriteLine("3. Cap nhat SV");
                    Console.WriteLine("4. Hien thi tat ca SV");
                    Console.WriteLine("5. Tim SV theo ten");
                    Console.WriteLine("6. Tim SV GPA > 8");
                    Console.WriteLine("7. Sap xep theo ten");
                    Console.WriteLine("8. Sap xep theo GPA");
                    Console.WriteLine("9. Quay lai");
                    smenu = int.Parse(Console.ReadLine());

                    if (smenu == 1)
                    {
                        Console.Write("Nhap id: ");
                        string id = Console.ReadLine();
                        Console.Write("Nhap ten: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhap tuoi: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Nhap GPA: ");
                        double gpa = double.Parse(Console.ReadLine());
                        students.Add(id + "|" + name + "|" + age + "|" + gpa);
                    }
                    else if (smenu == 2)
                    {
                        Console.Write("Nhap id can xoa: ");
                        string id = Console.ReadLine();
                        for (int i = 0; i < students.Count; i++)
                        {
                            string[] parts = students[i].Split('|');
                            if (parts[0] == id)
                            {
                                students.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    else if (smenu == 3)
                    {
                        Console.Write("Nhap id can cap nhat: ");
                        string id = Console.ReadLine();
                        for (int i = 0; i < students.Count; i++)
                        {
                            string[] parts = students[i].Split('|');
                            if (parts[0] == id)
                            {
                                Console.Write("Nhap ten moi: ");
                                string name = Console.ReadLine();
                                Console.Write("Nhap tuoi moi: ");
                                int age = int.Parse(Console.ReadLine());
                                Console.Write("Nhap GPA moi: ");
                                double gpa = double.Parse(Console.ReadLine());
                                students[i] = id + "|" + name + "|" + age + "|" + gpa;
                            }
                        }
                    }
                    else if (smenu == 4)
                    {
                        foreach (var s in students)
                        {
                            string[] p = s.Split('|');
                            Console.WriteLine("ID:" + p[0] + " Name:" + p[1] + " Age:" + p[2] + " GPA:" + p[3]);
                        }
                    }
                    else if (smenu == 5)
                    {
                        Console.Write("Nhap ten: ");
                        string name = Console.ReadLine();
                        foreach (var s in students)
                        {
                            string[] p = s.Split('|');
                            if (p[1] == name)
                            {
                                Console.WriteLine("Tim thay: " + s);
                            }
                        }
                    }
                    else if (smenu == 6)
                    {
                        foreach (var s in students)
                        {
                            string[] p = s.Split('|');
                            if (double.Parse(p[3]) > 8.0)
                            {
                                Console.WriteLine("Sinh vien gioi: " + s);
                            }
                        }
                    }
                    else if (smenu == 7)
                    {
                        for (int i = 0; i < students.Count; i++)
                        {
                            for (int j = 0; j < students.Count - 1; j++)
                            {
                                string[] p1 = students[j].Split('|');
                                string[] p2 = students[j + 1].Split('|');
                                if (p1[1].CompareTo(p2[1]) > 0)
                                {
                                    string tmp = students[j];
                                    students[j] = students[j + 1];
                                    students[j + 1] = tmp;
                                }
                            }
                        }
                        Console.WriteLine("Da sap xep theo ten.");
                    }
                    else if (smenu == 8)
                    {
                        for (int i = 0; i < students.Count; i++)
                        {
                            for (int j = 0; j < students.Count - 1; j++)
                            {
                                string[] p1 = students[j].Split('|');
                                string[] p2 = students[j + 1].Split('|');
                                if (double.Parse(p1[3]) < double.Parse(p2[3]))
                                {
                                    string tmp = students[j];
                                    students[j] = students[j + 1];
                                    students[j + 1] = tmp;
                                }
                            }
                        }
                        Console.WriteLine("Da sap xep theo GPA.");
                    }
                }
            }

            // ================== QUẢN LÝ GIÁO VIÊN ==================
            else if (menu == 2)
            {
                int smenu = 0;
                while (smenu != 5)
                {
                    Console.WriteLine("--- QUAN LY GIAO VIEN ---");
                    Console.WriteLine("1. Them GV");
                    Console.WriteLine("2. Xoa GV");
                    Console.WriteLine("3. Cap nhat GV");
                    Console.WriteLine("4. Hien thi tat ca GV");
                    Console.WriteLine("5. Quay lai");
                    smenu = int.Parse(Console.ReadLine());

                    if (smenu == 1)
                    {
                        Console.Write("Nhap id GV: ");
                        string id = Console.ReadLine();
                        Console.Write("Nhap ten GV: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhap chuyen mon: ");
                        string major = Console.ReadLine();
                        teachers.Add(id + "|" + name + "|" + major);
                    }
                    else if (smenu == 2)
                    {
                        Console.Write("Nhap id GV can xoa: ");
                        string id = Console.ReadLine();
                        for (int i = 0; i < teachers.Count; i++)
                        {
                            string[] p = teachers[i].Split('|');
                            if (p[0] == id)
                            {
                                teachers.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    else if (smenu == 3)
                    {
                        Console.Write("Nhap id GV cap nhat: ");
                        string id = Console.ReadLine();
                        for (int i = 0; i < teachers.Count; i++)
                        {
                            string[] p = teachers[i].Split('|');
                            if (p[0] == id)
                            {
                                Console.Write("Nhap ten moi: ");
                                string name = Console.ReadLine();
                                Console.Write("Nhap chuyen mon moi: ");
                                string major = Console.ReadLine();
                                teachers[i] = id + "|" + name + "|" + major;
                            }
                        }
                    }
                    else if (smenu == 4)
                    {
                        foreach (var t in teachers)
                        {
                            string[] p = t.Split('|');
                            Console.WriteLine("ID:" + p[0] + " Name:" + p[1] + " Major:" + p[2]);
                        }
                    }
                }
            }

            // ================== QUẢN LÝ MÔN HỌC ==================
            else if (menu == 3)
            {
                int smenu = 0;
                while (smenu != 5)
                {
                    Console.WriteLine("--- QUAN LY MON HOC ---");
                    Console.WriteLine("1. Them MH");
                    Console.WriteLine("2. Xoa MH");
                    Console.WriteLine("3. Cap nhat MH");
                    Console.WriteLine("4. Hien thi tat ca MH");
                    Console.WriteLine("5. Quay lai");
                    smenu = int.Parse(Console.ReadLine());

                    if (smenu == 1)
                    {
                        Console.Write("Nhap id MH: ");
                        string id = Console.ReadLine();
                        Console.Write("Nhap ten MH: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhap so tin chi: ");
                        int tc = int.Parse(Console.ReadLine());
                        courses.Add(id + "|" + name + "|" + tc);
                    }
                    else if (smenu == 2)
                    {
                        Console.Write("Nhap id MH can xoa: ");
                        string id = Console.ReadLine();
                        for (int i = 0; i < courses.Count; i++)
                        {
                            string[] p = courses[i].Split('|');
                            if (p[0] == id)
                            {
                                courses.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    else if (smenu == 3)
                    {
                        Console.Write("Nhap id MH cap nhat: ");
                        string id = Console.ReadLine();
                        for (int i = 0; i < courses.Count; i++)
                        {
                            string[] p = courses[i].Split('|');
                            if (p[0] == id)
                            {
                                Console.Write("Nhap ten moi: ");
                                string name = Console.ReadLine();
                                Console.Write("Nhap tin chi moi: ");
                                int tc = int.Parse(Console.ReadLine());
                                courses[i] = id + "|" + name + "|" + tc;
                            }
                        }
                    }
                    else if (smenu == 4)
                    {
                        foreach (var c in courses)
                        {
                            string[] p = c.Split('|');
                            Console.WriteLine("ID:" + p[0] + " Name:" + p[1] + " TinChi:" + p[2]);
                        }
                    }
                }
            }

            // ================== QUẢN LÝ ĐĂNG KÝ ==================
            else if (menu == 4)
            {
                int smenu = 0;
                while (smenu != 6)
                {
                    Console.WriteLine("--- QUAN LY DANG KY HOC ---");
                    Console.WriteLine("1. Dang ky mon hoc cho SV");
                    Console.WriteLine("2. Huy dang ky");
                    Console.WriteLine("3. Cap nhat dang ky");
                    Console.WriteLine("4. Hien thi tat ca dang ky");
                    Console.WriteLine("5. Tim dang ky theo SV id");
                    Console.WriteLine("6. Quay lai");
                    smenu = int.Parse(Console.ReadLine());

                    if (smenu == 1)
                    {
                        Console.Write("Nhap id dang ky: ");
                        string eid = Console.ReadLine();
                        Console.Write("Nhap id sinh vien: ");
                        string sid = Console.ReadLine();
                        Console.Write("Nhap id mon hoc: ");
                        string cid = Console.ReadLine();
                        enrollments.Add(eid + "|" + sid + "|" + cid);
                    }
                    else if (smenu == 2)
                    {
                        Console.Write("Nhap id dang ky can xoa: ");
                        string eid = Console.ReadLine();
                        for (int i = 0; i < enrollments.Count; i++)
                        {
                            string[] parts = enrollments[i].Split('|');
                            if (parts[0] == eid)
                            {
                                enrollments.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    else if (smenu == 3)
                    {
                        Console.Write("Nhap id dang ky can cap nhat: ");
                        string eid = Console.ReadLine();
                        for (int i = 0; i < enrollments.Count; i++)
                        {
                            string[] parts = enrollments[i].Split('|');
                            if (parts[0] == eid)
                            {
                                Console.Write("Nhap id sinh vien moi: ");
                                string sid = Console.ReadLine();
                                Console.Write("Nhap id mon hoc moi: ");
                                string cid = Console.ReadLine();
                                enrollments[i] = eid + "|" + sid + "|" + cid;
                            }
                        }
                    }
                    else if (smenu == 4)
                    {
                        foreach (var e in enrollments)
                        {
                            string[] p = e.Split('|');
                            Console.WriteLine("EnrollID:" + p[0] + " StudentID:" + p[1] + " CourseID:" + p[2]);
                        }
                    }
                    else if (smenu == 5)
                    {
                        Console.Write("Nhap id sinh vien: ");
                        string sid = Console.ReadLine();
                        foreach (var e in enrollments)
                        {
                            string[] p = e.Split('|');
                            if (p[1] == sid)
                            {
                                Console.WriteLine("Tim thay: " + e);
                            }
                        }
                    }
                }
            }

            // ================== QUẢN LÝ ĐIỂM ==================
            else if (menu == 5)
            {
                int smenu = 0;
                while (smenu != 6)
                {
                    Console.WriteLine("--- QUAN LY DIEM ---");
                    Console.WriteLine("1. Nhap diem");
                    Console.WriteLine("2. Cap nhat diem");
                    Console.WriteLine("3. Xoa diem");
                    Console.WriteLine("4. Hien thi tat ca diem");
                    Console.WriteLine("5. Tim diem theo SV id");
                    Console.WriteLine("6. Quay lai");
                    smenu = int.Parse(Console.ReadLine());

                    if (smenu == 1)
                    {
                        Console.Write("Nhap id diem: ");
                        string gid = Console.ReadLine();
                        Console.Write("Nhap id sinh vien: ");
                        string sid = Console.ReadLine();
                        Console.Write("Nhap id mon hoc: ");
                        string cid = Console.ReadLine();
                        Console.Write("Nhap diem: ");
                        double d = double.Parse(Console.ReadLine());
                        grades.Add(gid + "|" + sid + "|" + cid + "|" + d);
                    }
                    else if (smenu == 2)
                    {
                        Console.Write("Nhap id diem can cap nhat: ");
                        string gid = Console.ReadLine();
                        for (int i = 0; i < grades.Count; i++)
                        {
                            string[] parts = grades[i].Split('|');
                            if (parts[0] == gid)
                            {
                                Console.Write("Nhap diem moi: ");
                                double d = double.Parse(Console.ReadLine());
                                grades[i] = gid + "|" + parts[1] + "|" + parts[2] + "|" + d;
                            }
                        }
                    }
                    else if (smenu == 3)
                    {
                        Console.Write("Nhap id diem can xoa: ");
                        string gid = Console.ReadLine();
                        for (int i = 0; i < grades.Count; i++)
                        {
                            string[] parts = grades[i].Split('|');
                            if (parts[0] == gid)
                            {
                                grades.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    else if (smenu == 4)
                    {
                        foreach (var g in grades)
                        {
                            string[] p = g.Split('|');
                            Console.WriteLine("GradeID:" + p[0] + " StudentID:" + p[1] + " CourseID:" + p[2] + " Score:" + p[3]);
                        }
                    }
                    else if (smenu == 5)
                    {
                        Console.Write("Nhap id sinh vien: ");
                        string sid = Console.ReadLine();
                        foreach (var g in grades)
                        {
                            string[] p = g.Split('|');
                            if (p[1] == sid)
                            {
                                Console.WriteLine("Tim thay: " + g);
                            }
                        }
                    }
                }
            }

            // ================== BÁO CÁO TỔNG HỢP ==================
            else if (menu == 6)
            {
                Console.WriteLine("=== BAO CAO TONG HOP ===");
                foreach (var s in students)
                {
                    string[] sv = s.Split('|');
                    Console.WriteLine("Sinh vien: " + sv[1] + " (ID:" + sv[0] + ")");
                    foreach (var e in enrollments)
                    {
                        string[] en = e.Split('|');
                        if (en[1] == sv[0])
                        {
                            foreach (var c in courses)
                            {
                                string[] co = c.Split('|');
                                if (co[0] == en[2])
                                {
                                    Console.Write(" - Mon hoc: " + co[1]);
                                    foreach (var g in grades)
                                    {
                                        string[] gr = g.Split('|');
                                        if (gr[1] == sv[0] && gr[2] == co[0])
                                        {
                                            Console.Write(" | Diem: " + gr[3]);
                                        }
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
