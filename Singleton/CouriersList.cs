namespace TMPS_lab1.Singleton
{
    public static class CouriersList
    {
        public static List<Courier> Couriers { get; set; }

        static CouriersList()
        {
            Couriers = new List<Courier>();
        }
    }
}