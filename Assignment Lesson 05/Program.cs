/* Program to find the kind of roots of the given parameters "a" "b" and "c"*/
static void Main()
{
  double a = 1;
  double b = 6;
  double c = 5;

  double expression = Math.Pow(b,2) - (4*a*c);
  Console.WriteLine(expression);
}
Main(); // Answer is 16: Equation has real roots.

/* Program to find the kind of quadratic equation roots for user provided values */
static void RootFinder()
{
  Console.WriteLine("Program to find the kind of root of an equation");
  Console.WriteLine("Enter the value for a");
  int a = int.Parse(Console.ReadLine());

  Console.WriteLine("Enter the value for b");
  int b = int.Parse(Console.ReadLine());

  Console.WriteLine("Enter the value for c");
  int c = int.Parse(Console.ReadLine());

  double expression = Math.Pow(b,2) - (4*a*c);
  Console.WriteLine(expression);
}
RootFinder();
