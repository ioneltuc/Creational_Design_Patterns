namespace TMPS_lab1.AbstractFactory.Abstracts
{
    public abstract class DiplomaBody
    {
        public string HTMLBodyText { get; set; }
        public string AwardedName { get; set; }
        public DateOnly StartInternshipDate { get; set; }
        public DateOnly EndInternshipDate { get; set; }
    }
}