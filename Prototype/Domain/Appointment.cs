namespace TMPS_lab1.Prototype.Domain
{
    public abstract class Appointment
    {
        public Doctor Doctor { get; set; } = new Doctor();
        public Patient Patient { get; set; } = new Patient();
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }

        public abstract Appointment Clone();
    }
}