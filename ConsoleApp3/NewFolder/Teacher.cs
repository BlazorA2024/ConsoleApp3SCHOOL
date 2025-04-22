
//using SM.CardStudents;
//using SM.IModuls;
//using System;
//using System.Collections.Generic;
//namespace SM.ITeachers;



//public interface ITeacher :IInfo
//{
//    string Id { get; }
//    string JobName { get; }
//    string TeachrID { get; }
//   // void AddRowsschool(Rowsschool rows);
//    void AddModul(Modul modul);
//    string GetTeacherId();
//    string GetName();
//    string GetTeacherRowId();
//}

//public class Teacher : ITeacher
//{
//    private readonly string _Id;
//    private readonly string _JobName;
//    private readonly string _TeachrID;
//    private static int _CountTeacher  = 0;
//    private CardStudent card;
//    private List<Modul> moduls = new();
//    //private List<Rowsschool> row = new();

//    public string Id => _Id;
//    public string JobName => _JobName;
//    public string TeachrID => _TeachrID;

//    public Teacher(CardStudent card, string teachrID, string jobName)
//    {
//        this.card = card;
//        IDgenerate idf = new();
//        _Id = idf.GenvetId("Teacher", '-', 10, 4, 3);
//        _TeachrID = teachrID;
//        _JobName = jobName;
//        _CountTeacher++;
//    }

//    //public void AddRowsschool(Rowsschool rows)
//    //{
//    //    if (rows != null)
//    //        row.Add(rows);
//    //}

//    public void AddModul(Modul modul)
//    {
//        if (modul != null)
//            moduls.Add(modul);

//    }

//    public  void Info()
//    {
//        Console.WriteLine($" Teacher: {card.GetName().GetFullName()}");
//        Console.WriteLine($" ID: {_Id}");
//        Console.WriteLine($" Job Title: {_JobName}");
//        Console.WriteLine($" Row ID: {_TeachrID}");
//        Console.WriteLine($" CountTeacher: {_CountTeacher}");

//        Console.WriteLine("\n Modules Assigned:");
//        foreach (var modul in moduls)
//        {
//            Console.WriteLine($" -  {modul.getName()} (ID: {modul.getmodulid()}, Row: {modul.GetRowmodl()})");
//        }

//        Console.WriteLine("-------------------------------");
//    }

//    public string GetTeacherId() => Id;
//    public string GetName() => card.GetName().GetFullName();
//    public string GetTeacherRowId() => TeachrID;
//    public static int GetCountTeacher() => _CountTeacher;

//}



////using System;
////using System.Collections.Generic;
////using System.Reflection;
////public interface IInfo
////{
////    void Info();

////}
////public interface ITeacher
////{

////    public string Id { get; private set; }
////    public string JobName { get; private set; }
////    public string TeachrID { get; private set; }
////    private CardStudent card;

////    private List<Modul> moduls = new();
////    private List<Rowsschool> row = new();
////}
////public class Teacher : ITeacher
////{
////    public string Id { get; private set; }
////    public string JobName { get; private set; }
////    public string TeachrID { get; private set; }
////    private CardStudent card;

////    private List<Modul> moduls = new();
////    private List<Rowsschool> row = new();

////    public Teacher(CardStudent card,  string teachrID)
////    {
////        this.card = card;
////        IDgenerate idf = new();
////        Id = idf.GenvetId("Teacher", '-', 10, 4, 3);
////       // this.JobName = jobname;
////        TeachrID = teachrID;
////    }
////    public void AddRowsschool(Rowsschool rows)
////    {
////        if (rows != null)
////            row.Add(rows);
////    }
////    public void AddModul(Modul modul)
////    {
////        if (modul != null)
////            moduls.Add(modul);
////    }

////    public void Info()
////    {
////        Console.WriteLine("Teacher: " + card.GetName().GetFullName());
////        Console.WriteLine("ID: " + Id);
////        //Console.WriteLine("Job Title: " + JobName);
////       Console.WriteLine("Teacher Row ID:\n " + TeachrID);

////        Console.WriteLine("Modules Assigned:");
////        foreach (var modul in moduls)
////        {
////            Console.WriteLine($"- {modul.Name} |\n ID: {modul.Id} |\n Row: {modul.GetRowmodl()}");
////        }

////        Console.WriteLine("-------------------------------");
////    }

////    public string GetTeacherId() => Id;
////    public string GetName() => card.GetName().GetFullName();
////    public string GetTeacherRowId() => TeachrID;
////}


////public string GetTeacherId() => Id;
////    public string GetName() => Name;
////    public string GetTeacherRowId() => TeachrID;




////public class Teacher
////{
////    public string Id { get; private set; }
////    public string Name { get; private set; }
////    public string TeachrID { get; private set; }
////    private List<Modul> moduls = new();

////    public Teacher(string name, string teachrID)
////    {
////        IDgenerate idf = new();
////        Id = idf.GenvetId("Teacher", '-', 10, 4, 3);
////        Name = name;
////        TeachrID = teachrID;
////    }

////    public void AddModul(Modul modul)
////    {
////        if (modul != null)
////            moduls.Add(modul);
////    }

////    public void Info()
////    {
////        Console.WriteLine("Teacher: " + Name);
////        Console.WriteLine("ID: " + Id);
////        Console.WriteLine("Teacher Row ID:\n " + TeachrID);

////        Console.WriteLine("Modules Assigned:");
////        foreach (var modul in moduls)
////        {
////            Console.WriteLine($"- {modul.Name} |\n ID: {modul.Id} |\n Row: {modul.GetRowmodl()}");
////        }

////        Console.WriteLine("-------------------------------");
////    }

////    public string GetTeacherId() => Id;
////    public string GetName() => Name;
////    public string GetTeacherRowId() => TeachrID;

////}


