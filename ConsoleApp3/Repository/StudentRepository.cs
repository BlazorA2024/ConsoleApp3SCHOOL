
using SM.Models;
using SM.Repository;
using System.Reflection;


public interface IStudentRepository : IRepsitory<StudentModel>, IInfo
{


    RowModel GetRow(string id);

    ICollection<ModulModel> GetModuls(string id);

    ICollection<TeacherModel> GetTeachers(string id);

    bool UpdateCard(CardModel card);




}

public class StudentRepository : Repository<StudentModel>, IStudentRepository
{


    private readonly IRowRepository _rowRepository;
    private readonly INameRepository _nameRepository;

    public StudentRepository(IRowRepository rowRepository, INameRepository nameRepository)
    {
        _rowRepository = rowRepository;
        _nameRepository = nameRepository;
    }
    public RowModel GetRow(string id)
    {
        var student = GetById(id);
        return student?.Row;
    }


    public ICollection<ModulModel> GetModuls(string id)
    {
        var student = GetById(id);
        return student?.Moduls ?? new List<ModulModel>();
    }

    public ICollection<TeacherModel> GetTeachers(string id)
    {
        var student = GetById(id);
        return student?.Teachers ?? new List<TeacherModel>();

    }
    public bool UpdateCard(CardModel card)
    {
        var student = Items.FirstOrDefault(s => s.Id == card.Id);
        if (student == null) return false;

        student.card = card;
        return true;
    }
    public void Info()
    {
        foreach (var student in GetAll())
        {
            Console.WriteLine($" Student: {student.card.Name.FullName} - Row: {student.Row?.Name}");
        }
    }

    public IEnumerable<StudentModel> GetAll()
    {
        return Items.ToList();
    }
    
}

