using System.Diagnostics;

namespace PatientPerson;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Patient
{

    public void display()
    {
        Console.WriteLine("PLEASE FILL OUT INFORMATION BELOW IF POSSIBLE" + FirstName + Birthday + Cellphone);

    }
    static void Main(string[] args)
    {
        Console.ReadLine();
    }
    public int MedicalRecordNumber { get; set; }
    public required string FirstName;
    public DateTime Birthday;
    public  required string BloodType;
    public required string CellPhone;

    public Patient(int medicalRecordNumber, string firstName, DateTime birthday, string bloodType, string cellPhone)
    {
        MedicalRecordNumber = medicalRecordNumber;
        FirstName = firstName;
        Birthday = birthday;
        BloodType = bloodType;
        CellPhone = cellPhone;
    }

    public Patient()
    {
    }

    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Admission : IPatient1
    {
        private string lastName;

        public string GetLastName() => lastName;
        private void SetLastName(string value) => lastName = value;
        public void CreatePatient(string lastName, DateTime admissionDate) => throw new NotImplementedException();

            public override string ToString()
            {
                return GetLastName() + "Is located in room 6331";

            }

            private string GetDebuggerDisplay()
            {
                return ToString();
            }

            public override int GetHashCode()
            {
                throw new NotImplementedException();
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        public override bool Equals(object? obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
        public override string? ToString() => base.ToString();
        public void CreatePatient(string lastName, DateTime admissionDate) => throw new NotImplementedException();


    }





   