
using exp1;
using SM.Models;
using SM.Repository;
using System.ComponentModel.DataAnnotations;
public interface IInfo
{
    void Info();
}

public interface ISchoolRepository : IRepsitory<SchoolModel>, IInfo
{
    void AddRow(RowModel row);
    void AddTeacher(string teacherId, string schoolId);
    void AddStudent(StudentModel student, string rowId);
    void AddStudent(StudentModel student);
    void AddStudent(StudentModel student, string rowId,string schoolId);


    void AddModul(ModulModel modul, string rowId);
    void AddTeacherToModul(TeacherModel teacher, string modulId);
    void ShowAll();
}








public class SchoolRepository : Repository<SchoolModel>, ISchoolRepository
{

    private readonly ISchoolRepository _ISchoolRepository;
    private readonly IRowRepository _rowRepository;
    private readonly ITeacherRepository _teacherRepository;
    private readonly IStudentRepository _studentRepository;
    private readonly IModulRepository _modulRepository;
    private readonly INameRepository _nameRepository;
    //private readonly ICardRepository _cardRepository;


    public SchoolRepository()
    {
        _rowRepository = new RowRepository();
        _teacherRepository = new TeacherRepository();
        _nameRepository = new NameRepository(); 
        _modulRepository = new ModulRepository();
        _studentRepository = new StudentRepository();



    }

    public void AddModul(ModulModel modul, string rowId)
    {
        var row = _rowRepository.GetById(rowId);
        if (row == null) throw new Exception("Row not found");
        if (Validator.Validate(row.Moduls, modul))
        {
            //modul.RowId = row.Id;
           // modul.RowName = row.Name;
            _rowRepository.AddModul(rowId, modul);
          //  row.Moduls.Add(modul);
            _modulRepository.Add(modul);
           // _modulRepository.AddModulesToRow(row);


        }
    }
    public void AddRow(RowModel row)
    {

        var shcool = GetById(row.SchoolId);

        if(shcool == null)
        {
            return;
        }
         row.School=shcool;


        _rowRepository.Add(row);


    }


    public void AddStudent(StudentModel student, string rowId)
    {

        var row = _rowRepository.GetById(rowId);

        if (row == null)
        {
            throw new Exception("Row not found");
        }
        if (Validator.Validate(row.Students, student))
        { 

            student.Row = row;
            student.RowId = row.Id;
            _rowRepository.AddStudent(rowId, student);
            _studentRepository.Add(student);

            // row.Students.Add(student);
        }
    }

    public void AddStudent(StudentModel student)
    {
        
    }

    public void AddStudent(StudentModel student, string rowId, string schoolId)
    {
       
    }

    public void AddTeacher(string teacherId,string schoolId)
    {
        var  teache = _teacherRepository.GetById(teacherId);
        var shcool = GetById(schoolId);
        if(shcool.Teachers.Contains(teache))
        {
            Console.WriteLine("Error: Teacher already exists in the school.");

            return;
        }
        shcool.Teachers.Add(teache);
        
        teache.SchoolModels.Add(shcool);




    }

    //public void AddTeacher(TeacherModel teacher)
    //{


    //        _teacherRepository.Add(teacher);
    //        // _teacherRepository.(teacher,)
    //        //row.Teachers.Add(teacher);

    //}
    public void AddTeacherToModul(TeacherModel teacher, string modulId)
    {
            var modul = _modulRepository.GetById(modulId);
            if (modul == null)
                throw new Exception("Module not found");
        if (Validator.Validate(modul.Teachers, teacher))
        {
            
            if (modul.Teachers == null)
                modul.Teachers = new List<TeacherModel>();
       

           
            if (!modul.Teachers.Contains(teacher))
                modul.Teachers.Add(teacher);

       
            _rowRepository.AddTeacherToModul(teacher, modulId);
        }

    }

    //public void AddTeacherToModul(TeacherModel teacher, string modulId)
    //{
    //    var modul = _modulRepository.GetById(modulId);
    //    if (modul == null)
    //        throw new Exception("Module not found");

    //    if (modul.Teachers == null)
    //        modul.Teachers = new List<TeacherModel>();

    //    modul.Teachers.Add(teacher);
    //}

    public void Info()
    {
        throw new NotImplementedException();
    }

    public void ShowAll()
    {
        Console.WriteLine("===== School Info =====");

        _teacherRepository.Info();
        _studentRepository.Info();
        _modulRepository.Info();
        _rowRepository.Info();
    }


    
}
public abstract class Printer
{
    public static void PrintAll(params IEnumerable<IInfo>[] collections)
    {
        foreach (var collection in collections)
        {
            foreach (var item in collection)
            {
                item.Info();
            }

        }
    }

}

public abstract class Validator
{
    public static bool Validate<T>(ICollection<T> items, T item) where T : class
    {

        foreach (var ob in items)
        {
            if (ob == item)
            {
                Console.WriteLine("Error: Null item found in the list.");
                return false;
            }

        }

        return true;

    }
}







//public void ShowAll()
//{
//    Console.WriteLine("===== School Info =====");

//    Console.WriteLine("== Teachers ==");
//    foreach (var teacher in _teacherRepository.GetAll())
//    {
//        Console.WriteLine($" Teacher: {teacher.Name}");
//    }

//    Console.WriteLine("\n== Students ==");
//    foreach (var student in _studentRepository.GetAll())
//    {
//        Console.WriteLine($"Student: {student.card.Name.FullName}, Row: {student.Row?.Name}");
//    }

//    Console.WriteLine("\n== Modules ==");
//    foreach (var modul in _modulRepository.GetAll())
//    {
//        Console.WriteLine($" Module: {modul.Name}, Row: {modul.RowName}, Teacher:");
//    }

//    Console.WriteLine("\n== Rows ==");
//    foreach (var row in _rowRepository.GetAll())
//    {
//        Console.WriteLine($" Row: {row.Name}, Students: {row.Students?.Count}, Modules: {row.Moduls?.Count}");
//    }
//}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                