using System;

class Doctor
{
    public string Name;

    public Doctor(string name)
    {
        Name = name;
    }

    //Communication between doctor and patient
    public void Consult(Patient patient)
    {
        Console.WriteLine(Name + " is consulting " + patient.Name);
    }
}
