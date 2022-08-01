using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interface;

namespace ConsoleApp1.Classes
{
    public class Car
    {
        private ICar _car;
        public Car(ICar car) //Passing Dependency
        {
            this._car = car;
        }
        public void CarMethod()
        {
            this._car.Model(); //Calling Function
        }
    }
}
