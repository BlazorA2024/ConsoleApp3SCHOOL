//using SM.CardStudents;
//using System;
//using System.Reflection;
//namespace SM.IModuls;

//public interface IModul : IInfo
//{
//    string Id { get; }
//    string Name { get; }
//    string IdRowClass { get; }
//    Rowsschool? GetRow();
//    string? GetRowmodl();
//    string getmodulid();
//    string getName() => Name;
//    string getIdRowClass();

//}
//public class Modul  : IModul
//{
//    private string _Id;
//    private string _Name;
//    private string _IdRowClass;
//    private Rowsschool? row;

//    private static readonly string[] ModulDs = { "Quran", "Islamic", "Sciences", "Mathematics" };

//    public string Id => _Id;

//    public string Name => _Name;

//    public string IdRowClass => _IdRowClass;

//    public Modul(string name, string idRowClass)
//    {

        

//        IDgenerate idf = new();
//        _Id = idf.GenvetId("modul", '-', 10, 4, 3);
//        _IdRowClass = idRowClass;
//        SetModul(name);
//    }

//    public void BuildRow(Rowsschool row) => this.row = row;

//    public void SetModul(string m)
//    {
//        if (Array.Exists(ModulDs, x => x == m))
//        {
//            _Name = m;
//        }
//        else
//        {
//            Console.WriteLine($"Invalid Modul: {m}");
//        }
//    }

//    public Rowsschool? GetRow() => row;
//    public string? GetRowmodl() => row.GetRowName();
//    public string getmodulid() => Id;
//    public string getName() => Name;
//    public string getIdRowClass() => IdRowClass;
//    public void Info()
//    {
//        Console.WriteLine("Modul: " + Name);
//        Console.WriteLine("id: " + Id);
//        Console.WriteLine("idrowclass: " + IdRowClass);
//        Console.WriteLine("row: " + row.GetRowName());
//        Console.WriteLine("-------------------------------");
//    }


//    public override bool Equals(object? obj)
//    {

//        if (obj is Modul modul)
//        {
//            return  _Name == modul._Name && _IdRowClass == modul._IdRowClass;
//        }

        
//        return base.Equals(obj);
//    }
//    public override string ToString()
//    {
//        return $"Modul: {Name}, Id: {Id}, IdRowClass: {IdRowClass}";
//    }
    
//}