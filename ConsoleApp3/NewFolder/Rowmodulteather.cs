//using SM.CardStudents;
//using SM.IModuls;
//using SM.IStudents;
//using SM.ITeachers;
//using System;
//using System.Collections.Generic;
//using System.Reflection;
//using System.Security.Cryptography;
//namespace SM.IRowsschools;

//public interface IRowsschool : IInfo
//{
//    string Id { get; }
//    string Name { get; }
//    string GetRowID() ;
//    public string GetRowName() ;
//    void AddModul(Modul m);
//    Modul SearchByModul(string id);
//    void AddTeacher(Teacher t);
//    void AddStudent(Student s);
//    public  ICollection<Modul> Moduls { get; }
//    public ICollection<Teacher> Teachers { get; }

//    public ICollection<Student> Students { get; }
//}
//public class Rowsschool : IRowsschool
//{
//    private readonly string _Id;
//    private  string _name;
//    private readonly List<Teacher> teachers ;
//    private readonly List<Student> students ;
//    private readonly List<Modul> moduls;

//    private static readonly string[] RowsDs = { "fgirst", "second", "third", "fourth" };

//  public  string Id => _Id;

//   public string Name => _name;

//    public ICollection<Modul> Moduls => throw new NotImplementedException();

//    public ICollection<Teacher> Teachers => throw new NotImplementedException();

//    public ICollection<Student> Students => throw new NotImplementedException();

//    public Rowsschool(string name)
//    {
//        IDgenerate idf = new();
//        this._Id = idf.GenvetId("row", '-', 10, 4, 3);
//        SetRows(name);
//        teachers = new List<Teacher>();
//        students = new List<Student>();
//        moduls = new List<Modul>();
//    }

//    protected void SetRows(string row)
//    {
//        if (string.IsNullOrWhiteSpace(row)) return;
//        foreach (var r in RowsDs)
//        {
//            if (r == row)
//            {
//                _name = row;
//                return;
//            }
//        }
//        Console.WriteLine($"Invalid Row: {row}");
//    }

//    public enum SearchType { Teacher, Modul, Student }

//    public object? FindBy(string id, string name, SearchType type)
//    {
//        return type switch
//        {
//            SearchType.Teacher => teachers.Find(t => t.Id == id || t.GetName() == name),
//            SearchType.Modul => moduls.Find(m => m.getmodulid() == id || m.getName() == name),
//            SearchType.Student => students.Find( s => s.GetStudentId() == id || s.GetCardName() == name),
//            _ => null
//        };
//    }

//    public void AddModul(Modul m)
//    {
//        //if (FindBy(m.getmodulid(), m.getName(), SearchType.Modul) is not null)
//        //{
//        //    Console.WriteLine($"Modul already exists ID: {m.getmodulid()} by name: {m.getName()}");
//        //    return;
//        //}

//        //var isfound = moduls.Find(m =>  m.getName().ToLower() == m.getName().ToLower());
//        if (Validator.Validate(moduls, m))  // التحقق باستخدام دالة واحدة
//        {
//            moduls.Add(m);

//            m.BuildRow(this);
//        }
//        //moduls.Add(m);
//        //m.BuildRow(this);
//    }
//    public Modul SearchByModul(string id)
//    {
//        for (int i = 0; i < RowsDs.Length; i++)
//        {
//            if (moduls[i].getmodulid() == id)
//            {
//                return moduls[i];
//            }
//        }

//        return null;
//    }


//    public void AddTeacher(Teacher t)
//    {
//        //if (FindBy(t.Id, t.GetName(), SearchType.Teacher) is not null)
//        //{
//        //    Console.WriteLine($"Teacher already exists ID: {t.Id} by name: {t.GetName()}");
//        //    return;
//        //}
//        //teachers.Add(t);
//        if (Validator.Validate(teachers, t))  // التحقق باستخدام دالة واحدة
//        {
//            teachers.Add(t);
//           // Console.WriteLine($"  teachers : {teacher.GetName()}");
//        }
//    }

//    public void AddStudent(Student s)
//    {
//        //if (FindBy(s.GetStudentId(), s.GetCardName(), SearchType.Student) is not null)
//        //{
//        //    Console.WriteLine($"Student already exists ID: {s.GetStudentId()} by name: {s.GetCardName()}");
//        //    return;
//        //}
//        if (Validator.Validate(students, s))  // التحقق باستخدام دالة واحدة
//        {
//            students.Add(s);
//            s.BuildRowstudent(this);
//           // Console.WriteLine($"students: {s.GetCardName()}");
//        }
//        //students.Add(s);
//        //s.BuildRowstudent(this);
//    }

//    public void Info()
//    {
//        Console.WriteLine($"Row ID: {_Id}, Name: {_name}");
//        Console.WriteLine($"Modules: {moduls.Count}, Teachers: {teachers.Count}, Students: {students.Count}");
//    }
//    //public List<Student> GetStudents()
//    //{
//    //    return students;
//    //}

//    public string GetRowID() => _Id;
//    public string GetRowName() => _name;


//}

