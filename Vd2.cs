// BadSchoolProgram.cs (tiếp tục sau phần Course Manager)

    // ================== QUẢN LÝ ĐĂNG KÝ HỌC ==================
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
// BadSchoolProgram.cs (tiếp tục sau phần Enrollment Manager)

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
