using System;

class HospitalManagement
{
    static void Main()
    {
        Patient[] patientList = new Patient[2];

        Console.WriteLine("Enter In-Patient Details");

        InPatient inPatient =
            new InPatient(
                Convert.ToInt32(ReadInput("Number of Days Admitted: ")),
                Convert.ToDouble(ReadInput("Daily Charge: "))
            );

        inPatient.PatientId = Convert.ToInt32(ReadInput("Patient Id: "));
        inPatient.PatientName = ReadInput("Patient Name: ");
        inPatient.Age = Convert.ToInt32(ReadInput("Age: "));
        inPatient.AddRecord(ReadInput("Diagnosis: "));

        patientList[0] = inPatient;

        Console.WriteLine("\nEnter Out-Patient Details");

        OutPatient outPatient =
            new OutPatient(
                Convert.ToDouble(ReadInput("Consultation Fee: "))
            );

        outPatient.PatientId = Convert.ToInt32(ReadInput("Patient Id: "));
        outPatient.PatientName = ReadInput("Patient Name: ");
        outPatient.Age = Convert.ToInt32(ReadInput("Age: "));
        outPatient.AddRecord(ReadInput("Diagnosis: "));

        patientList[1] = outPatient;

        Console.WriteLine("\nPatient Billing Details");

        for (int index = 0; index < patientList.Length; index++)
        {
            patientList[index].GetPatientDetails();

            double billAmount = patientList[index].CalculateBill();
            Console.WriteLine("Bill Amount: " + billAmount);

            //view medical record only if available
            if (patientList[index] is IMedicalRecord)
            {
                IMedicalRecord medicalRecord =
                    (IMedicalRecord)patientList[index];

                medicalRecord.ViewRecords();
            }

            Console.WriteLine();
        }
    }
    

    static string ReadInput(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
}
