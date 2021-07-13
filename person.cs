using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
 class person
 {
  //Declare a field to represent personality
  private string personality;
  //Constructor
  public person()
  {
   personality = "Mystery";
  }
  public void AskQuestion(int answer)
  {
   if (answer == 1)
   {
    personality = "Extrovert";
   }
   else if (answer == 2)
   {
    personality = "Introvert";
   }
   else
   {
    personality = "You are still a mystery";
   }
  }
  //This method returns value of personality
  public string GetPersonality()
  {
   return personality;
  }
 }
}