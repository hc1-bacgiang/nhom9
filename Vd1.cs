// BƯỚC 1: Thêm class cho từng đối tượng, nhưng vẫn giữ ArrayList<String> BAD CODE
// Lưu ý: Code này vẫn xài ArrayList<String>, chỉ mới dọn sơ
import java.util.*;

class Student
{

    print("Hello from nhanh2 branch");
    String id;
    String name;
    int age;
    double gpa;


    public Student(String id, String name, int age, double gpa) {
        this.id = id;
        this.name = name;
        this.age = age;
        this.gpa = gpa;
    }

    @Override
    public String toString() {
        return "ID:" + id + " Name:" + name + " Age:" + age + " GPA:" + gpa;
    }
}

class Teacher {
    String id;
    String name;
    String major;

    public Teacher(String id, String name, String major) {
        this.id = id;
        this.name = name;
        this.major = major;
    }

    @Override
    public String toString() {
        return "ID:" + id + " Name:" + name + " Major:" + major;
    }
}

class Course {
    String id;
    String name;
    int credits;

    public Course(String id, String name, int credits) {
        this.id = id;
        this.name = name;
        this.credits = credits;
    }

    @Override
    public String toString() {
        return "ID:" + id + " Name:" + name + " Credits:" + credits;
    }
}

class Grade {
    String studentId;
    String courseId;
    double score;

    public Grade(String studentId, String courseId, double score) {
        this.studentId = studentId;
        this.courseId = courseId;
        this.score = score;
    }

    @Override
    public String toString() {
        return "SV:" + studentId + " MH:" + courseId + " Diem:" + score;
    }
}

public class BadSchoolProgram
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        // Vẫn giữ ArrayList<String> BAD CODE
        ArrayList<String> students = new ArrayList<String>();
        ArrayList<String> teachers = new ArrayList<String>();
        ArrayList<String> courses = new ArrayList<String>();
        ArrayList<String> enrollments = new ArrayList<String>();
        ArrayList<String> grades = new ArrayList<String>();

        int menu = 0;
        while (menu != 99) {
            System.out.println("============= MENU CHINH =============");
            System.out.println("1. Quan ly Sinh vien");
            System.out.println("2. Quan ly Giao vien");
            System.out.println("3. Quan ly Mon hoc");
            System.out.println("4. Quan ly Dang ky hoc");
            System.out.println("5. Quan ly Diem");
            System.out.println("6. Bao cao tong hop");
            System.out.println("99. Thoat");
            System.out.print("Nhap lua chon: ");
            menu = sc.nextInt(); sc.nextLine();

            if (menu == 1) {
                int smenu = 0;
                while (smenu != 9) {
                    System.out.println("--- QUAN LY SINH VIEN ---");
                    System.out.println("1. Them SV");
                    System.out.println("2. Xoa SV");
                    System.out.println("3. Cap nhat SV");
System.out.println("4. Hien thi tat ca SV");
                    System.out.println("5. Tim SV theo ten");
                    System.out.println("6. Tim SV GPA > 8");
                    System.out.println("7. Sap xep theo ten");
                    System.out.println("8. Sap xep theo GPA");
                    System.out.println("9. Quay lai");
                    smenu = sc.nextInt(); sc.nextLine();

                    if (smenu == 1)
                    {
                        System.out.print("Nhap id: ");
                        String id = sc.nextLine();
                        System.out.print("Nhap ten: ");
                        String name = sc.nextLine();
                        System.out.print("Nhap tuoi: ");
                        int age = sc.nextInt(); sc.nextLine();
                        System.out.print("Nhap GPA: ");
                        double gpa = sc.nextDouble(); sc.nextLine();
                        students.add(id + "|" + name + "|" + age + "|" + gpa);
                    }
                    else if (smenu == 2)
                    {
                        System.out.print("Nhap id can xoa: ");
                        String id = sc.nextLine();
                        for (int i = 0; i < students.size(); i++)
                        {
                            String[] parts = students.get(i).split("\\|");
                            if (parts[0].equals(id))
                            {
                                students.remove(i);
                                break;
                            }
                        }
                    }
                    else if (smenu == 3)
                    {
                        System.out.print("Nhap id can cap nhat: ");
                        String id = sc.nextLine();
                        for (int i = 0; i < students.size(); i++)
                        {
                            String[] parts = students.get(i).split("\\|");
                            if (parts[0].equals(id))
                            {
                                System.out.print("Nhap ten moi: ");
                                String name = sc.nextLine();
                                System.out.print("Nhap tuoi moi: ");
                                int age = sc.nextInt(); sc.nextLine();
                                System.out.print("Nhap GPA moi: ");
                                double gpa = sc.nextDouble(); sc.nextLine();
                                students.set(i, id + "|" + name + "|" + age + "|" + gpa);
                            }
                        }
                    }
                    else if (smenu == 4)
                    {
                        for (int i = 0; i < students.size(); i++)
                        {
                            String[] p = students.get(i).split("\\|");
                            System.out.println("ID:" + p[0] + " Name:" + p[1] + " Age:" + p[2] + " GPA:" + p[3]);
                        }
                    }
                    else if (smenu == 5)
                    {
                        System.out.print("Nhap ten: ");
                        String name = sc.nextLine();
                        for (int i = 0; i < students.size(); i++)
                        {
                            String[] p = students.get(i).split("\\|");
                            if (p[1].equals(name))
                            {
                                System.out.println("Tim thay: " + students.get(i));
                            }
                        }
                    }
                    else if (smenu == 6)
                    {
                        for (int i = 0; i < students.size(); i++)
                        {
                            String[] p = students.get(i).split("\\|");
                            if (Double.parseDouble(p[3]) > 8.0)
                            {
                                System.out.println("Sinh vien gioi: " + students.get(i));
                            }
                        }
                    }
                    else if (smenu == 7)
                    {
                        for (int i = 0; i < students.size(); i++)
                        {
                            for (int j = 0; j < students.size() - 1; j++)
                            {
                                String[] p1 = students.get(j).split("\\|");
                                String[] p2 = students.get(j + 1).split("\\|");
                                if (p1[1].compareTo(p2[1]) > 0)
                                {
                                    String tmp = students.get(j);
                                    students.set(j, students.get(j + 1));
                                    students.set(j + 1, tmp);
                                }
                            }
                        }
                        System.out.println("Da sap xep theo ten.");
                    }
                    else if (smenu == 8)
                    {
                        for (int i = 0; i < students.size(); i++)
                        {
                            for (int j = 0; j < students.size() - 1; j++)
                            {
                                String[] p1 = students.get(j).split("\\|");
                                String[] p2 = students.get(j + 1).split("\\|");
                                if (Double.parseDouble(p1[3]) < Double.parseDouble(p2[3]))
                                {
                                    String tmp = students.get(j);
                                    students.set(j, students.get(j + 1));
                                    students.set(j + 1, tmp);
                                }
                            }
                        }
                        System.out.println("Da sap xep theo GPA.");
                    }
                }
            }
            // Các menu khác (GV, MH, Đăng ký, Điểm, Báo cáo) vẫn giữ nguyên BAD CODE như bản gốc
        }
    }
}