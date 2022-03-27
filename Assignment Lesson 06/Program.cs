/* A program that reads several numbers from the console, and breaks when 
  a number that is simultaneously divisible by 3 and 7 is encountered */
static void Main()
{
  bool condition = true;
  while(condition == true)
  {
    Console.WriteLine("Enter a number and hit the return key");
    int input = int.Parse(Console.ReadLine());

    if(input.GetType().ToString() != "System.Int32"){
      Console.WriteLine("Input is not an integer");
      condition = false;
    }
    else if(input % 3 == 0 && input % 7 == 0){
      condition = false;
    }
  }
}
// Main();


/* a program that prints to the console all the numbers divisible
 by 7 from 1 to 300, excluding numbers that are both divisible by 
 5 and 7*/
static void Indivisible()
{
  for(int i = 0; i <= 300; i++){
    if(i % 7 == 0 && i % 5 != 0){
      Console.WriteLine(i);
    }
  }
}
// Indivisible();


/* Q10. Write a program that reads from the console a positive integer number
  N (N < 20) and prints a matrix in the order in the provided diagram */
static void Q10()
{
  int n = 4;
  for(int i = 1; i <= n; i++){
    for(int j = i; j <= (i + n - 1); j++){
      Console.Write(j);
    }
    Console.WriteLine("");
  }
}
// Q10();



/* Q16.  Write a program that by a given integer N prints the numbers from 1 to N
in random order.*/
static void Q16(){
  int[] arr = {1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10};
  Random random = new System.Random();
  int randFrom = random.Next(1, arr.Length);
  int randTo = random.Next(1, arr.Length);

  foreach (int i in arr)
  {
    int holder;
    holder = arr[randFrom];
    arr[randFrom] = arr[randTo];
    arr[randTo] = holder;
    Console.WriteLine(i);
  }
}
// Q16();



static void Q17(int a, int b){
  int LCM = a * b;
  // int GCD = 
}