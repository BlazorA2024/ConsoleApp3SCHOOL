//using SM.CardStudents;
//using SM.IModuls;
//using System;
//using System.Reflection;
//namespace SM.IStudents;

//public interface IStudent : IInfo
//{
//    ICollection<Modul> GetModuls();

//}
//public class Student : IStudent
//{
//    private string id;
//    private CardStudent card;
//    private List<Modul> moduls = new();
//    private Rowsschool? row;
//    public static int _CountStudent { get; private set; } = 0;

//    public Student(CardStudent card)
//    {
//        this.card = card;
//        IDgenerate idf = new IDgenerate();
//        id = idf.GenvetId("Student", '-', 10, 4, 3);
//        _CountStudent++;
//    }
//    public void BuildRowstudent(Rowsschool row) => this.row = row;

//    public void AddModulstudent(Modul modul)
//    {
//        if (modul != null && !moduls.Contains(modul))
//            moduls.Add(modul);
//    }
//    public Rowsschool? GetStudentRow() => row;
//    public string? GetRowStudent() => row?.GetRowName();
//    public string? GetRowIdStudent() => row?.GetRowID();

//    public string GetStudentId() => id;
//    public int GetCountStudent() => _CountStudent;


//    //public void Infoff()
//    //{
//    //    //  card.Info();
//    //    if (moduls.Count == 0)
//    //    {
//    //        Console.WriteLine("- No modules enrolled.");
//    //    }
//    //    else
//    //    {
//    //        foreach (var modul in moduls)
//    //        {
//    //            Console.WriteLine($"- {modul.Name} | ID: {modul.Id}  | ROW: {modul.GetRowmodl()}");
//    //        }
//    //    }
//    //    Console.WriteLine("-------------------------------");

//    //}
//    public void Info()
//    {
//        Console.WriteLine("===== Student Info =====");
//        Console.WriteLine($"Student ID   : {id}");
//        Console.WriteLine($"Student Name : {GetCardName()}");

//        Console.WriteLine($"Student Row  : {GetRowStudent()}");
//        Console.WriteLine($"Student Row ID : {GetRowIdStudent()}");
//        Console.WriteLine($"_CountStudent: {GetCountStudent()}");

//        //Console.WriteLine("Modules Enrolled:");

//        //Console.WriteLine("-------------------------------");
//    }

//    public CardStudent GetCard() => card;

//    public string GetCardName()
//    {
//        return card.GetName().GetFullName();
//    }

//    public void UpdateCard(CardStudent oldCard, Name newName)
//    {
//        card.Update(oldCard.GetId(), oldCard.GetName(), newName);
//    }

//    public void UpdateCardDate()
//    {
//        card.UpdateDate();
//    }

//    public ICollection<Modul> GetModuls()
//    {
//        return moduls;
//    }
//}
