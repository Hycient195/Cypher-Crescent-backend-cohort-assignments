/* Answers to Chapter 20 quetions from the recommended text */
using Question2;
using Question5;
using Question6;


/* Invoking methods from Question 5 */
Triangle triangle = new Triangle();
Console.WriteLine(triangle.CalculateSurface(7,13));
Rectangle rectangle = new Rectangle();
Console.WriteLine(rectangle.CalculateSurface(5,7));



/* Invoking methods from Question 6 */
Dog dog = new Dog(10, "Bingo", 'M');
Frog frog = new Frog(3, "Pike", 'F');
Cat cat = new Cat(2, "Milow", 'M');
Kitten kitten = new Kitten(1, "Scourge", 'F');
Tomcat tomcat = new Tomcat(5, "Tom", 'M');

Animal[] animals = {dog, frog, cat, kitten, tomcat};
Console.WriteLine("\nAnswers to question 6 ");

foreach(Animal animal in animals){
  Console.Write("Name " + animal.Name + ", ");
  Console.Write("Age " + animal.Age + ", ");
  Console.Write("Gender " + animal.Gender + ", ");
  Console.Write("Makes sound " + animal.MakeSound() + "\n");
}



/* Invoking methods from Question 2 */
Worker worker = new Worker();
Console.WriteLine("\n" + worker.CalculateHourlyWage(30000, 10));