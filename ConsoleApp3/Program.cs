//Name n = new Name("Fatimah Ali sdfghy", "MsAltwail");
//SexType sex = new SexType(); sex.SetType("Female");
//Date d = new Date(1, 4, 2025);
//IDgenerate id = new();
//CardStudent card = new CardStudent(id, n, d, sex);
////card.Info();
//Console.WriteLine("Hello!");

//Student st = new Student(card);
//Rowsschool row1 = new Rowsschool("fgirst");
//row1.AddStudent(st);
//School school=new School("TRE");
////Modul modul = new Modul("Quran", row1.GetRowID());
////modul.BuildRow(row1);
////Teacher teacher = new(card, row1.GetRowID(), "F");
////teacher.AddModul(modul);

//school.AddStudent(st, row1.GetRowID());
//school.AddStudent(st, row1.GetRowID());
//school.ShowAll();
////school.Info();
//Console.WriteLine("--------------Teacher1------------------!");
//Name n1 = new Name("Abodul Rhamen Ali sdfghy", "MsAltwail");
//SexType sex1 = new SexType(); sex.SetType("Female");
//Date d1 = new Date(1, 4, 2025);
//IDgenerate id1 = new();
//CardStudent card1 = new CardStudent(id1, n1, d1, sex1);

//Modul modul1 = new Modul("Quran", row1.GetRowID());
//modul1.BuildRow(row1);


//Modul modul2 = new Modul("Quran", row1.GetRowID());
//modul2.BuildRow(row1);
//Console.WriteLine(modul2);
//Teacher teacher1 = new(card1, row1.GetRowID(), "F");


//teacher1.AddModul(modul1);
////teacher.Info();
//School school1 = new School("kg");
//school1.AddTeacher(teacher1);
////CardStudent card2=new CardStudent(id1, n1, d1, sex1);
////Teacher t2 = new Teacher(card1, row1.GetRowID(),"F");

////school1.AddTeacher(t2);

//school1.AddTeacherToModul(teacher1,modul1.getmodulid());


//school1.ShowAll();
using SM.CardStudents;
using SM.Models;

//var schoolRepo = new SchoolRepository();

//// إنشاء صف جديد
//var row = new RowModel { Name = "الصف الأول", RowId = "A1", RowName = "الأول A" };
//schoolRepo.AddRow(row);

//// إنشاء طالب جديد
//var student = new StudentModel();

//// إضافة الطالب إلى الصف
//schoolRepo.AddStudent(nameModel, row.Id);

//// التحقق
//Console.WriteLine($"The student has been added to the class.: {student.Row?.RowName}");


var schoolRepository1 = new SchoolRepository();

var row1 = new RowModel { Name = "A-1", RowName = "B-1" };
var row2 = new RowModel { Name = "A-2", RowName = "B-2" };

schoolRepository1.AddRow(row1);
schoolRepository1.AddRow(row1);

schoolRepository1.AddRow(row2);

var student1 = new StudentModel
{
    card = new CardModel
    {
        Name = new NameModel { Name = "fghrft", Title = "fghdf" },
      // SexType = SexType,
       // Date = new Date { Day = "12", Month = 4, Year = 2010 }
    }
};

schoolRepository1.AddStudent(student1, row1.Id);
schoolRepository1.AddStudent(student1, row1.Id);


var modul = new ModulModel{ Name = "R"  };
var modul2 = new ModulModel { Name = "R" };
schoolRepository1.AddModul(modul, row1.Id);
schoolRepository1.AddModul(modul2, row2.Id);
//schoolRepository1.AddModul(modul, row1.Id);

var teacher1 = new TeacherModel
{
    Name = ". ansggf"
};
var teacher2 = new TeacherModel
{
    Name = ". jik"
};
schoolRepository1.AddTeacher(teacher1);
schoolRepository1.AddTeacher(teacher1);

schoolRepository1.AddTeacherToModul(teacher1, modul.Id);
schoolRepository1.AddTeacherToModul(teacher1, modul.Id);

schoolRepository1.ShowAll();
//Console.WriteLine($"  NameModel: {student1.card.Name?.FullName}");

//Console.WriteLine($"Row: {student1.Row?.Name}");
