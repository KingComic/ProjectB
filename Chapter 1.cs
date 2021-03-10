// BA 25
// class Program {
//   public static void Main() {
//     int num = 6;
//     string result = "";
//     if (num % 2 == 0) {
//       result = "Even";
//     }
//     else {
//       result = "Odd";
//     }
//   }
// }
// BA 26
// class Program {
//   public static void Main() {
//     int num = 6;
//     string result = "";
//     if (num > 0) {
//       result = "positive";
//     }
//     else if (num == 0) {
//       result = "zero";
//     }
//     else {
//       result = "negative";
//     }
//   }
// }
// BA 27
// class Program {
//   public static void Main() {
//     int x = 6;
//     int y = 5;
//     string result = "";
//     if (x > y) {
//       result = "x is biggest";
//     }
//     else if (y > x) {
//       result = "y is biggest";
//     }
//     else if (y == x) {
//       result = "x and y are equal";
//     }
//   }
// }
// BA28
// class Program {
//   public static void Main() {
//     int temperature = 5;

//     string desc = "";
//     if (temperature < 0) {
//       desc = "Freezing";
//     }
//     else if (temperature < 15) {
//       desc = "Chilly";
//     }
//     else if (temperature < 25) {
//       desc = "Warm";
//     }
//     else {
//       desc = "Hot";
//     }
//   }
// }


// // BA29
// class Program {
//   public static void Main() {
//     int age = 3;
//     string result = "";
//     if (age <= 12 && age >= 0) {
//       result = "Child";
//     }
//   }
// }

// // BA30
// class Program {
//   public static void Main() {
//     int enteredPasscode = 12345;
//     string enteredUserName = "user";
//     int passcode = 123456;
//     string userName = "user";
    
//     string result = "";
//     if (enteredPasscode == passcode && enteredUserName == userName ) {
//       result = "Acces granted";
//     }
//     else if (enteredUserName != userName) {
//       result = "Incorrect user name";
//       if (enteredPasscode != passcode) {
//         result += " and passcode";
//       }
//     }
//     else if (enteredPasscode != passcode) {
//       result = "Incorrect passcode";
//       if (enteredUserName != userName) {
//         result += " and user name";
//         int a = 10
//       }
//     }
//   }
// }
// BA31
// class Program {
//   public static void Main() {
//     int year = 1900;
//     string result = "";
//       if (year % 400 == 0 || (year%4 == 0 && year%100 !=0)) {
//         result = year + " is a leap year";
//       }
//       else {
//         result = year + " is not a leap year";
//       }
//   }
// }
// BA32
// class Program {
//   public static void Main() {
//     double side1 = 6.0;
//     double side2 = 6.0;
//     double side3 = 6.0;
    
//     string result = "";
//     if (side1 == side2 && side2 == side3 && side3 == side1) {
//       result = "Equilateral and isosceles";
//     }
//     else if (side1 != side2 && side2 != side3 && side3 != side1) {
//       result = "Neither equilateral nor isosceles";
//     }
//     else if (side1 != side2 || side2 != side3 || side3 != side1) {
//       result = "Isosceles";
//     }
//   }
// }

// #BA41
// class Program {
//   public static void Main() {
//     double  n;
//     n = 1.0  ;
//     while (n <  1024.0) {
//         n = n * 2;
//     }
//   }
// }

// BA42
// class Program {
//   public static void Main() {
//     int    limit = 10  ;
//     int   n = 1  ;
//     string  res = ""  ;
//     while (n <= limit  ) {
//       int squared = n * n;
//       res = n + " squared is " + squared;
//     n = n + 1;
//     }
//   }
// }
// 
// class Program {
//   public static void Main() {
//     int limit = 10;
//     string s = "";
//     while(limit >= 0) {  
//       s += limit + " ";
//     limit = limit - 2;
//     }
//   }
// }
// BA44
// class Program {
//   public static void Main() {
//     int num = 54321;
//     string s = "";
//     while(num > 0){ 
//     int rem = num % 10;
//         num = num / 10;
//     s += rem + ".";

//     }
//   }
// }

// BA45
// class Program {
//   public static void Main() {
//     int num = 26;
//     string s = "";
//     while(num > 0)   {
//       int binary = num % 2;
//       s = binary + s;
//     num = num / 2;
//     }
//   }
// }


// BA46
// class Program {
//   public static void Main() {
//     string fig = "";
//     int width = 5;
//     int height = 3;

//     int i = 0;
//     while (i < height) {
//       int j = 0;
//       while (j < width) {
//         fig = fig + "*";
//         j = j + 1;
//       }
//       i = i + 1;
//       fig = fig + '\n';
//     }
//   }
// }
// BA47
// class Program {
//   public static void Main() {
//     int num = 5;
//     int i = 0;
//     string s = "";
//     while(i < num) {  
//       int j = 0;
//       while(j < i + 1) { 
//         s += "*";
//         j = j + 1;
//       }
//       i = i + 1;
//       s = s + "\n";
//     }
//   }
// }
// BA59
// class Program {
//   public static void Main() {
//     int n = 7;
//     var s = "";
//     for (int i = 1  ; i <= 10   ; i++  ) {
//       int multiply = i * n;
//       s = i + " * " + n + " = " + multiply;
//     }
//   }
// }
// BA60
// class Program {
//   public static void Main() {
//     int start = 2;
//     int incr = 3;
//     int end = 16;

//     string res = "";
//     for(int x = start ; x < end;)   {
//         res = res + ">" +  x;
//         x = x + incr;

//     }
//   }
// }
// BA61
// class Program {
//   public static void Main() {
//     int n = 10;
//     string s = "";
//     for(int i = n ; i >= 0;)   {
//       s += i + " ";
//       i--;
//     }
//   }
// }
// BA62
// class Program {
//   public static void Main() {
//     int n = 7;
//     int sum = 0;
//     for(int i = 1; i <= n; i++)   {
//       sum = sum + i;
//     }
//   }
// }
// BA63
// class Program {
//   public static void Main() {
//     int n = 16;
//     string s = "";
//     for(int i = 1; i <= n; i++) {
//       if (i % 3 == 0 && i % 5 == 0) {
//         s += "FizzBuzz ";
//       }
//       else if (i % 3 == 0) {
//         s += "Fizz ";
//       }
//       else if (i % 5 == 0) {
//         s += "Buzz ";
//       }
//       else {
//         s += i + " ";
//       }
//     }
//   }
// }
// BA64
// class Program {
//   public static void Main() {
//     int n = 4;
//     var s = "";
//     for(int i = 0; i < n; i++ ) { 
//       for(int j = 0; j < n; j++) {  
//         s += i + ":" + j +  " ";
//       }
//       s += "\n";
//     }
//   }
// }

