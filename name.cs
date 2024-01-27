/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    int age = 10;
    string name = "Medoded";
    bool isGoal = true;
    Console.WriteLine(name + " " + age);
    
    if ((age < 18) && (age > 10) ) {
        Console.WriteLine("Вы не можете купить игру");
    }
    else {
        Console.WriteLine("Вы можете купить");
    }
    for (int i = 0; i < 100; i++)
    {
         Console.WriteLine("Текущий проход по циклу " + i);
    }
    int a = 10;
    while (a <= 100) {
        Console.WriteLine("Текущий проход по циклу " + a);
        a = a + 10;
    }
    
  }
}
