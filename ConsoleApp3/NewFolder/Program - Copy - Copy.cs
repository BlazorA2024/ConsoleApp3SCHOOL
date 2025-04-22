//namespace exp1;

//public  interface IInfo
//{
//    void Info();

//}

//public  interface IPerson : IInfo
//{
//    string Name { get; }
//    string Address { get; set; }
//    string SureName { get; }

//    string GetGender();




//}

//// 
//public class Person: IPerson
//{

//    // filds
//    private readonly string _name; 
//    private readonly string _surname;

//    private readonly  string _sex;
  
//    protected string _address;

   
//    public static  int CountPersons { get; private set; } = 0;

//    public string Name => _name;

//    public string Address { get => _address; 
//        set =>_address=value; }

//    public string SureName => _surname;

//    public static    readonly int  MAXNUMOFNAME=6;
//    private static  bool isValidName(string name)
//    {
//        return !string.IsNullOrEmpty(name);
//    }
//    public Person(string name, string surname,string sex,string address)
//    {
//        if (!isValidName(name))
//        {
//            throw new ArgumentException("Name cannot be null or empty", nameof(name));
//        }
//        _name = name;
       
//        _surname = surname;
//        _sex = sex;
      
//        _address = address;
//        ++CountPersons;
//    }



//    public virtual void Info()
//    {

//        Console.WriteLine($"Name: {_name}");
//        Console.WriteLine($"Surname: {_surname}");
//        Console.WriteLine($"Sex :{_sex }");
//        Console.WriteLine($"Address: {_address}");



//    }

//    public string GetGender()
//    {
//        return _sex;
//    }
//}

//public  interface IEmployee:IPerson
//{
//    int GetId();
//    string GetPosition();
//    string GetSalary();
//    string GetWorkExperience();
//    string GetWorkAddress();
//}

//public  class Emp : Person, IEmployee
//{


//    private int _id;
//    private string _position;
//    private string _salary;
//    private string _workExperience;
//    private string _workAddress;
//    public Emp(int id,string name, string surname,string sex, string address, string position, string salary, string workExperience, string workAddress) : base(name, surname, sex, address)
//    {
//        _id = id;
//        _position = position;
//        _salary = salary;
//        _workExperience = workExperience;
//        _workAddress = workAddress;
//    }
//    public string GetPosition()
//    {

    
//        return _position;
//    }
//    public string GetSalary()
//    {
//        return _salary;
//    }
//    public string GetWorkExperience()
//    {
//        return _workExperience;
//    }

//    public string GetWorkAddress()
//    {
//        return _workAddress;
//    }

//    public  int GetId()
//    {
//        return _id;
//    }

//    public override void Info()
//    {
//        base.Info();
//        Console.WriteLine($"ID: {_id}");
//        Console.WriteLine($"Position: {_position}");
//        Console.WriteLine($"Salary: {_salary}");
//        Console.WriteLine($"Work Experience: {_workExperience}");
//        Console.WriteLine($"Work Address: {_workAddress}");

//    }


//}

//public interface ITach
//{
//    void Verify();
//    void Check();

//    bool IsVerified();
//    bool IsChecked();
//    string GetSubject();
//}


//public abstract class BaseTeacher : Emp ,ITach
//{    private string _subject="fsdfs";
//    protected BaseTeacher(int id, string name, string surname, string sex, string address, string position, string salary, string workExperience, string workAddress) : base(id, name, surname, sex, address, position, salary, workExperience, workAddress)
//    {
//    }

//    public void Verify()
//    {
//        Console.WriteLine("Tach verified.");
//    }
//    public void Check()
//    {
//        Console.WriteLine("Tach checked.");
//    }
//    public bool IsVerified()
//    {
//        return true;
//    }
//    public bool IsChecked()
//    {
//        return true;
//    }

//    public string GetSubject()
//    {
//        return _subject;
//    }

//}
//public interface ITeacherR : IEmployee, ITach
//{

//    // Add any additional methods or properties specific to ITeacherR here
//    // For example:
//    void  Runing();

//}

//public class TeacherR :  BaseTeacher, ITeacherR
//{

    

//    public TeacherR(int id, string name, string surname, string sex, string address, string position, string salary, string workExperience, string workAddress) : base(id, name, surname, sex, address, position, salary, workExperience, workAddress)
//    {
//    }

//    public void Runing()
//    {
//        throw new NotImplementedException();
//    }
//}
//public interface ITeacherS: IEmployee, ITach
//{

//    // Add any additional methods or properties specific to ITeacherR here
//    // For example:
//    void Swam();

//}
//public class TeacherS : BaseTeacher, ITeacherS
//{
//    public TeacherS(int id, string name, string surname, string sex, string address, string position, string salary, string workExperience, string workAddress) : base(id, name, surname, sex, address, position, salary, workExperience, workAddress)
//    {
//    }

//    public void Swam()
//    {
//        throw new NotImplementedException();
//    }
//}
//public class Pinter
//{

//    public void Print<T>(T message)
//    {

     
//        if (message is IInfo info1)
//        {
//            info1.Info();
//        }
//        else
//        {
//            Console.WriteLine(message);
//        }
//    }

//    public void Print2(string message2)
//    {



//        Console.WriteLine(message2);
//    }

//}