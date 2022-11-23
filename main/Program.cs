using System;
namespace Name
{
    class Program
    {
        public static void Main(String [] args)
        {
            int age;
            Console.WriteLine("Hospital management \n Click i for insert \n Click u for update \n Click d for delete");
            string input = Console.ReadLine();
            switch(input){
                case "i": {
                    Console.WriteLine("You click for insert \n Enter Patient name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Patient Age");
                    string agechar = Console.ReadLine();
                    age=Convert.ToInt32(agechar);
                    Console.WriteLine("Enter Patient Address");
                    string address = Console.ReadLine();
                    Console.WriteLine("Patient name is "+name+" who is "+age+" years old from "+address+". \n Do you want to save it? 'y' for yes & n'for no(y/n)");
                    string insert = Console.ReadLine();
                    switch(insert){
                        case "y": {
                            Console.WriteLine("Sucessfully saved");
                            break;
                        }
                        case "n": {
                            Console.WriteLine("Data was nota saved");
                            break;
                        }
                    }
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