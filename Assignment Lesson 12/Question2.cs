namespace Question2
{
  class Human
  {
    public string FirstName {get; set;}
    public string LastName {get; set;}

  }

  class Student: Human
  {
    public string Mark {get; set;}
  }

  class Worker: Human
  {
    public double Wage {get; set;}
    public double HoursWorked {get; set;}
    public double CalculateHourlyWage(double wage, double hoursWorked){
      return wage / hoursWorked;
    }
  }
}