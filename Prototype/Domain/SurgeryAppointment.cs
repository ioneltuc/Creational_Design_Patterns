namespace TMPS_lab1.Prototype.Domain
{
    public class SurgeryAppointment : Appointment
    {
        public SeverityLevel SeverityLevel { get; set; }

        public override Appointment Clone()
        {
            var copy = new SurgeryAppointment();

            copy.Doctor.FirstName = this.Doctor.FirstName;
            copy.Doctor.LastName = this.Doctor.LastName;
            copy.Doctor.Type = this.Doctor.Type;
            copy.Patient.FirstName = this.Patient.FirstName;
            copy.Patient.LastName = this.Patient.LastName;
            copy.Description = this.Description;
            copy.DateTime = this.DateTime;
            copy.Duration = this.Duration;

            return copy;
        }
    }
}