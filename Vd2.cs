// BadSchoolProgram.cs
// BAD CODE: Quản lý trường học
// Bước 1: Thêm class Student, Teacher, Course, Enrollment, Grade
// Nhưng vẫn lưu trữ bằng List<string>

using System;
using System.Collections.Generic;

class Student
{
    public string Id;
    public string Name;
    public int Age;
    public double GPA;

    public Student(string id, string name, int age, double gpa)
    {
        Id = id; Name = name; Age = age; GPA = gpa;
    }
}

class Teacher
{
    public string Id;
    public string Name;
    public string Major;

    public Teacher(string id, string name, string major)
    {
        Id = id; Name = name; Major = major;
    }
}

class Course
{
    public string Id;
    public string Name;
    public int Credits;

    public Course(string id, string name, int credits)
    {
        Id = id; Name = name; Credits = credits;
    }
}

class Enrollment
{
    public string StudentId;
    public string CourseId;

    public Enrollment(string sid, string cid)
    {
        StudentId = sid; CourseId = cid;
    }
}

class Grade
{
    public string StudentId;
    public string CourseId;
    public double Score;

    public Grade(string sid, string cid, double score)
    {
        StudentId = sid; CourseId = cid; Score = score;
    }
}

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
