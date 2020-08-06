using System.Xml;
using Library.Models;

namespace ExtensionMethodAndMethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "What is your First Name".RequestString();
            person.FirstName = "What is your Last Name".RequestString();
            //person.Age = "What is your Age".RequestInt();

            person.Age = "What is your Age".RequestInt(0, 120);
        }
    }
}
