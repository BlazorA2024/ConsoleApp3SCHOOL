using System;
using System.Collections.Generic;
namespace SM.CardStudents; 
public class Name
{
    private readonly string name;
    private readonly string title;

    public Name(string n, string t)
    {
        if (CheckLength(n, 2, 5) && CheckLength(t, 0, 1))
        {
            this.name = n;
            this.title = t;
        }
        else
        {
            Console.WriteLine("checkLength");
        }
    }

    private bool CheckLength(string str, int s, int k)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == ' ')
            {
                count++;
            }
        }
        return count >= s && count <= k;
    }

    public string GetName() => name;

    public string GetTitle() => title;

    public string GetFullName() => name + " " + title;

    public void Info()
    {
        Console.WriteLine("Full Name: " + name + " " + title);
    }
}

public class IDgenerate
{
    private protected string id;
    private static int MAX_IDS = 100;
    private static string[] usedIDs = new string[MAX_IDS];
    private static int usedCount = 0;

    public IDgenerate()
    {
        id = "";
    }

    public bool IsEqual(string otherId)
    {
        return this.id == otherId;
    }

    public static bool IsFound(string Id)
    {
        for (int i = 0; i < usedCount; i++)
        {
            if (usedIDs[i] == Id)
                return true;
        }
        return false;
    }

    public void Research(string newID)
    {
        bool found = false;
        for (int i = 0; i < usedCount; i++)
        {
            if (usedIDs[i] == newID)
            {
                Console.WriteLine("ID = " + newID);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("false " + newID);
        }
    }

    private int GetRandomNumber(int n)
    {
        Random rand = new Random();
        int c;
        do
        {
            c = rand.Next(n);
        } while (c <= 0);
        return c;
    }

    private string GenerateRandomString(int n, int c)
    {
        string temp = "";
        for (int i = 0; i < c; i++)
        {
            int d = GetRandomNumber(n);
            char ch = (char)('0' + d);
            temp += ch;
        }
        return temp;
    }

    //public string GenerateID(string prefix, char ch, int n, int c, int k)
    //{
    //    string temp;
    //    do
    //    {
    //         temp = prefix;
    //        for (int i = 0; i < k; i++)
    //        {
    //            temp += ch + GenerateRandomString(n, c);
    //        }
    //    } while (IsFound(temp));

    //    id = temp;
    //    usedIDs[usedCount++] = temp;

    //    return temp;
    //}
    public string GenvetId(string pvx, char ch, int n, int c, int k)
    {
        string temp = pvx;
        for (int i = 0; i < k; i++)
        {
            temp += ch + GenerateRandomString(n, c);
        }
        while (IsFound(temp)) ;
        id = temp;
        usedIDs[usedCount++] = temp;

        return temp;

    }
    public string GetId()
    {
        return id;
    }

    public void Info()
    {
        Console.WriteLine(id);
    }
}



public class Date
{
    private int day;
    private int month;
    private int year;

    public Date(int d, int m, int y)
    {
        day = d;
        month = m;
        year = y;
    }

    public void SetDate(int d, int m, int y)
    {
        day = d;
        month = m;
        year = y;
    }

    public void SetExpiryDate(int d, int m, int y)
    {
        month = m + 6;
        year = y;

        if (month > 12)
        {
            month -= 12;
            year += 1;
        }

        day = d;
    }

    public void GetLocalTimeDate(out int d, out int m, out int y)
    {
        DateTime now = DateTime.Now;
        d = now.Day;
        m = now.Month;
        y = now.Year;
    }

    public bool IsExpired()
    {
        GetLocalTimeDate(out int d, out int m, out int y);

        if (year < y || (year == y && month < m) || (year == y && month == m && day < d))
        {
            Console.Write("The card is still valid until: ");
            DisplayDate();
            return true;
        }
        else
        {
            Console.Write("AutoRenew: ");
            DisplayDate();
            return false;
        }
    }

    public void DisplayDate()
    {
        Console.WriteLine($"{year}/{month:D2}/{day:D2}");
    }

    public int GetDay() => day;
    public int GetMonth() => month;
    public int GetYear() => year;
}



public class SexType
{
    private string _typeSex;

    private static readonly string[] Types = { "Male", "Female" };

    public void SetType(string type)
    {
        if (string.IsNullOrWhiteSpace(type))
        {
            Console.WriteLine("_typeSex.");
            return;
        }

        bool valid = Array.Exists(Types, t => t == type);

        if (!valid)
        {
            Console.WriteLine("TypesCount: " + type);
        }
        else
        {
            _typeSex = type;
        }
    }

    public string GetType() => _typeSex;

    public void Info()
    {
        Console.WriteLine("\nType: " + _typeSex);
    }
}
public class CardStudent
{
    private string idcard;
    private IDgenerate id;
    private Name name;
    private Date date;
    private SexType sexType;

    public static int CardStudentCount = 0;
    private static HashSet<IDgenerate> usedIDs = new HashSet<IDgenerate>();

    public CardStudent(IDgenerate id, Name name, Date date, SexType sexType)
    {
        if (usedIDs.Contains(id))
        {
            
            throw new InvalidOperationException(
                "ID already exists. Please generate a new ID.");
        }
        this.id = id;
         usedIDs.Add(id);
        this.name = name;
        this.date = date;
        this.sexType = sexType;
        // idcard = id.GenerateID("Card", '-', 10, 4, 3);
        CardStudentCount++;

    }

    public Date GetDate() => date;

    public Name GetName() => name;

    public SexType GetSex() => sexType;

    public string GetId() => id.GetId();

    public string GetCardStudentId() => idcard;

    public void Info()
    {
        id.Info();
        name.Info();
        date.DisplayDate();
        sexType.Info();
    }

    public void AutoRenew()
    {
        date.GetLocalTimeDate(out int currentDay, out int currentMonth, out int currentYear);
        date.SetExpiryDate(currentDay, currentMonth, currentYear);
    }

    public bool IsEqualName(Name name)
    {
        return this.name.GetFullName() == name.GetFullName();
    }

    public void UpdateDate()
    {
        date.GetLocalTimeDate(out int currentDay, out int currentMonth, out int currentYear);
        date.SetExpiryDate(currentDay, currentMonth, currentYear);
    }

    public void Update(string id, Name oldname, Name newname)
    {
        if (this.id.IsEqual(id) && IsEqualName(oldname))
        {
            UpdateName(newname);
            UpdateDate();
        }
    }

    private void UpdateName(Name newName)
    {
        if (!IsEqualName(newName))
        {
            this.name = newName;
        }
    }
}
