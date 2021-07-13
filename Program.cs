using System;

namespace OOP
{
 class Program
 {
  static void Main(string[] args)
  {
   try
   {
    string input;
    string name;
    Console.Write("Type 1 if you want to talk to others and type 2 if you would rather keep to yourself : ");
    input = Console.ReadLine();

    person myperson = new person();
    myperson.AskQuestion(int.Parse(input));
    Console.WriteLine("You are : " + myperson.GetPersonality());

    Console.Write("What is your name : ");
    name = Console.ReadLine();

    //access student object
    student mystudent = new student();
    mystudent.Name = name;
    Console.WriteLine("Your name is " + mystudent.Name + " and your personality type is : " + mystudent.GetPersonality());
   }
   catch
   {
    Console.WriteLine("Please enter an integer value");

   }

  }
 }
}
