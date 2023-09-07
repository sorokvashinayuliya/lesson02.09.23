using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lesson02._09._23
  
{
   
    /*задача 1*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string peace = "";
            string labor = "";
            string may = "";
            Console.WriteLine("Ведите слова");
            
            {
             peace = Console.ReadLine();
             labor = Console.ReadLine();
             may = Console.ReadLine();
               
            }
            Console.WriteLine(peace+" "+ labor+" "+may);
            Console.WriteLine(peace);
            Console.WriteLine("   " + labor);
            Console.WriteLine("       " + may);
            

        }

        
        
    }
}
