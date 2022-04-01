
/* Q1. Write a program that solves any quadratic function */

static void Quadratic(int a, int b, int c){
  double x; double y;

  x = (-b + Math.Sqrt(Math.Pow(b,2)) - (4 * a * c))/(2 * a);
  y = (b + Math.Sqrt(Math.Pow(b,2)) - (4 * a * c))/(2 * a);
  Console.WriteLine(x + " " + y);
}

Quadratic(4, 2, 3);






/* Q2. Write a program that creates the factorial of any number*/

static int Factorial(int num){
  if(num < 0){
    return 0;
  }
  num += Factorial(num - 1);
  return num;
}

int factorial = Factorial(5);
Console.WriteLine(factorial);









/* Q3. Write a function that returns the name of any 
  value passed to it between 1 to 100 (e.g 1 - One)*/

static string NumToWords (int num){
  if(num > 10000) return "Input above range";
  string result = "";
  int numVar = num;
 
  while(numVar >= 100){
    result += "one hundred ";
    numVar -= 100;
    // numVar !== 0 ? result += "and " : null;
  }

  while(numVar >= 90){
    result += "ninety ";
    numVar -= 90;
  }

  while(numVar >= 80){
    result += "eighty ";
    numVar -= 80;
  }

  while(numVar >= 70){
    result += "seventy ";
    numVar -= 70;
  }

  while(numVar >= 60){
    result += "sixty ";
    numVar -= 60;
  }

  while(numVar >= 50){
    result += "fifty ";
    numVar -= 50;
  }

  while(numVar >= 40){
    result += "forty ";
    numVar -= 40;
  }

  while(numVar >= 30){
    result += "thirty";
    numVar -= 30;
  }

  while(numVar >= 20){
    result += "twenty";
    numVar -= 20;
  }

  while(numVar >= 19){
    result += "nineteen";
    numVar -= 19;
  }

  while(numVar >= 18){
    result += "eighteen";
    numVar -= 18;
  }

  while(numVar >= 17){
    result += "seventeen";
    numVar -= 17;
  }

  while(numVar >= 16){
    result += "sixteen";
    numVar -= 16;
  }

  while(numVar >= 15){
    result += "fifteen";
    numVar -= 15;
  }

  while(numVar >= 14){
    result += "fourteen";
    numVar -= 14;
  }

  while(numVar >= 13){
    result += "thirteen";
    numVar -= 13;
  }

  while(numVar >= 12){
    result += "twelve";
    numVar -= 12;
  }

  while(numVar >= 11){
    result += "eleven";
    numVar -= 11;
  }

  while(numVar >= 10){
    result += "ten";
    numVar -= 10;
  }

  while(numVar >= 9){
    result += "nine";
    numVar -= 9;
  }

  while(numVar >= 8){
    result += "eight";
    numVar -= 8;
  }

  while(numVar >= 7){
    result += "seven";
    numVar -= 7;
  }

  while(numVar >= 6){
    result += "six";
    numVar -= 6;
  }

  while(numVar >= 5){
    result += "five";
    numVar -= 5;
  }

  while(numVar >= 4){
    result += "four";
    numVar -= 4;
  }

  while(numVar >= 3){
    result += "three";
    numVar -= 3;
  }

  while(numVar >= 2){
    result += "two";
    numVar -= 2;
  }

  while(numVar >= 1){
    result += "one";
    numVar -= 1;
  }

  return result;
}

string ans = NumToWords(10);
Console.WriteLine(ans);







/* Q4. Write a function that returns the total 
number of string character passed to it*/

static int StringNum (string arg){
  int countVal = 0;
  foreach(int item in arg){
    countVal += 1;
  }
  return countVal;
}

int res = StringNum("Harvard");
Console.WriteLine(res);


