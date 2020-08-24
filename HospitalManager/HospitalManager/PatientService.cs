using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManager
{
    public class PatientService
    {
        private List<Patient> patients;
        public PatientService()
        {
            patients = new List<Patient>();
        }
        public List<Patient> GetAllPatients()
        {
            return patients;
        }

        public void GetNewPatientData(LoginAction user)
        {
            string firstName, lastName, pesel, emailAdress;
            int phoneNumber;
            Console.Write("Please write patient's name: ");
            firstName = Console.ReadLine();
            Console.Write("Please write patient's lastname: ");
            lastName = Console.ReadLine();
            Console.Write("Please write patient's PESEL number: ");
            pesel = Console.ReadLine();
            Console.Write("Please write patient's phone number: ");
            Int32.TryParse(Console.ReadLine(), out phoneNumber);
            Console.Write("Please write patient's e-mail adress: ");
            emailAdress = Console.ReadLine();

            AddPatient(user, firstName, lastName, pesel, phoneNumber, emailAdress);

        }

        private void AddPatient(LoginAction user, string firstName, string lastName, string pesel, int phoneNumber, string emailAdress)
        {
            int patientId = patients.Count + 1;
            Patient patient = new Patient(user) { Id = patientId, FirstName = firstName, LastName = lastName, PESEL = pesel, PhoneNumber = phoneNumber, EmailAdress= emailAdress};
            patients.Add(patient);
        }
    }
}
