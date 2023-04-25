using TMPS_lab1.Prototype.Domain;

namespace TMPS_lab1.Prototype
{
    public static class PrototypeExample
    {
        public static void StartExample()
        {
            Doctor doctor = new Doctor() { FirstName = "James", LastName = "Anderson", Type = "Surgeon" };
            Patient patient = new Patient() { FirstName = "Steve", LastName = "Smith" };

            var surgeryAppointment = new SurgeryAppointment()
            {
                Doctor = doctor,
                Patient = patient,
                DateTime = new DateTime(2023, 4, 20, 13, 30, 0),
                Duration = 2,
                SeverityLevel = SeverityLevel.SubstantialSeverity
            };

            SurgeryAppointment surgeryAppointment2 = (SurgeryAppointment)surgeryAppointment.Clone();
            surgeryAppointment2.DateTime = new DateTime(2023, 4, 22, 12, 0, 0);
            surgeryAppointment2.SeverityLevel = SeverityLevel.ModerateSeverity;
        }
    }
}