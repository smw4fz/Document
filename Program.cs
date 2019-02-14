using System;
using System.IO; 

namespace Document_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
              
                Console.WriteLine("Document");
                Console.WriteLine("\nWhat is the name of the document?");
                string name = Console.ReadLine(); 
                Console.WriteLine("What is the content in {0}?", name);
                string content = Console.ReadLine();
    
        try
            {
                StreamWriter sw = new StreamWriter("C:\\name.txt");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            } 
            finally
            {
                Console.WriteLine("Executing finally block.");
            } 
        } 
    }
}