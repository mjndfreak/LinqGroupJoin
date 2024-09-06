using LinqGroupJoin;

var students = new List<Student>()
{
    new Student()  {StudendId = 1 , StudentName = "Ali" , ClassId = 1},
    new Student()  {StudendId = 2 , StudentName = "Ayşe" , ClassId = 2},
    new Student()  {StudendId = 3 , StudentName = "Mehmet" , ClassId = 1},
    new Student()  {StudendId = 4 , StudentName = "Fatma" , ClassId = 3},
    new Student()  {StudendId = 5, StudentName = "Ahmet" , ClassId = 2}
};

var classes = new List<Classs>()
{
    new Classs()  {Id = 1, ClassName = "Matematik"},
    new Classs()  {Id = 2, ClassName = "Türkçe"},
    new Classs()  {Id = 3, ClassName = "Kimya"}    
};

var result = classes.GroupJoin
    (
        students, classs => classs.Id, student => student.ClassId, (classs,studentGroup) => new {Classs = classs, Student = studentGroup.ToList()}
    );


foreach (var classs in result)
{
    Console.WriteLine(classs.Classs.ClassName);
    Console.WriteLine("--------------------");
    foreach (var s in classs.Student)
    {
        Console.WriteLine(s.StudendId + " " + s.StudentName);
    }

    Console.WriteLine("-------------------");
}