using System;
namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySRP = new SRP();  // Single Responcible Principe
            var myOCP = new OCP();  // Open Closed Principle 
            var myLSP = new LSP();  // Liskov Substitution Principle
            var myISP = new ISP();  // Interface Segregation Principle
            var myDIP = new DIP();  // Dependency Inversion Principle
        }
    }
}