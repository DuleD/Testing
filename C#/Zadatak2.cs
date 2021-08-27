using System;


public class Person
{
    public DateTime Birthdate { get; private set;} //private set jer ne zelimo da moze da setuje preko person.Birthdate vec samo preko konstruktora

    public Person(DateTime birthdate) //OVO JE KONSTRUKTOR SETTER ZA BIRTHDATE jer je setter gore prvate
    {
        Birthdate = birthdate;
    }
    public int Age 
    {//OVO JE ISTO FIELD, stavili smo mu samo get, ne zelimo da se direktno setuje jer set zavisi od Birthdate tako da set nismo ni pisali
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;

            return years;
        }
    }

}
