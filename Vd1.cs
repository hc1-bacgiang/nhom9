// BƯỚC 2: Dùng ArrayList<Student/Teacher/Course/Grade> thay vì ArrayList<String>

import java.util.*;

class Student {
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

public class BadSchoolProgram {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // Bây giờ dùng ArrayList<Object> thay cho ArrayList<String>
        ArrayList<Student> students = new ArrayList<>();
        ArrayList<Teacher> teachers = new ArrayList<>();
        ArrayList<Course> courses = new ArrayList<>();
        ArrayList<String> enrollments = new ArrayList<>(); // vẫn tạm giữ chuỗi "sid|cid"
        ArrayList<Grade> grades = new ArrayList<>();

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

                    if (smenu == 1) {
                        System.out.print("Nhap id: ");
                        String id = sc.nextLine();
                        System.out.print("Nhap ten: ");
                        String name = sc.nextLine();
                        System.out.print("Nhap tuoi: ");
                        int age = sc.nextInt(); sc.nextLine();
                        System.out.print("Nhap GPA: ");
                        double gpa = sc.nextDouble(); sc.nextLine();
                        students.add(new Student(id, name, age, gpa));
                    } else if (smenu == 2) {
                        System.out.print("Nhap id can xoa: ");
                        String id = sc.nextLine();
                        students.removeIf(s -> s.id.equals(id));
                    } else if (smenu == 3) {
                        System.out.print("Nhap id can cap nhat: ");
                        String id = sc.nextLine();
                        for (Student s : students) {
                            if (s.id.equals(id)) {
                                System.out.print("Nhap ten moi: ");
                                s.name = sc.nextLine();
                                System.out.print("Nhap tuoi moi: ");
                                s.age = sc.nextInt(); sc.nextLine();
                                System.out.print("Nhap GPA moi: ");
                                s.gpa = sc.nextDouble(); sc.nextLine();
                            }
                        }
                    } else if (smenu == 4) {
                        for (Student s : students) System.out.println(s);
                    } else if (smenu == 5) {
                        System.out.print("Nhap ten: ");
                        String name = sc.nextLine();
                        for (Student s : students) {
                            if (s.name.equalsIgnoreCase(name)) {
                                System.out.println("Tim thay: " + s);
                            }
                        }
                    } else if (smenu == 6) {
                        for (Student s : students) {
                            if (s.gpa > 8.0) {
                                System.out.println("Sinh vien gioi: " + s);
                            }
                        }
                    } else if (smenu == 7) {
                        students.sort((a, b) -> a.name.compareToIgnoreCase(b.name));
                        System.out.println("Da sap xep theo ten.");
                    } else if (smenu == 8) {
students.sort((a, b) -> Double.compare(b.gpa, a.gpa));
                        System.out.println("Da sap xep theo GPA.");
                    }
                }
            }

            else if (menu == 2) {
                int tmenu = 0;
                while (tmenu != 9) {
                    System.out.println("--- QUAN LY GIAO VIEN ---");
                    System.out.println("1. Them GV");
                    System.out.println("2. Xoa GV");
                    System.out.println("3. Cap nhat GV");
                    System.out.println("4. Hien thi GV");
                    System.out.println("9. Quay lai");
                    tmenu = sc.nextInt(); sc.nextLine();
                    if (tmenu == 1) {
                        System.out.print("Nhap id GV: ");
                        String id = sc.nextLine();
                        System.out.print("Nhap ten GV: ");
                        String name = sc.nextLine();
                        System.out.print("Nhap chuyen mon: ");
                        String major = sc.nextLine();
                        teachers.add(new Teacher(id, name, major));
                    } else if (tmenu == 2) {
                        System.out.print("Nhap id GV can xoa: ");
                        String id = sc.nextLine();
                        teachers.removeIf(t -> t.id.equals(id));
                    } else if (tmenu == 3) {
                        System.out.print("Nhap id GV cap nhat: ");
                        String id = sc.nextLine();
                        for (Teacher t : teachers) {
                            if (t.id.equals(id)) {
                                System.out.print("Nhap ten moi: ");
                                t.name = sc.nextLine();
                                System.out.print("Nhap chuyen mon moi: ");
                                t.major = sc.nextLine();
                            }
                        }
                    } else if (tmenu == 4) {
                        for (Teacher t : teachers) System.out.println(t);
                    }
                }
            }

            else if (menu == 3) {
                int cmenu = 0;
                while (cmenu != 9) {
                    System.out.println("--- QUAN LY MON HOC ---");
                    System.out.println("1. Them MH");
                    System.out.println("2. Xoa MH");
                    System.out.println("3. Cap nhat MH");
                    System.out.println("4. Hien thi MH");
                    System.out.println("9. Quay lai");
                    cmenu = sc.nextInt(); sc.nextLine();
                    if (cmenu == 1) {
                        System.out.print("Nhap id MH: ");
                        String id = sc.nextLine();
                        System.out.print("Nhap ten MH: ");
                        String name = sc.nextLine();
                        System.out.print("Nhap so tin chi: ");
                        int tc = sc.nextInt(); sc.nextLine();
courses.add(new Course(id, name, tc));
                    } else if (cmenu == 2) {
                        System.out.print("Nhap id MH can xoa: ");
                        String id = sc.nextLine();
                        courses.removeIf(c -> c.id.equals(id));
                    } else if (cmenu == 3) {
                        System.out.print("Nhap id MH cap nhat: ");
                        String id = sc.nextLine();
                        for (Course c : courses) {
                            if (c.id.equals(id)) {
                                System.out.print("Nhap ten moi: ");
                                c.name = sc.nextLine();
                                System.out.print("Nhap tin chi moi: ");
                                c.credits = sc.nextInt(); sc.nextLine();
                            }
                        }
                    } else if (cmenu == 4) {
                        for (Course c : courses) System.out.println(c);
                    }
                }
            }

            else if (menu == 4) {
                int emenu = 0;
                while (emenu != 9) {
                    System.out.println("--- QUAN LY DANG KY HOC ---");
                    System.out.println("1. Dang ky mon hoc");
                    System.out.println("2. Huy dang ky");
                    System.out.println("3. Xem tat ca dang ky");
                    System.out.println("9. Quay lai");
                    emenu = sc.nextInt(); sc.nextLine();
                    if (emenu == 1) {
                        System.out.print("Nhap id SV: ");
                        String sid = sc.nextLine();
                        System.out.print("Nhap id MH: ");
                        String cid = sc.nextLine();
                        enrollments.add(sid + "|" + cid);
                    } else if (emenu == 2) {
                        System.out.print("Nhap id SV: ");
                        String sid = sc.nextLine();
                        System.out.print("Nhap id MH: ");
                        String cid = sc.nextLine();
                        enrollments.removeIf(e -> e.equals(sid + "|" + cid));
                    } else if (emenu == 3) {
                        for (String e : enrollments) {
                            String[] p = e.split("\\|");
                            System.out.println("SV: " + p[0] + " dang ky MH: " + p[1]);
                        }
                    }
                }
            }

            else if (menu == 5) {
                int gmenu = 0;
                while (gmenu != 9) {
                    System.out.println("--- QUAN LY DIEM ---");
                    System.out.println("1. Nhap diem");
                    System.out.println("2. Cap nhat diem");
                    System.out.println("3. Hien thi diem");
                    System.out.println("9. Quay lai");
                    gmenu = sc.nextInt(); sc.nextLine();
                    if (gmenu == 1) {
System.out.print("Nhap id SV: ");
                        String sid = sc.nextLine();
                        System.out.print("Nhap id MH: ");
                        String cid = sc.nextLine();
                        System.out.print("Nhap diem: ");
                        double d = sc.nextDouble(); sc.nextLine();
                        grades.add(new Grade(sid, cid, d));
                    } else if (gmenu == 2) {
                        System.out.print("Nhap id SV: ");
                        String sid = sc.nextLine();
                        System.out.print("Nhap id MH: ");
                        String cid = sc.nextLine();
                        for (Grade g : grades) {
                            if (g.studentId.equals(sid) && g.courseId.equals(cid)) {
                                System.out.print("Nhap diem moi: ");
                                g.score = sc.nextDouble(); sc.nextLine();
                            }
                        }
                    } else if (gmenu == 3) {
                        for (Grade g : grades) System.out.println(g);
                    }
                }
            }

            else if (menu == 6) {
                System.out.println("=== BAO CAO ===");
                for (Student s : students) {
                    System.out.println("Sinh vien: " + s.name);
                    for (String e : enrollments) {
                        String[] parts = e.split("\\|");
                        if (parts[0].equals(s.id)) {
                            for (Course c : courses) {
                                if (c.id.equals(parts[1])) {
                                    System.out.print(" - Mon hoc: " + c.name);
                                    for (Grade g : grades) {
                                        if (g.studentId.equals(s.id) && g.courseId.equals(c.id)) {
                                            System.out.print(" | Diem: " + g.score);
                                        }
                                    }
                                    System.out.println();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
