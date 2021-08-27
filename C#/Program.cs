using System;

namespace C__Zadaci_sa_neta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input a string: ");
            
            //var zadatak1 = new Zadatak1();
            //zadatak1.SetNewString(Console.ReadLine());
            //System.Console.WriteLine(zadatak1.GetNewString());
//
            //zadatak1.Result = new string (Console.ReadLine()); //Zadatak1 drugi nacin, isto treba inicijalizacija ova gore
            //System.Console.WriteLine(zadatak1.Result);
//
//
            //var result = new Zadatak1tacka1(Console.ReadLine()); //Zadatak1tacka1
            //System.Console.WriteLine(result.result1);



            var result = new Zadatak1tacka2
                                { //NE RADI SA PRIVATE ZA FIELD U KLASI
                                    result2 = "if" + Console.ReadLine(), //Zadatak1tacka2 preko object initialization syntax
                                };

            System.Console.WriteLine(result.result2);

//****************************************************************************Zadatak2******************************************************

        var person = new Person(new DateTime(1992, 1, 1)); //Setovali smo Birthdate i inicijalizirali objekat
        System.Console.WriteLine(person.Age); 


        
            

        }
    }
}
