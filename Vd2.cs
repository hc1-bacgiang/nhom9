// BadSchoolProgram.cs (tiếp tục sau phần Teacher Manager)

    // ================== QUẢN LÝ MÔN HỌC ==================
else if (menu == 3)
{
    int smenu = 0;
    while (smenu != 9)
    {
        Console.WriteLine("--- QUAN LY MON HOC ---");
        Console.WriteLine("1. Them mon hoc");
        Console.WriteLine("2. Xoa mon hoc");
        Console.WriteLine("3. Cap nhat mon hoc");
        Console.WriteLine("4. Hien thi tat ca mon hoc");
        Console.WriteLine("5. Tim mon hoc theo ten");
        Console.WriteLine("6. Tim mon hoc theo so tin chi > 3");
        Console.WriteLine("7. Sap xep theo ten");
        Console.WriteLine("8. Sap xep theo so tin chi");
        Console.WriteLine("9. Quay lai");
        smenu = int.Parse(Console.ReadLine());

        if (smenu == 1)
        {
            Console.Write("Nhap id: ");
            string id = Console.ReadLine();
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            Console.Write("Nhap so tin chi: ");
            int credits = int.Parse(Console.ReadLine());
            courses.Add(id + "|" + name + "|" + credits);
        }
        else if (smenu == 2)
        {
            Console.Write("Nhap id can xoa: ");
            string id = Console.ReadLine();
            for (int i = 0; i < courses.Count; i++)
            {
                string[] parts = courses[i].Split('|');
                if (parts[0] == id)
                {
                    courses.RemoveAt(i);
                    break;
                }
            }
        }
        else if (smenu == 3)
        {
            Console.Write("Nhap id can cap nhat: ");
            string id = Console.ReadLine();
            for (int i = 0; i < courses.Count; i++)
            {
                string[] parts = courses[i].Split('|');
                if (parts[0] == id)
                {
                    Console.Write("Nhap ten moi: ");
                    string name = Console.ReadLine();
                    Console.Write("Nhap so tin chi moi: ");
                    int credits = int.Parse(Console.ReadLine());
                    courses[i] = id + "|" + name + "|" + credits;
                }
            }
        }
        else if (smenu == 4)
        {
            foreach (var c in courses)
            {
                string[] p = c.Split('|');
                Console.WriteLine("ID:" + p[0] + " Name:" + p[1] + " Credits:" + p[2]);
            }
        }
        else if (smenu == 5)
        {
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            foreach (var c in courses)
            {
                string[] p = c.Split('|');
                if (p[1] == name)
                {
                    Console.WriteLine("Tim thay: " + c);
                }
            }
        }
        else if (smenu == 6)
        {
            foreach (var c in courses)
            {
                string[] p = c.Split('|');
                if (int.Parse(p[2]) > 3)
                {
                    Console.WriteLine("Mon nhieu tin chi: " + c);
                }
            }
        }
        else if (smenu == 7)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                for (int j = 0; j < courses.Count - 1; j++)
                {
                    string[] p1 = courses[j].Split('|');
                    string[] p2 = courses[j + 1].Split('|');
                    if (p1[1].CompareTo(p2[1]) > 0)
                    {
                        string tmp = courses[j];
                        courses[j] = courses[j + 1];
                        courses[j + 1] = tmp;
                    }
                }
            }
            Console.WriteLine("Da sap xep theo ten.");
        }
        else if (smenu == 8)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                for (int j = 0; j < courses.Count - 1; j++)
                {
                    string[] p1 = courses[j].Split('|');
                    string[] p2 = courses[j + 1].Split('|');
                    if (int.Parse(p1[2]) < int.Parse(p2[2]))
                    {
                        string tmp = courses[j];
                        courses[j] = courses[j + 1];
                        courses[j + 1] = tmp;
                    }
                }
            }
            Console.WriteLine("Da sap xep theo so tin chi.");
        }
    }
}
