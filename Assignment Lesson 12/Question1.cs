namespace Question1
{
  class Person
  {
    public string Name {get; set;}
  }

  class Course
  {
    public string Name {get; set;}
    public int ClassCount {get; set;}
    public int ExerciseCount {get; set;}
  }

  class Class
  {
    public string ClassName {get; set;}
  }

  class Student: Person, Class
  {
    public Student(string studentName)
    {
      Name = studentName;
    }
    public string RegNo {get; set;}
  }

  class Teacher: Person, Course
  {

  }
}