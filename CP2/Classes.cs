using System;

//Class= Building blocks of an app

//Anatomy of a Class
//Data = Represented by fields
//Behvior= Represented by methods / functions

//Object = Instance of a Class that resides in Memory

namespace CP2
{
    //Declaring Classes

    //Public= Access Modifer

    //Naming Conventions
    //Pascal Case= Used when naming Classes
    //camel Case= Used when naming parameter in Methods

    public class Person
    {
        //Put members of the class here

        //Declaring a Field
        //Here, Name is the identifier of the field
        public string Name;

        //Declaring a Method
        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);
        }

		//Creating Objects
		//Type of the class= Person
		//Identifier= person
		Person person = new Person();

        //This is the shorter way to do the same as above
        //var person = new Person();
        
		//Now that we have an object, we can access members of that object
		person.Name = "June";
		person.Introduce();
    }
}
