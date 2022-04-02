using System;
using System.Diagnostics;
using System.Threading;


/* Q1. Solve recursively the sum of all n number (n+n-1+….0) */

static int Recursive(int num){
  if(num < 0){
    return 0;
  }
  num += Recursive(num - 1);
  return num;
}

int factorial = Recursive(5);
Console.WriteLine(factorial);






/* Q2. Determine the length of any string characters 
  using a recursive action */

static int StringLength (string arg){
  int countVal = 0;
  foreach(int item in arg){
    countVal += 1;
  }
  return countVal;
}

int res = StringLength("Harvard");
Console.WriteLine(res);






/* Q3. Print all Prime numbers for a specified range of 
  values using recursion */

static int Prime(int num){
  if(num <= 0){
    return 0;
  }

  static int InnerPrime(int innerNum){
    if(innerNum <= 0){
      return 0;
    }

    Console.WriteLine($" {innerNum}");
    innerNum = InnerPrime(innerNum - 1);
    return innerNum;
  }

  InnerPrime(num);
  // Console.WriteLine(num);
  num = Prime(num - 1);
  return num;
}

int prime = Prime(20);
Console.WriteLine(prime);




/* Q4. Print all random numbers repeatedly within a range until 
  a certain number is within the range is printed */

static int Randomizer(int range, int targetNum){
  Stopwatch stopwatch = new Stopwatch(); // Initializing the Stopwatch class
  stopwatch.Start(); // Starting the stopwatch at beging of execution
  
  Random randInstance = new Random(); // Instantiating a random number;
  int randNum = randInstance.Next(range); // Generating a random number within the specified range
  
  Console.Write(randNum + " "); // Printing the random number on each iteration.

  if(randNum == targetNum){ // Checking if the desired target number has been encountered
    stopwatch.Stop(); // Stopping the stopwatch;
    TimeSpan ts = stopwatch.Elapsed; // Calculating the elapsed time;
    Console.WriteLine($"\n\n Elapsed duration is {ts.Duration()} "); // Logging the elapsed time to the console;
    return 0;
  }

  randNum = Randomizer(range, targetNum); // Causing a recursion by invoking the function in itself;
  return randNum;
}

Randomizer(10000, 75); // Invoking the function itself;