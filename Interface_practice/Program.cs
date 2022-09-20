// Interface Practice
// Datatype

using Interface_practice;

Person p1;
p1 = new Person();
p1.age = 20;
p1.name = "Jack";

Student stu1;
stu1 = new Student();
stu1.age = 22;
stu1.name = "Joey";
stu1.stuID = "stu819";

Student stu2 = new Student() { age = 20, name = "Brad", stuID = "stu8493" };

double ex1Grade = stu1.TakeMIS3033Excercise();
Console.WriteLine(stu1.MIS3033Homework());
Console.WriteLine(ex1Grade);

IMIS3033Stu mis3033Stu;
mis3033Stu = stu1;

Person p2;
p2 = (Person) mis3033Stu;

Student stu3;
stu3 = (Student) p2;

double i = Convert.ToDouble("130.8");
// i = (double)"130.8";


Console.ReadLine();