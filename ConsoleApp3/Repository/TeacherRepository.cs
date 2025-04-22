
using SM.Models;
using SM.Repository;

public interface ITeacherRepository : IRepsitory<TeacherModel>,IInfo 
{

    void AddTeacherToModul(TeacherModel teacher, string modulId);

    ICollection<StudentModel> GetStudents(string id);
    ICollection<StudentModel> GetStudents(string id, ModulModel model);

    ICollection<ModulModel> GetModuls(string id);
    ICollection<ModulModel> GetModuls(string id, RowModel row);


    ICollection<RowModel> GetRows(string id);



}
public class TeacherRepository : Repository<TeacherModel>, ITeacherRepository
{

    private readonly IRowRepository _rowRepository;
    private readonly ISchoolRepository _schoolRepository;
    public TeacherRepository(IRowRepository rowRepository, ISchoolRepository schoolRepository)
    {
        _rowRepository = rowRepository;
        _schoolRepository = schoolRepository;
    }
    public ICollection<StudentModel> GetStudents(string id)
    {
        var teacher = GetById(id);
        return teacher?.Moduls?
            .SelectMany(m => _rowRepository.GetById(m.RowId)?.Students ?? new List<StudentModel>())
            .Distinct()
            .ToList() ?? new List<StudentModel>();
    }



    public ICollection<StudentModel> GetStudents(string id, ModulModel model)
    {
        return _rowRepository.GetById(model.RowId)?.Students ?? new List<StudentModel>();
    }

    public ICollection<ModulModel> GetModuls(string id)
    {
        return GetById(id)?.Moduls?.ToList() ?? new List<ModulModel>();
    }

    public ICollection<ModulModel> GetModuls(string id, RowModel row)
    {
        return GetById(id)?.Moduls?
            .Where(m => m.RowId == row.Id)
            .ToList() ?? new List<ModulModel>();
    }

    public ICollection<RowModel> GetRows(string id)
    {
        return GetById(id)?.Moduls?
            .Select(m => _rowRepository.GetById(m.RowId))
            .Where(r => r != null)
            .Distinct()
            .ToList() ?? new List<RowModel>();
    }



    public void AddTeacherToModul(TeacherModel teacher, string modulId)
    {
        var modul = _schoolRepository
            .GetAll()
            .SelectMany(s => s.Rows)
            .SelectMany(r => r.Moduls)
            .FirstOrDefault(m => m.Id == modulId);

        if (modul == null)
            throw new Exception(" modul");

        modul.Teachers ??= new List<TeacherModel>();
        if (!modul.Teachers.Any(t => t.Id == teacher.Id))
            modul.Teachers.Add(teacher);

        teacher.Moduls ??= new List<ModulModel>();
        if (!teacher.Moduls.Any(m => m.Id == modul.Id))
            teacher.Moduls.Add(modul);
    }

    public void Info()
    {
        foreach (var teacher in GetAll())
        {
            Console.WriteLine($" Teacher: {teacher.Name}");
        }
    }

    public IEnumerable<TeacherModel> GetAll()
    {
        return Items.ToList();
    }
}


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