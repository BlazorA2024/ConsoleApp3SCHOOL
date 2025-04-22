using System;
using System.Reflection;
//using static Rowsschool;

















public interface ISchool: IInfo
{
    
}
//public class School : ISchool
//{
//    private string Id;
//    private string name;
//    private readonly IRowRepository rows ;
//    private readonly IRepsitory<Teacher> teachers;
//    private readonly IRepsitory<Student> students;
//    private readonly IRepsitory<Modul> moduls ;

//    public School(string name)
//    {
//        IDgenerate idf = new();
//        Id = idf.GenvetId("School", '-', 10, 4, 3);
//        this.name = name;

//        rows = new RowRepository();
//        teachers = new Repository<Teacher>();
//        students = new Repository<Student>();
//        moduls = new Repository<Modul>();
//    }
   
//    public void AddStudent(Student student, string rowId)
//    {

//        if (Validator.Validate(students., student))  // التحقق باستخدام دالة واحدة
//        {
//            students.Add(student);
//            Console.WriteLine($"students: {student.GetCardName()}");
//        }
//        foreach (var row in rows.Items)
//            {
//                if (row.GetRowID() == rowId)
//                {
//                    row.AddStudent(student);
//                    return;
//                }
//            }
        
//    }
//    //public void AddTeacherToModul(Teacher teacher, string modulId)
//    //{
//    //    foreach (var row in rows)
//    //    {
//    //        var modul = (Modul?)row.FindBy(modulId, "", Rowsschool.SearchType.Modul);
//    //        if (modul != null)
//    //        {
//    //            teacher.AddModul(modul);
//    //            row.AddTeacher(teacher);
//    //            return;
//    //        }
//    //    }
//    //}
//    public void AddTeacherToModul(Teacher teacher, string modulId)
//    {


//        foreach (var row in rows.Items)
//        {

//            var modul = row.FindBy(modulId, "", Rowsschool.SearchType.Modul) as Modul;
//            if (modul != null)
//            {
//                teacher.AddModul(modul);   // إضافة الموديول للمعلم
//                row.AddTeacher(teacher);   // إضافة المعلم للصف الحالي
//                return;
//            }

//        }

//    }

//    public void AddRow(Rowsschool row) => rows.Add(row);

//    public void AddRowModul(Modul m, int iRow) => rows[iRow].AddModul(m);

//    //public void AddTeacher(Teacher teacher)
//    //{

//    //    if (FindBy(teacher.Id, teacher.GetName(), SearchType.Teacher) is not null)
//    //    {
//    //        Console.WriteLine($"Teacher already exists ID: {teacher.Id} by name: {teacher.GetName()}");
//    //        return;
//    //    }

//    //    teachers.Add(teacher);

//    //}

//    public void AddTeacher(Teacher teacher)
//    {
//        if (Validator.Validate(teachers, teacher))  // التحقق باستخدام دالة واحدة
//        {
//            teachers.Add(teacher);
//            Console.WriteLine($"  teachers : {teacher.GetName()}");
//        }
//    }




//    public Teacher? SearchteacherByName(string name)
//    {
//        foreach (var teacher in teachers)
//        {
//            if (teacher.GetName() == name)
//            {
//                return teacher;
//            }
//        }
//        return null;
//    }
//    public Student? SearchStudentByName(string name)
//    {
//        foreach (var student in students)
//        {
//            if (student.GetCardName() == name)
//            {
//                return student;
//            }
//        }
//        return null;
//    }


//    public void Info()
//    {
//        Console.WriteLine("===== School Info =====");
//        Console.WriteLine($"School Name: {name}");

        
//    }

//    public void Info1()
//    {
//        Console.WriteLine($" School Name: {name}");

//        Console.WriteLine("\n Teachers:");
//        if (teachers.Count == 0)
//        {
//            Console.WriteLine(" No teachers found.");
//        }
//        else
//        {
//            foreach (var teacher in teachers)
//            {
//                teacher.Info();
//            }
//        }

//        Console.WriteLine("\n Students:");
//        if (students.Count == 0)
//        {
//            Console.WriteLine(" No students found.");
//        }
//        else
//        {
//            foreach (var student in students)
//            {
//                student.Info();
//            }
//        }
//    }
//    public void ShowAll()
//    {
//        Console.WriteLine("===== School Info =====");
//        Console.WriteLine($"School Name: {name}");


//        // تحويل القوائم إلى IEnumerable<IInfo> باستخدام Cast
//        Printer.PrintAll(
//            teachers,  
//            students,  
//            moduls,   
//            rows       
//        );
//    }



//}

//public abstract class Printer
//{
//    public static void PrintAll(params IEnumerable<IInfo>[] collections)
//    {
//        foreach (var collection in collections)
//        {
//            foreach (var item in collection)
//            {
//                item.Info();
//            }

//        }
//    }
//}
//public abstract class Validator
//{
//    // Method to validate different objects (Teacher, Student, Modul, Rowsschool)
//    public static bool Validate<T>(List<T> items, T item) where T : class
//    {

//        foreach (var ob in items)
//        {
//            if (ob==item)
//            {
//                Console.WriteLine("Error: Null item found in the list.");
//                return false;
//            }
           
//        }

//        return true;

//        //switch (item)
//        //{
//        //    case Teacher teacher:
//        //        // Validate Teacher
//        //        if (items.Any(i => (i as Teacher)?.Id == teacher.Id || (i as Teacher)?.GetName() == teacher.GetName()))
//        //        {
//        //            Console.WriteLine($"Error: Teacher {teacher.GetName()} already exists.");
//        //            return false;
//        //        }
//        //        break;

//        //    case Student student:
//        //        // Validate Student
//        //        if (items.Any(i => (i as Student)?.GetStudentId() == student.GetStudentId() || (i as Student)?.GetCardName() == student.GetCardName()))
//        //        {
//        //            Console.WriteLine($"Error: Student {student.GetCardName()} already exists.");
//        //            return false;
//        //        }
//        //        break;

//        //    case Modul modul:
//        //        // Validate Modul
        //        if (items.Any(i => (i as Modul)?.getmodulid() == modul.getmodulid() || (i as Modul)?.getName() == modul.getName()))
        //        {
        //            Console.WriteLine($"Error: Modul {modul.getName()} already exists.");
        //            return false;
        //        }
        //        break;

        //    case Rowsschool row:
        //        // Validate Rowsschool
        //        if (items.Any(i => (i as Rowsschool)?.GetRowID() == row.GetRowID()))
        //        {
        //            Console.WriteLine($"Error: Row {row.GetRowID()} already exists.");
        //            return false;
        //        }
        //        break;

        //    default:
        //        Console.WriteLine("Unsupported object type.");
        //        return false;
        //}
        //return true;
//    }
//}


//public abstract class BaseCard
//{
//    protected BaseCard(string name, string description, object addData)
//    {
//        Name = name;
//        Description = description;
//        AddData = addData;
//    }

//    public string Name { get; set; }
//    public string Description { get; set; }

//    public object AddData { set; get; }


//}
//public class CardInt : BaseCard
//{
//    public int Id { get; set; }

//    public CardInt(int id, string name, string description, object addData)
//        : base(name, description, addData)
//    {
//        Id = id;

//    }
//}


//public class Cardstring : BaseCard
//{
//    public string Id { get; set; }

//    public Cardstring(string id, string name, string description, object addData)
//        : base(name, description, addData)
//    {
//        Id = id;

//    }
//}

//public class Card<T> : BaseCard
//{
//    public T Id { get; set; }
//    public Card(T id, string name, string description, object addData)
//        : base(name, description, addData)
//    {
//        Id = id;
//    }


//    public TData GetDataAdd<TData>()
//    {
//        return (TData)AddData;
//    }
//}