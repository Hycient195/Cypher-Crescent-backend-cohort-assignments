/* Q1. Write a program, which creates an array of 20 elements of type
  integer and initializes each of the elements with a value equals to the
  index of the element multiplied by 5. Print the elements to the console*/
static void Q1()
{
  int[] arr = new int[20];

  for(int i = 1; i < 20; i++){
    arr[i] = (i * 5);
    
    // arr.CopyTo(i);
    Console.Write($"{arr[i]}, ");
  }
}
// Q1();



/* Q2. Write a program, which reads two arrays from the console and checks
  whether they are equal (two arrays are equal when they are of equal
  length and all of their elements, which have the same index, are equal) */
static void Q2()
{
  Console.WriteLine("Enter the value of the first array separated by commas");
  string arr1 = Console.ReadLine();

  Console.WriteLine("Enter the value of the second array separated by commas");
  string arr2 = Console.ReadLine();

  string[] splArr1 = arr1.Split(",");
  string[] splArr2 = arr2.Split(",");

  string message = "";
  for(int i = 0; i < splArr1.Length; i++){
    if(splArr1.Length == splArr2.Length && splArr1[i] == splArr2[i]){
      message = "The both arrays entered are equal";
    }
    else{
      message = "The both arrays entered are not equal";
    }
    
  }
  Console.WriteLine(message);
}
// Q2();


/* Q3. Write a program, which compares two arrays of type char
  lexicographically (character by character) and checks, which one is first
  in the lexicographical order*/
static void Q3()
{
  Console.WriteLine("Enter the character values of the first array separated by commas");
  string arr1 = Console.ReadLine();

  Console.WriteLine("Enter the character values of the second array separated by commas");
  string arr2 = Console.ReadLine();

  char[] splArr1 = new char[arr1.Length];
  char[] splArr2 = new char[arr2.Length];

  /* Determining which of the array has more content */
  char[] longerArray;
  if(splArr1.Length > splArr2.Length){
    longerArray = splArr1;
  }else{
    longerArray = splArr2;
  }

  for(int i = 0; i < longerArray.Length; i++){
    splArr1[i] = arr1[i];
    splArr2[i] = arr2[i];
  }

  string message = "";
  for(int i = 0; i < longerArray.Length; i++){
    if((int)splArr1[i] < (int)splArr2[i] ){
      message = "The first array comes first in the lexicographical order";
    }else{
      message = "The second array comes first in the lexicographical order";
    }
  }
  Console.WriteLine(message);

}
// Q3();



/* Q8. Write a program, which sorts an array using the
algorithm " selection sort .*/
static void Q8()
{
  int[] arr = {4,6,2,7,3,9,1,8,6,8,12};

  for(int i = 0; i < arr.Length -1; i++){
    for(int j = 0; j < arr.Length -1; j++){
      if(arr[j] > arr[j + 1]){
        int holder;
        holder = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = holder;
      }
    }
  }
  /* Printing the result to console */
  foreach(int item in arr){
    Console.Write(item + ", ");
  }
  Console.WriteLine("");
}
// Q8();




/* Q10. Write a program, which finds the most frequently occurring element in
  an array */
static void Q10()
{
  int[] numArr = {6, 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};
  int[] holder = new int[numArr.Length];

  for(int i = 0; i < numArr.Length; i++){
    int tempVal = 0;
    for(int j = 0; j < numArr.Length; j++){
      if(numArr[i] == numArr[j]){
        tempVal ++;
        // numArr[i] = 0;
      }
    }
    holder[i] = tempVal;
  }

  Console.WriteLine(Array.IndexOf(holder, holder.Max()));
  Console.WriteLine($"The number {numArr[Array.IndexOf(holder, holder.Max())]} occours the most with a frequency of {holder.Max()} times!");
}
// Q10();

static void Q13()
{
  Console.WriteLine("Numer the number of rows for the matrix");
  int rows = int.Parse(Console.ReadLine());

  Console.WriteLine("Numer the number of columns for the matrix");
  int columns = int.Parse(Console.ReadLine());

  for(int i = 0; i < (rows*rows); i+=rows){
    Console.Write("|");
    for(int j = 1; j <= columns; j++){
      Console.Write($"  {j+i}, ");
    }
    Console.WriteLine("|");
  }
}
// Q13();



/* Q15. Write a program, which creates an array containing all Latin letters.
  The user inputs a word from the console and as result the program
  prints to the console the indices of the letters from the word */
static void Q15()
{
  Console.WriteLine("Enter the word");
  string input = Console.ReadLine();
  char[] inputArr = new char[input.Length];
  for(int i = 0; i < input.Length; i++){
    inputArr[i] = input[i];
  }

  foreach(int item in inputArr){
    Console.Write(item + " ");
  }
  Console.WriteLine("");
}
// Q15();