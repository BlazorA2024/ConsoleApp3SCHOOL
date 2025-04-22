
using SM.Models;
using SM.Repository;

public interface IRowRepository : IRepsitory<RowModel> ,IInfo
{
    void AddModul(string id, ModulModel modul);
    void AddTeacher(string id, TeacherModel teacher);
    void AddStudent(string id, StudentModel student);
  
    void AddTeacherToModul(TeacherModel teacher, string modulId);
}



public class RowRepository : Repository<RowModel>, IRowRepository
{

    private readonly IModulRepository _modulRepository;
    private readonly ITeacherRepository _teacherRepository;
    private readonly IStudentRepository _studentRepository;

    public RowRepository() 
    {

    }


    public void AddModul(string id, ModulModel modul)
    {
        var row = Items.FirstOrDefault(r => r.Id == id);
        if (row != null)
        {
           
            modul.RowId = row.Id;
            modul.RowName = row.Name;
           // _modulRepository.BuildRow(row);
            row.Moduls ??= new List<ModulModel>();
            row.Moduls.Add(modul);
        }
        else
        {
            throw new Exception("Row not found");
        }
    }


   

    public void AddStudent(string id, StudentModel student)
    {
        var row = Items.FirstOrDefault(r => r.Id == id);
        if (row != null)
        {
            student.Row = row;
            student.RowId = row.Id;
            row.Students.Add(student);
        }
        else
        {
            throw new Exception("Row not found");
        }
    }
    public void AddTeacher(string id, TeacherModel teacher)
    {
        var row = Items.FirstOrDefault(r => r.Id == id);
        if (row != null)
        {
            teacher.RowId = row.Id; // فقط إذا TeacherModel فيه RowId
            row.Teachers ??= new List<TeacherModel>();
            row.Teachers.Add(teacher);
        }
        else
        {
            throw new Exception("Row not found");
        }
    }






    public void AddTeacherToModul(TeacherModel teacher, string modulId)
    {
      
        foreach (var row in Items)
        {
            var modul = row.Moduls.FirstOrDefault(m => m.Id == modulId);
            if (modul != null)
            {
               
                if (modul.Teachers == null)
                    modul.Teachers = new List<TeacherModel>();

              
                if (!modul.Teachers.Contains(teacher))
                {
                    modul.Teachers.Add(teacher);
                }

                if (row.Teachers == null)
                    row.Teachers = new List<TeacherModel>();

                if (!row.Teachers.Contains(teacher))
                    row.Teachers.Add(teacher);

                return;
            }
        }

        throw new Exception("Modul not found in any row");
    }


    public void Info()
    {
        foreach (var row in GetAll())
        {
            Console.WriteLine($" Row: {row.Name}, Students: {row.Students?.Count}, Modules: {row.Moduls?.Count}, Teachers : {row.Teachers?.Count}");

        }
    }

    public IEnumerable<RowModel> GetAll()
    {
        return Items.ToList();
    }
}

