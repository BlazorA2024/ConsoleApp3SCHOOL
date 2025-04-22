
using SM.Models;
using SM.Repository;

public interface IModulRepository : IRepsitory<ModulModel>,IInfo
{
    void BuildRow(RowModel row);
    void AddModulesToRow(RowModel row);
}

public class ModulRepository : Repository<ModulModel>, IModulRepository
{


    public void BuildRow(RowModel row)
    {
       var modul = new ModulModel();
        modul.Id = row.Id;
        modul.Name = row.Name;
       
    }
    public void AddModulesToRow(RowModel row)
{

    foreach (var moduleName in GetAll())
    {
        var modul = new ModulModel
        {
           
            Name = moduleName.Name,
            RowId = row.Id,
            RowName = row.Name,
            Teachers = new List<TeacherModel>()
        };

        row.Moduls.Add(modul);

        Add(modul);
    }
}



    public void Info()
    {
        foreach (var modul in GetAll())
        {
            Console.WriteLine($" Module: {modul.Name}, Row: {modul.RowName}");

            if (modul.Teachers != null && modul.Teachers.Count > 0)
            {
                foreach (var teacher in modul.Teachers)
                {
                    Console.WriteLine($"    Teacher: {teacher.Name}");
                }
            }
            else
            {
                Console.WriteLine("    No teachers assigned.");
            }
        }
    }

   

    public IEnumerable<ModulModel> GetAll()
    {
        return Items.ToList();
    }
}

