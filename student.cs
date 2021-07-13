using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{

 // write or read data to this class 


 class student : person
 {
  //student child of a person
  //access properies of student and peson class

  //private field(backing field) hold any data assigned name property
  private string _name;
  public student()
  {
   //initialize
   _name = "";
  }
  //Name property
  public string Name
  {
   // get accessor - Read data from class  Set accesor - Write data
   get
   {
    return _name;
   }
   set
   {
    //value property of set accessor automatically created by compiler
    _name = value;
   }
  }
  //instantiate student object with property

 }
}