

using SM.CardStudents;

namespace SM.Models;
public class NameModel
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string FullName => $"{Name} {Title}";
}


public class SchoolModel
{
    public string Id { get; set; } = new IDgenerate().GenvetId("School", '-', 10, 4, 3);
    public string Name { get; set; }
    public ICollection<RowModel> Rows { get; set; } = new List<RowModel>();
    public ICollection<TeacherModel> Teachers { get; set; } = new List<TeacherModel>();
    public ICollection<StudentModel> Students { get; set; } = new List<StudentModel>();

    public ICollection<ModulModel> Moduls { get; set; } = new List<ModulModel>();
}
public class Cardstu
{
    public string Id { get; set; } = new IDgenerate().GenvetId("Card", '-', 10, 4, 3);
    public Name Name { get; set; }
    public Date Date { get; set; }
    public SexType? SexType { get; set; }

}
public class CardModel
{
    public string Id { get; set; } = new IDgenerate().GenvetId("Card", '-', 10, 4, 3);
    public NameModel Name { get; set; }
    public Date Date { get; set; }
    public SexType? SexType { get; set; }

}
public class StudentModel
{
    public string Id { get; set; } = new IDgenerate().GenvetId("Student", '-', 10, 4, 3);
    public string RowId { get; set; }
    public RowModel Row { get; set; }
    public CardModel card {  get; set; }  
    public ICollection<ModulModel> Moduls { get; set; } = new List<ModulModel>();
    public ICollection<TeacherModel> Teachers { get; set; } = new List<TeacherModel>();
}
public class RowModel
{
    public string Id { get; set; } = new IDgenerate().GenvetId("Row", '-', 10, 4, 3);
    public string Name { get; set; }
    public string RowId { get; set; }
    public string RowName { get; set; }
    public ICollection<ModulModel> Moduls { get; set; } = new List<ModulModel>();
    public ICollection<TeacherModel> Teachers { get; set; } = new List<TeacherModel>();
    public ICollection<StudentModel> Students { get; set; } = new List<StudentModel>();

  
}



public class ModulModel
{
    public string Id { get; set; } = new IDgenerate().GenvetId("Modul", '-', 10, 4, 3);
    public string Name { get; set; }
    public string RowId { get; set; }
    public string RowName { get; set; }
    public ICollection<TeacherModel> Teachers { get; set; } = new List<TeacherModel>();
    public ICollection<StudentModel> Students { get; set; } = new List<StudentModel>();
}



public class TeacherModel
{
    public string Id { get; set; } = new IDgenerate().GenvetId("Teacher", '-', 10, 4, 3);
    public string Name { get; set; }
    public string RowId { get; set; }
    public string RowName { get; set; }
    public ICollection<ModulModel> Moduls { get; set; } = new List<ModulModel>();
    public ICollection<StudentModel> Students { get; set; } = new List<StudentModel>();
}
