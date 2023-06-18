// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Mosh {
    public interface IPerson {
        string FirstName {get; set;}
        string MiddleName {get; set;}
        string LastName {get; set;}
        string Gender {get; set;}
    
        string GetProfile();
    }

    public class Person: IPerson {
        public string FirstName {get; set;}
        public string MiddleName {get; set;}
        public string LastName {get; set;}
        public string Gender {get; set;}
    
        public Person (string fName, string lName, string mName, string gender){
            FirstName = fName;
            MiddleName = mName;
            LastName = lName;
            Gender = gender;
        }
    
        public string GetProfile(){
            return $"{FirstName}" + ", " + 
                    $"{LastName}" + ", " +
                    $"{MiddleName}" + ", " +
                    $"{Gender}";
        }
    }

    class sampleProgram {
        static void Main (string[] args) {
            Person myPerson = new Person ("Jose Luis", "Nido", "Arambulo", "Male");
            Console.WriteLine(myPerson.GetProfile());
        }
    }
}


// namespace Mosh
// {
//     public interface IPerson
//     {
//         string FirstName { get; set; }
//         string LastName { get; set; }
//         string MiddleName { get; set; }
//         string Gender { get; set; }

//         string GetProfile();
//     }

//     // Create a public class Person and implement IPerson
//     public class Person : IPerson
//     {
//         private string firstName;
//         private string lastName;
//         private string middleName;
//         private string gender;

//         public Person(string firstName, string lastName, string middleName, string gender)
//         {
//             this.firstName = firstName;
//             this.lastName = lastName;
//             this.middleName = middleName;
//             this.gender = gender;
//         }

//         public string FirstName
//         {
//             get { return firstName; }
//             set { firstName = value; }
//         }

//         public string LastName
//         {
//             get { return lastName; }
//             set { lastName = value; }
//         }

//         public string MiddleName
//         {
//             get { return middleName; }
//             set { middleName = value; }
//         }

//         public string Gender
//         {
//             get { return gender; }
//             set { gender = value; }
//         }

//         public string GetProfile()
//         {
//             return $"FirstName: {firstName}, LastName: {lastName}, MiddleName: {middleName}, Gender: {gender}";
//         }

        
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person person = new Person("Aron", "Ligsay", "A", "Male");
//             Console.WriteLine(person.GetProfile());
//         }
//     }

// }


// namespace Mosh
// {
//     interface IPerson
//     {
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//         public string MiddleName { get; set; }
//         public string Gender { get; set; }


//         public void GetProfile();
//     }

//     class Person : IPerson
//     {
//         private string firstName;
//         private string lastName;
//         private string middleName;
//         private string gender;
        
//         public string FirstName { get { return FirstName; } set { FirstName = value; } }
//         public string LastName { get { return LastName; } set { LastName = value; } }
//         public string MiddleName { get { return MiddleName; } set { MiddleName = value; } }
//         public string Gender { get { return Gender; } set { Gender = value; } }


//         public Person(string firstName, string lastName, string middleName, string gender)
//         {
//             this.firstName = firstName;
//             this.lastName = lastName;
//             this.middleName = middleName;
//             this.gender = gender;
//         }

//         public string GetProfile() {
//             return $"FirstName: {firstName}, LastName: {lastName}, MiddleName: {middleName},Gender: {gender}" ;
//         }

//         void IPerson.GetProfile()
//         {
//             throw new NotImplementedException();
//         }
//     }
    
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person person = new Person("Aron Kurt Yuan", "Ligsay", "A", "Male");
//             Console.WriteLine(person.GetProfile());
//         }
//     }
// }
    