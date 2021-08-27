using System.Collections.Generic;

//Write a C# Sharp program to create a new string where 'if' 
//is added to the front of a given string. If the string already 
//begins with 'if', return the string unchanged.

public class Zadatak1
{   
    private string result;

    public void SetNewString(string input)
    {
        result = "if" + input;
    }

    public string GetNewString()
    {
        return result;
    }

    public string Result  
    {
        //drugi nacin da se napise ovo gore
        set {result = "if" + value;}
        get {return result;}
        
    }


}

public class Zadatak1tacka1 //Jos laksi nacin da se napise ovo gore
{
    public string result1 {get; set;} //ne mora get i set ovde
    public Zadatak1tacka1(string input)
    {
        result1 = "if" + input;
    }

}

public class Zadatak1tacka2
{
    public string result2; //ne radi sa private jer polje nije nigde inicijalizovan
}

public class Vehicle //PRIMER INICIJALIZACIJE FIELDA _registr... INICIJALIZIRAMO GA TJ DODAJEMO MU NEKU VREDNOST
{
    private string _registrationNumber;
    public Vehicle(string registrationnumber)
    {
        _registrationNumber = registrationnumber;
    }
}

