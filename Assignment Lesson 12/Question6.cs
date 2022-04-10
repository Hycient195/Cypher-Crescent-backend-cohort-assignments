namespace Question6
{
  class Animal
  {
    public int Age {get; set;}
    public string Name {get; set;}
    public char Gender {get; set;}

    public virtual string MakeSound(){
      return "";
    }
  }

  class Dog: Animal
  {
    public Dog(int dogAge, string dogName, char dogGender)
    {
      Age = dogAge;
      Name = dogName;
      Gender = dogGender;
    }
    public override string MakeSound()
    {
      return "Bark bark";
    }
  }

  class Frog: Animal
  {
    public Frog(int frogAge, string frogName, char frogGender)
    {
      Age = frogAge;
      Name = frogName;
      Gender = frogGender;
    }
    public override string MakeSound()
    {
      return "Croak croak";
    }
  }

  class Cat: Animal
  {
    public Cat(int catAge, string catName, char catGender)
    {
      Age = catAge;
      Name = catName;
      Gender = catGender;
    }
    public override string MakeSound()
    {
      return "Meow meow";
    }
  }

  class Kitten: Animal
  {
    public Kitten(int kittenAge, string kittenName, char kittenGender)
    {
      Age = kittenAge;
      Name = kittenName;
      Gender = kittenGender;
    }
    public override string MakeSound()
    {
      return "Squeow Squeow";
    }
  }

  class Tomcat: Animal
  {
    public Tomcat(int tomcatAge, string tomcatName, char tomcatGender)
    {
      Age = tomcatAge;
      Name = tomcatName;
      Gender = tomcatGender;
    }
    public override string MakeSound()
    {
      return "Brrrr brrrr";
    }
  }
}