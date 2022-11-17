using System;
namespace Name
{
    class Program
    {
        public static void Main(String [] args){
            int age;
            Console.WriteLine("Hospital management");
            Console.WriteLine("Click i for insert");
            Console.WriteLine("Click u for update");
            Console.WriteLine("Click d for delete");
            string input = Console.ReadLine();
            switch(input){
                case "i": {
                    Console.WriteLine("You click for insert");
                    Console.WriteLine("Enter Patient name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Patient Age");
                    string agechar = Console.ReadLine();
                    age=Convert.ToInt32(agechar);
                    Console.WriteLine("Enter Patient Address");
                    string address = Console.ReadLine();
                    Console.WriteLine("Patient name is "+name+".  is "+age+" years old from "+address+".");
                    break;
                }
                case "u": {
                    Console.WriteLine("You click for update");
                    break;
                }
                case "d": {
                    Console.WriteLine("You click for delete");
                    break;
                }
                
            }
        }   
    }
}