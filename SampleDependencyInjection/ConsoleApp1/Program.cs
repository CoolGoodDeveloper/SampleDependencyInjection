using System;
using ConsoleApp1.Classes;
class Program
{
    static void Main(string[] args)
    {
        //creating object
        Alto alto = new Alto();
        //passing dependency
        Car car = new Car(alto);
        //TO DO:
        car.CarMethod();

        Baleno baleno = new Baleno();
        //passing dependency
        car = new Car(baleno);
        //TO DO:
        car.CarMethod();
    }
}