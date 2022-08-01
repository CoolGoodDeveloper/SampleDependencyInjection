using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Baleno: ICar //Inheriting from interface
    {
        public void Model() //Implementation of interface function
        {
            Console.WriteLine("Maruti Suzuki Baleno");
        }
    }
}
